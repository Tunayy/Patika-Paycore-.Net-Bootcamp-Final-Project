using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PycApi.Base;
using PycApi.Dto;
using PycApi.Service;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using NHibernate;
using System;

namespace PycApi
{
    
    [ApiController]
    [Route("api/nhb/[controller]")]
    public class Product_Controller : ControllerBase
    {
        //servislerimizi eklediğimiz kısım
        private readonly IProduct_Service productService;
        private readonly IAuth_Service authService;
        private readonly IMapper mapper;

        
        

        public Product_Controller(IProduct_Service prdService, IAuth_Service authService, IMapper mapper)
        {
            this.mapper = mapper;
            this.authService = authService;
            this.productService = prdService;
            
      
        }

        //bu method seçilen kategorinin ürünlerini getirir 
        [Authorize]
        [HttpGet("Get Product By {CategoryId}")]
        public BaseResponse<List<ProductDto>> GetById(long CategoryId)
        {
            
            var products=productService.GetAll().Response.Where(x=>x.CategoryId == CategoryId).ToList();
            return new BaseResponse<List<ProductDto>>(products);
        }

        //bu method authorize olan kullanıcının yeni ürün eklemesini sağlar
        [Authorize]
        [HttpPost("Add New Product")]
        public BaseResponse<ProductDto> Create([FromBody] ProductDto dto)
        {
            var auth_mail = authService.GetById(1);
            dto.ProductOwner = auth_mail.Response.Mail;
            var response = productService.Insert(dto);
           
            return response;
        }

        //bu method ürünü direkt satın alma işlemi için kullanılır
        [Authorize]
        [HttpPut("Buy Product {id}")]
        public BaseResponse<ProductDto> updateFoRsold(int id)
        {
            
            var dto = productService.GetById(id);

            //bu method authorize olmuş kullanıcının verisini tutar
            var auth_mail = authService.GetById(1);

            //kullanıcının kendi ürünü değil ise ve satılmamış ise
            if (dto.Response.IsSold !="yes" && dto.Response.ProductOwner != auth_mail.Response.Mail)
            {
                dto.Response.IsSold= "yes";
            }

            var response = productService.Update(id, dto.Response);
            return response;
        }

        //bu method ürünlere teklif vermek için kullanılır
        [Authorize]
        [HttpPut("Offer For Product {id}")]
        public BaseResponse<ProductDto> updateFoRoffer(int id,int offer)
        {

            var dto = productService.GetById(id);

            var auth_mail = authService.GetById(1);

            //kullanıcının kendi ürünü değil ise ve satılmamış ise veya başkasının teklifi onaylanmamış ise

            if (dto.Response.IsSold == "yes")
            {
                dto.Response.IsOfferable = "no";
            }

            else if (dto.Response.IsOfferable == "yes" && dto.Response.ProductOwner != auth_mail.Response.Mail)
            {
                dto.Response.Offer = offer;
                dto.Response.OfferOwner = auth_mail.Response.Mail;
                dto.Response.OfferStatus = "wait";
            }

            var response = productService.Update(id, dto.Response);
            return response;
        }

     

    }
}

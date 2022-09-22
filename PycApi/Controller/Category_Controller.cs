using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PycApi.Base;
using PycApi.Dto;
using PycApi.Service;
using System.Collections.Generic;

namespace PycApi.Controllers
{
    [ApiController]
    [Route("api/nhb/[controller]")]

    public class Category_Controller : ControllerBase
    {

        //servislerimizi eklediğimiz kısım
        private readonly ICategory_Service categoryService;
        private readonly IMapper mapper;


        public Category_Controller(ICategory_Service categoryService, IMapper mapper)
        {
            this.categoryService = categoryService;
            this.mapper = mapper;
        }


        //bu method tüm kategorilerimizi listeler
        [Authorize]
        [HttpGet("List All Category")]
        public BaseResponse<IEnumerable<CategoryDto>> GetAll()
        {
            var response = categoryService.GetAll();
            return response;
        }

        //bu method yeni bir kategori eklemeyi sağlar
        [Authorize]
        [HttpPost ("Add New Category")]
        public BaseResponse<CategoryDto> Create([FromBody] CategoryDto dto)
        {
            var response = categoryService.Insert(dto);
            return response;
        }

        //bu method kategorilerden herhangi birini düzenlememizi sağlar
        [Authorize]
        [HttpPut("Category Arrangement {id}")]
        public BaseResponse<CategoryDto> Update(int id, [FromBody] CategoryDto dto)
        {
            var response = categoryService.Update(id, dto);
            return response;
        }
    }
}

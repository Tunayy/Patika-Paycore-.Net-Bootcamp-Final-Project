using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PycApi.Base;
using PycApi.Dto;
using PycApi.Service;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using MimeKit;
using MimeKit.Text;
using MailKit.Net.Smtp;
using System.Linq;

namespace PycApi.Controllers
{
    [ApiController]
    [Route("api/nhb/[controller]")]

    public class Account_Controller : ControllerBase
    {
        //servislerimizi eklediğimiz kısım
        private readonly IAccount_Service accountService;
        private readonly IProduct_Service productService;
        private readonly ITokenService tokenService;
        private readonly IAuth_Service authService;
        private readonly IEmail_Service _emailService;
        private readonly IMapper mapper;

        public Account_Controller(IAccount_Service accountService, IProduct_Service productService, ITokenService tokenService, IAuth_Service authService, IEmail_Service emailService,IMapper mapper)
        {
            this.accountService = accountService;
            this.productService = productService;
            this.tokenService = tokenService;
            this.authService = authService;
            _emailService = emailService;
            this.mapper = mapper;
        }

        //bu şifreleme algoritması sign in ve sign up methodlarında passwordun md5 ile şifrelenmesini sağlar
        private static string Cryptograf(string text, HashAlgorithm alg)

        {

            byte[] byteDegeri = System.Text.Encoding.UTF8.GetBytes(text);

            byte[] sifreliByte = alg.ComputeHash(byteDegeri);

            return Convert.ToBase64String(sifreliByte);

        }

        public static string MD5Converter(string text)
        {
            MD5CryptoServiceProvider pwd = new MD5CryptoServiceProvider();
            return Cryptograf(text, pwd);
        }

       


        //database'e yeni kullanıcının kayıt olacağı method
        [HttpPost ("Sign Up")]
        public BaseResponse<AccountDto> Create([FromBody] AccountDto dto)
        {

            dto.Password=MD5Converter(dto.Password);
            var response = accountService.Insert(dto);

            //EmailDto email = new EmailDto();
            //email.To = dto.Email;
            //email.Subject = "Welcome";
            //email.Body = "Welcome Our Website";

            //var email = new MimeMessage();
            //email.From.Add(MailboxAddress.Parse("adolph.herzog@ethereal.email"));
            //email.To.Add(MailboxAddress.Parse(dto.Email));
            //email.Subject = "Welcome";
            //email.Body = new TextPart(TextFormat.Html) { Text = "Sitemize Hoş Geldiiniz" };
            //using var smtp = new SmtpClient();
            //smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
            //smtp.Authenticate("adolph.herzog@ethereal.email", "d5TaZyhTeg4kQgNbqu");
            //smtp.Send(email);
            //smtp.Disconnect(true);

            //_emailService.SendEmail(email);


            return response;
        }

        //kullanıcının giriş yaptığı method
        [HttpPost("Sign İn")]
        public BaseResponse<TokenResponse> Login([FromBody] TokenRequest request)
        {   

            //kullanıcının girdiği şifresi cryptolanır
            request.Password=MD5Converter(request.Password);

            //giriş yapan kullanıcının jwt tokeni üretilir
            var response = tokenService.GenerateToken(request);

            //giriş yapan kullanıcının mail bilgisi auth dbsine kaydedilir
            var auth_mail = authService.GetById(1);
            auth_mail.Response.Mail = response.Response.UserName;
            auth_mail = authService.Update(1, auth_mail.Response);
            return response;
        }


        //kullanıcının verdiği tüm teklifleri ve detaylarını listeleyen method
        [Authorize]
        [HttpGet("My Offers ")]
        public BaseResponse<List<ProductDto>> GetMyOffers(long id=1)
        {
            id = 1;

            //bu auth algoritması authorize olan kullanıcının usernamini tutar yani yani bu işlem sayesinde sadece authorize yapan kişinin tekliflerini görebiliriz bu bilgi token üretilirken oluşturulur
            var auth_mail = authService.GetById(id);
            var response = productService.GetAll().Response.Where(x => x.OfferOwner == auth_mail.Response.Mail).ToList(); 
            return new BaseResponse<List<ProductDto>>(response);
        }

        //bu method kullanıcının eklediği ürünleri listeler
        [Authorize]
        [HttpGet("My Product's Offers")]
        public BaseResponse<List<ProductDto>> GetMyProductsOffers(long id = 1)
        {
            id = 1;
            //bu auth algoritması authorize olan kullanıcının usernamini tutar yani yani bu işlem sayesinde sadece authorize yapan kişinin productlarını görebiliriz bu bilgi token üretilirken oluşturulur
            var auth_mail = authService.GetById(id);
            var response = productService.GetAll().Response.Where(x => x.ProductOwner == auth_mail.Response.Mail).ToList();
            return new BaseResponse<List<ProductDto>>(response);
        }

        //bu method kullanıcının ürünlerine gelen teklifi kabul etmesini sağlar
        [Authorize]
        [HttpPut("Offer Accept {id}")]
        public BaseResponse<ProductDto> updateAcceptoffer(int id)
        {

            var dto = productService.GetById(id);
            var auth_mail = authService.GetById(1);
            
            if (dto.Response.OfferStatus == "wait" && dto.Response.ProductOwner==auth_mail.Response.Mail)
            {
                dto.Response.IsOfferable = "no";
                dto.Response.IsSold = "yes";
                dto.Response.OfferStatus = "seller confirmed";
            }

            var response = productService.Update(id, dto.Response);
            return response;
        }

        //bu method kullanıcının ürünlerine gelen teklifi reddetmesini sağlar
        [Authorize]
        [HttpPut("Offer Decline {id}")]
        public BaseResponse<ProductDto> updateDeclineoffer(int id)
        {

            var dto = productService.GetById(id);
            var auth_mail = authService.GetById(1);

            if (dto.Response.OfferStatus == "wait" && dto.Response.ProductOwner == auth_mail.Response.Mail)
            {
                dto.Response.IsOfferable = "yes";
                dto.Response.IsSold = "no";
                dto.Response.OfferStatus = "seller did not confirm";
            }
            
            var response = productService.Update(id, dto.Response);
            return response;
        }


    }
}

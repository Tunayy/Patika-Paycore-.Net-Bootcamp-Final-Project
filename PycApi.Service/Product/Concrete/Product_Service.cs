using AutoMapper;
using NHibernate;
using PycApi.Base;
using PycApi.Data;
using PycApi.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace PycApi.Service
{
    public class Product_Service : BaseService<ProductDto, Product>, IProduct_Service
    {

        protected readonly ISession session;
        protected readonly IMapper mapper;
        protected readonly IHibernateRepository<Product> hibernateRepository;

       

        public Product_Service(ISession session, IMapper mapper) : base(session, mapper)
        {
            this.session = session;
            this.mapper = mapper;

            hibernateRepository = new HibernateRepository<Product>(session);
        }

        public override BaseResponse<IEnumerable<ProductDto>> GetAll()
        {
            return base.GetAll();
        }

        public override BaseResponse<ProductDto> GetById(long id)
        {
            return base.GetById(id);
        }

        public override BaseResponse<ProductDto> Insert(ProductDto insertResource)
        {
            return base.Insert(insertResource);
        }



    }
}
using AutoMapper;
using NHibernate;
using PycApi.Base;
using PycApi.Data;
using PycApi.Dto;
using System;
using System.Collections.Generic;
namespace PycApi.Service
{
    public class Category_Service : BaseService<CategoryDto, Category>, ICategory_Service
    {
        protected readonly ISession session;
        protected readonly IMapper mapper;
        protected readonly IHibernateRepository<Category> hibernateRepository;

        public Category_Service(ISession session, IMapper mapper) : base(session, mapper)
        {
            this.session = session;
            this.mapper = mapper;

            hibernateRepository = new HibernateRepository<Category>(session);
        }

        public override BaseResponse<IEnumerable<CategoryDto>> GetAll()
        {
            return base.GetAll();
        }

        public override BaseResponse<CategoryDto> GetById(long id)
        {
            return base.GetById(id);
        }

        public override BaseResponse<CategoryDto> Insert(CategoryDto insertResource)
        {
            return base.Insert(insertResource);
        }
    }
}

using AutoMapper;
using NHibernate;
using PycApi.Base;
using PycApi.Data;
using PycApi.Dto;
using System;
using System.Collections.Generic;
namespace PycApi.Service
{
    public class Auth_Service : BaseService<AuthDto, Auth>, IAuth_Service
    {
        protected readonly ISession session;
        protected readonly IMapper mapper;
        protected readonly IHibernateRepository<Auth> hibernateRepository;

        public Auth_Service(ISession session, IMapper mapper) : base(session, mapper)
        {
            this.session = session;
            this.mapper = mapper;

            hibernateRepository = new HibernateRepository<Auth>(session);
        }

        public override BaseResponse<IEnumerable<AuthDto>> GetAll()
        {
            return base.GetAll();
        }

        public override BaseResponse<AuthDto> GetById(long id)
        {
            return base.GetById(id);
        }

        public override BaseResponse<AuthDto> Insert(AuthDto insertResource)
        {
            return base.Insert(insertResource);
        }
    }
}

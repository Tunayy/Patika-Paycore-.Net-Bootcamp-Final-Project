using AutoMapper;
using NHibernate;
using PycApi.Base;
using PycApi.Data;
using PycApi.Dto;
using System;
using System.Collections.Generic;
namespace PycApi.Service
{
    public class Account_Service : BaseService<AccountDto, Account>, IAccount_Service
    {
        protected readonly ISession session;
        protected readonly IMapper mapper;
        protected readonly IHibernateRepository<Account> hibernateRepository;

        public Account_Service(ISession session, IMapper mapper) : base(session, mapper)
        {
            this.session = session;
            this.mapper = mapper;

            hibernateRepository = new HibernateRepository<Account>(session);
        }

        public override BaseResponse<IEnumerable<AccountDto>> GetAll()
        {
            return base.GetAll();
        }

        public override BaseResponse<AccountDto> GetById(long id)
        {
            return base.GetById(id);
        }

        public override BaseResponse<AccountDto> Insert(AccountDto insertResource)
        {
            return base.Insert(insertResource);
        }
    }
}

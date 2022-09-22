using PycApi.Dto;
using PycApi.Data;
using System.Collections.Generic;
using System;
using System.Linq;

namespace PycApi.Service
{
    public interface IEmail_Service
    {
        void SendEmail(EmailDto request);



    }
}

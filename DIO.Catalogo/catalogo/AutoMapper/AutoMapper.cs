using AutoMapper;
using catalogo.AutoMapper.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catalogo.AutoMapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            JogoMapperRequest.Map(this);
            JogoMapperResponse.Map(this);
        }
    }
}

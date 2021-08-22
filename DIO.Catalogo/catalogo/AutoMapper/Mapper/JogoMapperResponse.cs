using AutoMapper;
using catalogo.Entity;
using catalogo.InputModel;
using catalogo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catalogo.AutoMapper.Mapper
{
    public static class JogoMapperResponse
    {
        public static void Map(Profile profile)
        {
            if (profile != null)
                profile.CreateMap<JogoInputModel, Jogo>();
        }
    }
}

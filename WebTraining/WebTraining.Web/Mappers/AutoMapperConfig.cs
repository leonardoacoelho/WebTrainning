using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTraining.Web.Mappers.Profiles;

namespace WebTraining.Web.Mappers
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(
                cfg =>
                {
                    cfg.AddProfile<ProdutoProfile>();
                    cfg.AddProfile<GrupoProdutoProfile>();
                }
            );
        }
    }
}
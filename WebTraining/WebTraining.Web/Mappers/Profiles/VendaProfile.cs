using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTraining.Web.Models;

namespace WebTraining.Web.Mappers.Profiles
{
    public class VendaProfile : Profile
    {
        public VendaProfile()
        {
            CreateMap<Venda, VendaVM>();
            CreateMap<VendaVM, Venda>();
        }
    }
}
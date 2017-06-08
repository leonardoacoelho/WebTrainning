using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTraining.Web.Models;

namespace WebTraining.Web.Mappers.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<Cliente, ClienteVM>();
            CreateMap<ClienteVM, Cliente>();
        }
    }
}
﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTraining.Web.Models;

namespace WebTraining.Web.Mappers.Profiles
{
    public class ItemVendaProfile : Profile
    {
        public ItemVendaProfile()
        {
            CreateMap<ItemVendaProfile, ItemVendaVM>();
            CreateMap<ItemVendaVM, ItemVendaProfile>();
        }
    }
}
using AutoMapper;
using RelationDataBaseSystem.Model;
using RelationDataBaseSystem.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationDataBaseSystem.Infrastructure
{
  public  class MapInitializer:Profile
    {
        public Mapper? regMapper { get; set; }
        public MapInitializer()
        {
            CreateMap<productDto, Product>();
        }
    }
}

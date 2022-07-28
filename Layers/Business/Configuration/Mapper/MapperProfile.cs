using AutoMapper;
using DTO.Reader;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CreateReaderRequest, Reader>();
            CreateMap<UpdateReaderRequest, Reader>();
        }
    }
}

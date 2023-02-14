using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Child, ChildDTO>().ReverseMap();
            //CreateMap<Claim, ClaimDTO>()
            //    .ForMember(dest=>dest.Policy,opt=>opt.MapFrom(src=>src.Policy))
            //    .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role))
            //    .ForMember(dest => dest.Permission, opt => opt.MapFrom(src => src.Permission))
            //    .ReverseMap();
            //CreateMap<Lesson, LessonDTO>()
            //    .ForMember(dest => dest.Place, opt => opt.MapFrom(src => src.Place))
            //    .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
            //    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
            //    .ReverseMap();
            //CreateMap<TypeLesson, TypeLessonDTO>().ReverseMap();
            //CreateMap<Place, PlaceDTO>().ReverseMap();


        }
    }
}

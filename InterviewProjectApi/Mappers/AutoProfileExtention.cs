using AutoMapper;
using InterviewProjectApi.Dtos;
using InterviewProjectApi.Entities;

namespace InterviewProjectApi.Mappers
{
    public class AutoProfileExtention:Profile
    {
        public AutoProfileExtention()
        {
                CreateMap<BlogPost,BlogPostDto>().ReverseMap();
        }
    }
}

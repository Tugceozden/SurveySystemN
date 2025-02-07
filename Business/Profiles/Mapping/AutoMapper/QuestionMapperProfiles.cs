

using AutoMapper;
using Business.Dtos.Question;
using Business.Requests.Question;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper
{
	public class QuestionMapperProfiles:Profile
	{

        public QuestionMapperProfiles()
        {
            CreateMap<AddQuestionRequest, Question>();
            CreateMap<Question, AddQuestionResponse>();




            CreateMap<Question, QuestionListItemDto>();
			CreateMap<IList<Question>, GetQuestionListResponse>()
            .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));
            
            CreateMap<Question, DeleteQuestionResponse>();
            CreateMap<Question, GetQuestionByIdResponse>();
            CreateMap<UpdateQuestionRequest,Question>();
            CreateMap<Question,UpdateQuestionResponse>();


        }




    }
}



using AutoMapper;
using Business.Requests.Question;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper
{
	public class QuestionMapperProfiles:Profile
	{

        public QuestionMapperProfiles()
        {
            CreateMap<AddQuestionRequest, Question>();
            CreateMap<AddQuestionRequest, Question>();
            CreateMap<AddQuestionRequest, Question>();

        }




    }
}

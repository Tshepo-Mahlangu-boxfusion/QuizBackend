using AutoMapper;
using QuizT.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizT.Services.Dtos
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Quiz, QuizDto>().ReverseMap();
            CreateMap<Question, QuestionDto>()
            .ForMember(e => e.QuizId, m => m.MapFrom(e => e.Quiz.Id)).ReverseMap();
            CreateMap<Answer, AnswerDto>()
            .ForMember(e => e.QuestionId, m => m.MapFrom(e => e.Question.Id)).ReverseMap();
            CreateMap<UserQuiz, UserQuizDto>()
           .ForMember(e => e.QuizId, m => m.MapFrom(e => e.Quiz.Id))
           .ForMember(e => e.UserId, m => m.MapFrom(e => e.User.Id)).ReverseMap();
            CreateMap<UserQuiz, LeaderBoardDto>()
                .ForMember(e => e.Name, m => m.MapFrom(w => w.User.Name));

        }
    }
}

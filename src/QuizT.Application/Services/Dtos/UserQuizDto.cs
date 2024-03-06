using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using QuizT.Authorization.Users;
using QuizT.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizT.Services.Dtos
{
    [AutoMapFrom(typeof(UserQuiz))]
    public class UserQuizDto : EntityDto<Guid>
    {
        public int Score { get; set; }
        public Guid QuizId { get; set; }

        public long UserId { get; set; }
    }
}

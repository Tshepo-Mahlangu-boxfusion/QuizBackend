using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using QuizT.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizT.Services.Dtos
{
    [AutoMapFrom(typeof(Question))]
    public class QuestionDto: EntityDto<Guid>
    {
        public string Text { get; set; }

        public Guid QuizId { get; set; }
    }
}

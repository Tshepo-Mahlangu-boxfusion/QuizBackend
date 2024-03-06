using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using AutoMapper;
using QuizT.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizT.Services.Dtos
{
    [AutoMapFrom(typeof(Quiz))]
    public class QuizDto : EntityDto<Guid>
    {
        public string Name { get; set; }

        public int Category { get; set; }

        public string Src { get; set; }
    }
}

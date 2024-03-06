using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizT.Services.Dtos
{
    public class LeaderBoardDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
}

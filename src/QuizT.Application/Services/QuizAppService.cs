using Abp.Application.Services;
using Abp.Domain.Repositories;
using QuizT.Domain;
using QuizT.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizT.Services
{
    public class QuizAppService : AsyncCrudAppService<Quiz, QuizDto, Guid>
    {
        public QuizAppService(IRepository<Quiz, Guid> repository) : base(repository)
        {
        }

    }
}

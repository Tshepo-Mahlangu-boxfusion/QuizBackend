using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using QuizT.Domain;
using QuizT.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizT.Services
{
    public class AnswerAppService : AsyncCrudAppService<Answer, AnswerDto, Guid>
    {
        private readonly IRepository<Answer, Guid> _answerRepository;
        private readonly IRepository<Question, Guid> _questionnRepository;
        public AnswerAppService(IRepository<Answer, Guid> repository) : base(repository)
        {
        }

        public AnswerAppService(IRepository<Answer, Guid> answerRepository, IRepository<Question, Guid> questionnRepository) : base(answerRepository) 
        {
            _answerRepository = answerRepository;
            _questionnRepository = questionnRepository;
        }

        public override async Task<AnswerDto> CreateAsync(AnswerDto input)
        {
            var answer = ObjectMapper.Map<Answer>(input);
            answer.Question = _questionnRepository.Get(input.QuestionId);
            var result = await _answerRepository.InsertAsync(answer);
            return ObjectMapper.Map<AnswerDto>(result);
        }

        public async Task<List<AnswerDto>> GetAnswersAllIncluding(Guid questionId)
        {

            var answers = await _answerRepository.GetAll().Include(e => e.Question). Where(e=> e.Question.Id == questionId).ToListAsync();

            return ObjectMapper.Map<List<AnswerDto>>(answers);
        }




    }
}

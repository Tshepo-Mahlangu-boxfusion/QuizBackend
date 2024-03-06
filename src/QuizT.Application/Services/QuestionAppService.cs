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
    public class QuestionAppService : AsyncCrudAppService<Question, QuestionDto, Guid>
    {
        private readonly IRepository<Quiz,Guid> _quizRepisotory;
        private readonly IRepository<Question,Guid> _repository;

        public QuestionAppService(IRepository<Quiz, Guid> quizRepisotory, IRepository<Question, Guid> repository) : base(repository)
        {
            _quizRepisotory = quizRepisotory;
            _repository = repository;
        }

        

/*        public override async Task<QuestionDto> CreateAsync(QuestionDto input)
        {
            var question = ObjectMapper.Map<Question>(input);
            Console.WriteLine(input.QuizId);
            question.Quiz =  _quizRepisotory.Get(input.QuizId);
            var result = await _repository.InsertAsync(question);
            return ObjectMapper.Map<QuestionDto>(result);
        }*/
        public override async Task<QuestionDto> CreateAsync(QuestionDto input)
        
        {
            try
            {
                var question = ObjectMapper.Map<Question>(input);
                Console.WriteLine(input.QuizId);
                question.Quiz = _quizRepisotory.Get(input.QuizId);
                var result = await _repository.InsertAsync(question);
                return ObjectMapper.Map<QuestionDto>(result);
            }
            catch (Exception ex)
            {
                // Log the exception details for debugging
                Console.WriteLine(ex.Message);
                throw; // Rethrow the exception after logging
            }
        }

        public  async Task<List<QuestionDto>> GetAllIncluding(Guid quizId)
        {

            var questions = await _repository.GetAll().Include(e => e.Quiz).Where(e => e.Quiz.Id == quizId).ToListAsync();
            
           return ObjectMapper.Map<List<QuestionDto>>(questions);
        }
    }
}

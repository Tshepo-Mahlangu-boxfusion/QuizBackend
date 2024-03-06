using Abp.Application.Services;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using QuizT.Authorization.Users;
using QuizT.Domain;
using QuizT.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizT.Services
{
    public class UserQuizAppService : AsyncCrudAppService<UserQuiz, UserQuizDto, Guid>
    {
        private readonly IRepository<UserQuiz, Guid> _repository;
        private readonly IRepository<Quiz, Guid> _quizRepository;
        private readonly IRepository<User, long> _userRepository;
        

        public UserQuizAppService(IRepository<UserQuiz, Guid> repository,
            IRepository<Quiz,Guid> quizRepository,
            IRepository<User, long> userRepository
            ) : base(repository)
        {
            _userRepository = userRepository;
            _repository = repository;
            _quizRepository = quizRepository;
        }

        public override async Task<UserQuizDto> CreateAsync(UserQuizDto input)
        {
            var userQuiz = ObjectMapper.Map<UserQuiz>(input);
            userQuiz.Quiz = _quizRepository.Get(input.QuizId);
            userQuiz.User = _userRepository.Get(input.UserId);
            var result = await _repository.InsertAsync(userQuiz);
            return ObjectMapper.Map<UserQuizDto>(result);
        }

        public async Task<List<LeaderBoardDto>> GetTop5ForLeaderBoard(Guid quizId)
        {
            var userQuizzes = await _repository.GetAllIncluding(e => e.User).Where(e => e.Quiz.Id == quizId)
                .OrderByDescending(e => e.Score).ToListAsync();
            return ObjectMapper.Map<List<LeaderBoardDto>>(userQuizzes);
        }
    }
}

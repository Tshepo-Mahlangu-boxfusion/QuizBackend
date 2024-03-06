using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using QuizT.Authorization.Roles;
using QuizT.Authorization.Users;
using QuizT.MultiTenancy;
using QuizT.Domain;

namespace QuizT.EntityFrameworkCore
{
    public class QuizTDbContext : AbpZeroDbContext<Tenant, Role, User, QuizTDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public QuizTDbContext(DbContextOptions<QuizTDbContext> options)
            : base(options)
        {

        }

        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<UserQuiz> UserQuizzes { get; set; }
    }
}

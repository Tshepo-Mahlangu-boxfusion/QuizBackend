using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace QuizT.EntityFrameworkCore
{
    public static class QuizTDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<QuizTDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<QuizTDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

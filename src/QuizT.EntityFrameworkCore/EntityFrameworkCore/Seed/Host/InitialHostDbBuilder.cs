namespace QuizT.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly QuizTDbContext _context;

        public InitialHostDbBuilder(QuizTDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}

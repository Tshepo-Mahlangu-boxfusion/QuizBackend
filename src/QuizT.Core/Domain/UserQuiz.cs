using Abp.Authorization.Users;
using Abp.Domain.Entities.Auditing;
using QuizT.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizT.Domain
{
    public class UserQuiz: FullAuditedEntity<Guid>
    {
        public int Score { get; set; }
        public Quiz Quiz { get; set; }
        public User User { get; set; }
    }
}

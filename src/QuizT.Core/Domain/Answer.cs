using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizT.Domain
{
    public class Answer: FullAuditedEntity<Guid>
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }

        public Question Question { get; set; }

    }
}

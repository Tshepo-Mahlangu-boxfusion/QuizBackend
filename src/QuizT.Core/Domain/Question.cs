using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizT.Domain
{
 public class Question: FullAuditedEntity<Guid>
    {
        public string Text { get; set; }

        public Quiz Quiz { get; set; }
    }
}

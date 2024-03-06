using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizT.Domain
{
    public class Quiz: FullAuditedEntity<Guid>
    {
        public string Name { get; set; }

        public int Category { get; set; }

        public string Src { get; set; }


    }
}

using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.Entities
{
    public class JournalEntry
    {
        private int journalEntryId;
        private Question question;
        private string answer;
        private DateOnly date;

        public int JournalEntryId { get => journalEntryId; set => journalEntryId = value; }
        public Question Question { get => question; set => question = value; }
        public string Answer { get => answer; set => answer = value; }
        public DateOnly Date { get => date; set => date = value; }
    }
}

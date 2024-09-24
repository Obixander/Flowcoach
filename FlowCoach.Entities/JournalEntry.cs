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
        private Question Question;
        private string answer;
        private DateOnly date;

        public int JournalEntryId { get => journalEntryId; set => journalEntryId = value; }
        public Question Question1 { get => Question; set => Question = value; }
        public string Answer { get => answer; set => answer = value; }
        public DateOnly Date { get => date; set => date = value; }
    }
}

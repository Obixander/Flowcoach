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
        private DateOnly date;

        public int JournalEntryId
        {
            get => journalEntryId;
            set
            {
                if (value >= 0)
                {
                    if (value != journalEntryId)
                        journalEntryId = value;
                }
                else
                {
                    throw new Exception("Id must be a positive number");
                }
            }
        }
        public Question Question
        {
            get => question;
            set
            {
                if (value != null)
                {
                    if (value != question)
                        question = value;
                }
                else
                {
                    throw new Exception("Question must not be null");
                }
            }
        }
        public DateOnly Date
        {
            get => date;
            set
            {
                if (value != DateOnly.Parse("1.1.0001"))
                {
                    if (value != date)
                        date = value;
                }
                else
                {
                    throw new Exception("The date was not set");
                }
            }
        }
    }
}

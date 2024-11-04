using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.Entities
{
    public class Coaching
    {
        private int coachingId;
        private string title;
        private List<string> content;
        private List<Question> questions;
        private List<string> introText;

        public int CoachingId
        {
            get => coachingId;
            set
            {
                if (value >= 0)
                {
                    if (value != coachingId)
                        coachingId = value;
                }
                else
                {
                    throw new Exception("Id must be a positive number");
                }
            }
        }
        public string Title
        {
            get => title;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (value != title)
                        title = value;
                }
                else
                {
                    throw new Exception("Title must not be empty");
                }
            }
        }
        public List<Question> Questions
        {
            get => questions;
            set
            {
                if (value != null)
                {
                    if (value != questions)
                        questions = value;
                }
                else
                {
                    throw new Exception("The value must not be null");
                }
            }
        }
        public List<string> Content 
        { 
            get => content;
            set
            {
                if (value != null)
                {
                    if (value != content)
                        content = value;
                }
                else
                {
                    throw new Exception("The value must not be null");
                }
            }
        }
        public List<string> IntroText
        { 
            get => introText;
            set
            {
                if (value != null)
                {
                    if (value != introText)
                        introText = value;
                }
                else
                {
                    throw new Exception("The value must not be null");
                }
            }
        }

    }
}

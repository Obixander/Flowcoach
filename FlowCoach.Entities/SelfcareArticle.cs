using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.Entities
{
    public class SelfCareArticle
    {
        private int selfcareArticleId;
        private string title;
        private string content;
        private string soundfileUrl;
        private List<Question> questions;


        public int SelfcareArticleId 
        {
            get => selfcareArticleId;
            set 
            {
                if (value >= 0)
                {
                    if (value != selfcareArticleId)
                        selfcareArticleId = value;
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
                    throw new Exception("title cannot be empty");
                }
            }
        }
        public string Content 
        {
            get => content;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (value != content)
                        content = value;
                }
                else
                {
                    throw new Exception("content cannot be empty");
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
                    throw new Exception("The value was null");
                }
            }
        }
        public string SoundfileUrl
        {
            get => soundfileUrl;
            set 
            {

                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (value != soundfileUrl)
                        soundfileUrl = value;
                }
                else
                {
                    throw new Exception("content cannot be empty");
                }
            }
        }
    }
}

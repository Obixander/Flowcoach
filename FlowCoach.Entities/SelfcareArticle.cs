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


        public int SelfcareArticleId { get => selfcareArticleId; set => selfcareArticleId = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public List<Question> Questions { get => questions; set => questions = value; }
        public string SoundfileUrl { get => soundfileUrl; set => soundfileUrl = value; }
    }
}

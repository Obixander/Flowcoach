using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.Entities
{
    public class BodyFlowArticle
    {
        private int bodyFlowArticleId;
        private string title;
        private string content;
        private List<string>? images;

        public int BodyFlowArticleId { get => bodyFlowArticleId; set => bodyFlowArticleId = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public List<string>? Images { get => images; set => images = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.Entities
{
    public class BodyFlowCard
    {
        private int bodyFlowCardId;
        private string title;
        private string imageUrl;
        private int articleId; //this is the id used to find where to send the user after selecting a body flow

        public int BodyFlowCardId { get => bodyFlowCardId; set => bodyFlowCardId = value; }
        public string Title { get => title; set => title = value; }
        public string ImageUrl { get => imageUrl; set => imageUrl = value; }
        public int ArticleId { get => articleId; set => articleId = value; }
    }
}

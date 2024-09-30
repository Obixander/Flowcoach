using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.Entities
{
    public class BodyFlowCard : Card
    {
        private int bodyFlowArticleId; //this is the id used to find where to send the user after selecting a body flow
        private BodyFlowArticle bodyFlowArticle;
        public int BodyFlowArticleId { get => bodyFlowArticleId; set => bodyFlowArticleId = value; }
        public BodyFlowArticle BodyFlowArticle { get => bodyFlowArticle; set => bodyFlowArticle = value; }
    }
}

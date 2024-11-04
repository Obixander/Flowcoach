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
        public int BodyFlowArticleId 
        { 
            get => bodyFlowArticleId;
            set
            {
                if (value >= 0)
                {
                    if (value != bodyFlowArticleId)
                        bodyFlowArticleId = value;
                }
                else
                {
                    throw new Exception("Id must be a positive number");
                }
            }
        }
        public BodyFlowArticle BodyFlowArticle 
        { 
            get => bodyFlowArticle;
            set
            {
                if (value != null)
                {
                    if (value != bodyFlowArticle)
                        bodyFlowArticle = value;
                }
                else
                {
                    throw new Exception("The value must not be null");
                }
                     
            }
        }
    }
}

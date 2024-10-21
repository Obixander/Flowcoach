using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.Entities
{
    public class SelfCareCard : Card
    {
        private int selfCareArticleId; //this is the id used to find where to send the user after selecting a self care card
        private SelfCareArticle selfcareArticle;
        public int SelfCareArticleId { get => selfCareArticleId; set => selfCareArticleId = value; }
        public SelfCareArticle SelfcareArticle { get => selfcareArticle; set => selfcareArticle = value; }
    }
}

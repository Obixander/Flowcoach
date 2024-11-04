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
        public int SelfCareArticleId 
        {
            get => selfCareArticleId;
            set
            {
                if (value >= 0)
                {
                    if (value != selfCareArticleId)
                        selfCareArticleId = value;
                }
                else
                {
                    throw new Exception("Id must be a positive number");
                }
            }
        }
        public SelfCareArticle SelfcareArticle 
        {
            get => selfcareArticle;
            set 
            {
                if (value != null)
                {
                    if (value != selfcareArticle)
                        selfcareArticle = value;
                }
                else
                {
                    throw new Exception("Self care article must not be null");
                }
            }
        }
    }
}

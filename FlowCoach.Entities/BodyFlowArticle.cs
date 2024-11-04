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
        private List<string> content;
        private List<string>? images;

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
        public List<string>? Images 
        { 
            get => images; 
            set
            {
                if (value != null)
                {
                    if (value != images)
                        images = value;
                }
                else
                {
                    images = null;
                }
            }
        }
    }
}

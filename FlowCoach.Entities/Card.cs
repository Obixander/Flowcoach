using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.Entities
{
    public abstract class Card
    {
        private int cardId;
        private string title;
        private string imageUrl;

        public int CardId
        {
            get => cardId;
            set
            {
                if (value >= 0)
                {
                    if (value != cardId)
                        cardId = value;
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
        public string ImageUrl
        { 
            get => imageUrl;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (value != imageUrl)
                        imageUrl = value;
                }
                else
                {
                    throw new Exception("imageUrl must not be empty");
                }
            }
        }
    }
}

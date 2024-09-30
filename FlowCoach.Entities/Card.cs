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

        public int CardId { get => cardId; set => cardId = value; }
        public string Title { get => title; set => title = value; }
        public string ImageUrl { get => imageUrl; set => imageUrl = value; }
    }
}

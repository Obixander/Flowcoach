using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.Entities
{
    public class FlowCoachCard : Card
    {
        private string description;
        private string path; // routing path to page Like "/index"

        public string Description { get => description; set => description = value; }
        public string Path { get => path; set => path = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.Entities
{
    public class FlowCoachCard : Card
    {
        private string description;
        private string path; // routing path to page Like "/index"

        public string Description
        { 
            get => description;
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (value != description)
                        description = value;
                }
                else
                {
                    throw new Exception("Description cannot be empty");
                }
            
            }
        }
        public string Path
        { 
            get => path;
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (value.Contains('/'))
                    {
                        if (value != path)
                            path = value;
                    }
                    else
                    {
                        throw new Exception("A path must contain a /");
                    }
                }
                else
                {
                    throw new Exception("Path cannot be empty");
                }
            }
        }
    }
}

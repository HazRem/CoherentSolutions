using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    public abstract class TrainingContent : ICloneable
    {
        public string Description { get; set; }

        public TrainingContent(string description)
        {
            Description = description;
        }

        public abstract object Clone();
    }
}

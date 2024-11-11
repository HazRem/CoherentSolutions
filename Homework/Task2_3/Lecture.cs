using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    public class Lecture : TrainingContent
    {
        public string Topic { get; set; }

        public Lecture(string description, string topic) : base(description)
        {
            Topic = topic;
        }

        public override object Clone()
        {
            return new Lecture(Description, Topic);
        }
    }
}

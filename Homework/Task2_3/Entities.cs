using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    public abstract class TrainingContent
    {
        public string Description { get; set; }

        public TrainingContent(string description)
        {
            Description = description;
        }
    }

    public class Lecture : TrainingContent
    {
        public string Topic { get; set; }

        public Lecture(string description, string topic) : base(description)
        {
            Topic = topic;
        }
    }

    public class PracticalLesson : TrainingContent
    {
        public string TaskCondition { get; set; }
        public string SolutionLink { get; set; }

        public PracticalLesson(string description, string taskCondition, string solutionLink) : base(description)
        {
            TaskCondition = taskCondition;
            SolutionLink = solutionLink;
        }
    }
}

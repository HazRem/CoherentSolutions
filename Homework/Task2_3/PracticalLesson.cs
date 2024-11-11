using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    public class PracticalLesson : TrainingContent
    {
        public string TaskCondition { get; set; }
        public string SolutionLink { get; set; }

        public PracticalLesson(string description, string taskCondition, string solutionLink) : base(description)
        {
            TaskCondition = taskCondition;
            SolutionLink = solutionLink;
        }

        public override object Clone()
        {
            return new PracticalLesson(Description, TaskCondition, SolutionLink);
        }
    }
}

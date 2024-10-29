using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    public class Training : ICloneable
    {
        private List<TrainingContent> contents = new List<TrainingContent>();

        public void Add(TrainingContent content)
        {
            contents.Add(content);
        }

        public bool IsPractical()
        {
            foreach (var content in contents)
            {
                if (content is not PracticalLesson)
                    return false;
            }
            return contents.Count > 0;
        }

        public object Clone()
        {
            Training clonedTraining = new Training();
            foreach (var content in contents)
            {
                if (content is Lecture lecture)
                {
                    clonedTraining.Add(new Lecture(lecture.Description, lecture.Topic));
                }
                else if (content is PracticalLesson practical)
                {
                    clonedTraining.Add(new PracticalLesson(practical.Description, practical.TaskCondition, practical.SolutionLink));
                }
            }
            return clonedTraining;
        }

        public override string ToString()
        {
            var result = "Training Contents:\n";
            foreach (var content in contents)
            {
                if (content is Lecture lecture)
                {
                    result += $"Lecture - Topic: {lecture.Topic}, Description: {lecture.Description}\n";
                }
                else if (content is PracticalLesson practical)
                {
                    result += $"Practical Lesson - Task: {practical.TaskCondition}, Solution: {practical.SolutionLink}, Description: {practical.Description}\n";
                }
            }
            return result;
        }
    }
}

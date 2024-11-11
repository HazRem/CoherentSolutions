using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    public class Training : ICloneable
    {
        private TrainingContent[] contents;
    
        public Training(int capacity = 10)
        {
            contents = new TrainingContent[capacity];
        }

        public void Add(TrainingContent content)
        {
            int index = Array.IndexOf(contents, null);

            if (index == -1)
            {
                index = contents.Length;
                Array.Resize(ref contents, contents.Length * 2);
            }

            contents[index] = content;
        }
        public bool IsPractical()
        {
            foreach (var content in contents)
            {
                if (content is null) break;
                if (content is not PracticalLesson)
                    return false;
            }
            return Array.IndexOf(contents, null) > 0;
        }

        public object Clone()
        {
            Training clonedTraining = new Training();
            foreach (TrainingContent content in contents)
            {
                clonedTraining.Add((TrainingContent)content.Clone());
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

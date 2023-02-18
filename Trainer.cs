using System;

namespace Assignment3
{
    public class Instructor
    {
        private string instructorName;
        private float avgFeedback;
        private int experience;
        private string[] instructorSkill;

        public Instructor(string instructorName, float avgFeedback, int experience, string[] instructorSkill)
        {
            this.instructorName = instructorName;
            this.avgFeedback = avgFeedback;
            this.experience = experience;
            this.instructorSkill = instructorSkill;
        }

        public bool ValidateEligibility()
        {
            if (experience > 3 && avgFeedback >= 4.5)
            {
                return true;
            }
            else if (experience <= 3 && avgFeedback >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckSkill(string technology)
        {
            if (!ValidateEligibility())
            {
                return false;
            }

            foreach (string skill in instructorSkill)
            {
                if (skill.Equals(technology))
                {
                    return true;
                }
            }

            return false;
        }
    }
    internal class Trainer

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter instructor name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter instructor's average feedback (out of 5):");
            float feedback = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter instructor's experience (in years):");
            int experience = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter instructor's skills (comma-separated list):");
            string[] skills = Console.ReadLine().Split(',');

            Instructor instructor = new Instructor(name, feedback, experience, skills);

            Console.WriteLine("Is instructor eligible? " + instructor.ValidateEligibility());

            Console.WriteLine("Enter technology to check skill:");
            string technology = Console.ReadLine();

            Console.WriteLine("Instructor has skill? " + instructor.CheckSkill(technology));

        }
    }
}

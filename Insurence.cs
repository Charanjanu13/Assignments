using System;
using System.Linq;

namespace Assignment2
{
    public class Insurance
    {
        static int counter = 1000;
        public int InsuranceId { get; set; }
        public string ConsumerName { get; set; }
        public int Age { get; set; } = 0;
        public int CreditHistory { get; set; } = 0;
        public string[] Documents { get; set; }

        static Insurance()
        {
            counter = 1000;
        }

        public Insurance()
        {
            this.Age = 0;
            this.CreditHistory = 0;
        }

        public Insurance(string consumerName)
        {
            this.ConsumerName = consumerName;
        }

        public Insurance(string consumerName, string[] documents)
        {
            this.ConsumerName = consumerName;
            this.Documents = documents;
        }

        public Insurance(string consumerName, int age, int creditHistory, string[] documents)
        {
            this.ConsumerName = consumerName;
            this.Age = age;
            this.CreditHistory = creditHistory;
            this.Documents = documents;
        }

        public bool CheckEligibility()
        {
            if (this.Age < 18)
            {
                return false;
            }
            else if (this.Age > 18 && this.Age <= 30 && this.CreditHistory <= 60000)
            {
                return true;
            }
            else if (this.Age > 30 && this.CreditHistory <= 45000)
            {
                return true;
            }

            return false;
        }

        public bool CheckDocuments(string[] acceptableDocuments)
        {
            if (!CheckEligibility())
            {
                return false;
            }

            foreach (var document in this.Documents)
            {
                if (acceptableDocuments.Contains(document))
                {
                    this.InsuranceId = counter;
                    counter++;
                    return true;
                }
            }

            return false;
        }
    }

    internal class Insurence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter consumer name: ");
            string consumerName = Console.ReadLine();

            Console.WriteLine("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter credit history: ");
            int creditHistory = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter documents separated by commas: ");
            string[] documents = Console.ReadLine().Split(',');

            Insurance insurance = new Insurance(consumerName, age, creditHistory, documents);

            if (insurance.CheckDocuments(new string[] { "proof of income", "proof of address" }))
            {
                Console.WriteLine($"Congratulations! You are eligible for insurance with ID {insurance.InsuranceId}.");
            }
            else
            {
                Console.WriteLine("Sorry, you are not eligible for insurance.");
            }
        }
    }
}


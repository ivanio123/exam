using System;
using System.IO;
using System.Text;

namespace exam
{
    struct Work
    {
        public string surname;
        public string firstname;
        public string lastname;
        public string nameOfGroup;
        public int quantityA;
        public int quantityB;
        public int quantityC;
        public int salaryA;
        public int salaryB;
        public int salaryC;
        
        public Work(string data) 
        {
            string[] dataOfOneWorker = data.Split(' ');

            surname = dataOfOneWorker[0];
            firstname = dataOfOneWorker[1];
            lastname = dataOfOneWorker[2];
            nameOfGroup = dataOfOneWorker[3];
            quantityA = Convert.ToInt32(dataOfOneWorker[4]);
            quantityB = Convert.ToInt32(dataOfOneWorker[5]);
            quantityC = Convert.ToInt32(dataOfOneWorker[6]);
            salaryA = Convert.ToInt32(dataOfOneWorker[7]);
            salaryB = Convert.ToInt32(dataOfOneWorker[8]);
            salaryC = Convert.ToInt32(dataOfOneWorker[9]);
        }
    }
    class Program
    {
        static Work[] ReadInput(string inputPath)
        {
            string[] input = File.ReadAllLines(inputPath);
            Work[] workData = new Work[input.Length];
            for(int i = 0; i < input.Length; i++)
            {
                workData[i] = new Work(input[i]); 
            }
            return workData;
        }
        static void runMenu(Work[] workData, string workerSurname, string groupName) 
        {
            for (int i = 0; i < workData.Length; i++) 
            { 
                if (workerSurname == workData[i].surname)
                {
                    int totalQuantity = workData[i].quantityA + workData[i].quantityB + workData[i].quantityC;
                    Console.WriteLine("{0} {1}", workData[i].surname, totalQuantity);
                }
                if (groupName == workData[i].nameOfGroup)
                {
                    int totalSalary = workData[i].salaryA + workData[i].salaryB + workData[i].salaryC;
                    int averageSalary = totalSalary / 
                    Console.WriteLine("{0} {1}", workData[i].surname, totalSalary);
                }
            }
        }
        static void Main(string[] args)
        {
            string path = @"input.txt";
            Work[] workData = ReadInput(path);
            Console.WriteLine("Введіть прізвище працівника: ");
            string workerSurname = Console.ReadLine();
            Console.WriteLine("Введіть назву цеха: ");
            string groupName = Console.ReadLine();
            runMenu(workData, workerSurname, groupName);
            Console.ReadKey();
        }
    }
}

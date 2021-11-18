using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> toDoFromFile = new List<string>();
            string toDoFilePath = $@"C:\Users\opilane\samples\LOGITpe21\ToDoList.txt";
            toDoFromFile = File.ReadAllLines(toDoFilePath).ToList();

            foreach (string task in toDoFromFile)
            {
                Console.WriteLine(task);
            }

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add a task? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter a task:");
                    string userTask = Console.ReadLine();
                    toDoFromFile.Add(userTask);
                    Console.WriteLine($"Task {userTask} added.");
                }
                else
                {
                    Console.WriteLine("Take care!");
                    loopActive = false;
                }
            }

            File.WriteAllLines(toDoFilePath, toDoFromFile.ToArray());

        }
    }
}

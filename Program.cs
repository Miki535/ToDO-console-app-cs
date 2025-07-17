using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ToDoApp
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Make a choose:\n1) Add task\n2)Read task\n3)Delete task");
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        Console.WriteLine("Enter your task: ");
                        string taskInfo = Console.ReadLine();
                        Task[] tasks = { new Task(taskInfo) };
                        break;
                    case "2":

                        break;
                }
            }
            //Board schelude = new Board(tasks);
        }
    }

    class Board
    {
        public Task[] Tasks;
        public Board(Task[] tasks)
        {
            Tasks = tasks;
        }

        public void ShowAllTasks()
        {
            for (int i = 0; i < Tasks.Length; i++)
            {
                Tasks[i].ShowInfo();
            }
        }
    }

    class Task
    {
        public string Description;

        public Task(string description)
        {
            Description = description;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Task: {Description}");
        }
    }
}

/// ЗАВТРА РІШИТИ ТОБТО ВЖЕ СЬОГОДНІ РІШИТИ І ЗАВЕРШИТИ ПРОЕКТ!!!
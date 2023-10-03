using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

class Program
{
    class Task
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
    }

    static List<Task> tasks = new List<Task>();
    static object lockObj = new object();

    static void Main(string[] args)
    {
        Thread taskThread = new Thread(RunTasks);
        taskThread.Start();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Dodaj nowe zadanie");
            Console.WriteLine("2. Wyświetl aktualny status zadań");
            Console.WriteLine("3. Usuń zadanie");
            Console.WriteLine("4. Wyjdź");

            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddTask();
                    break;
                case 2:
                    DisplayStatus();
                    break;
                case 3:
                    RemoveTask();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.WriteLine("Podaj nazwę zadania:");
        string name = Console.ReadLine();
        Console.WriteLine("Podaj datę i godzinę zadania (yyyy-MM-dd HH:mm:ss):");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Task newTask = new Task { Name = name, Date = date, Status = "WAITING" };

        lock (lockObj)
        {
            tasks.Add(newTask);
        }

        Console.WriteLine("Zadanie dodane pomyślnie.");
    }

    static void DisplayStatus()
    {

    }

    static void RemoveTask()
    {
        
    }

    static void RunTasks()
    {
        while (true)
        {
            lock (lockObj)
            {
                foreach (var task in tasks)
                {
                    if (task.Status == "WAITING" && DateTime.Now >= task.Date)
                    {
                        task.Status = "RUNNING";
                        string scriptPath = "D:\\GitHub\\praktyki\\praktyki\\Wielowątkowość\\skrypt.ps1";
                        string taskName = task.Name;
                        string taskDate = task.Date.ToString();
                        Process.Start("powershell.exe", $"-File {scriptPath} \"{taskName}\" \"{taskDate}\"");
                    }
                }
            }

            // Czekaj chwilę przed sprawdzeniem zadań ponownie
            Thread.Sleep(1000);
        }
    }

}

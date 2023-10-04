using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Threading;
using System.Xml.Linq;

namespace ProgramDoTestu
{

    public class Program
    {
        public class Task
        {
            public string Name { get; set; }
            public DateTime Date { get; set; }
            public string Status { get; set; }
            public int ProcessID { get; set; }
        }

        static List<Task> tasks = new List<Task>();
        static object lockObj = new object();

        public static void Main(string[] args)
        {
            Thread taskThread = new Thread(RunTasks);
            Thread doneTasks = new Thread(DoneTasks);
            taskThread.Start();
            doneTasks.Start();

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Dodaj nowe zadanie");
                Console.WriteLine("2. Wyświetl aktualny status zadań");
                Console.WriteLine("3. Usuń zadanie");
                Console.WriteLine("4. Wyjdź");
                int choice;
                retry:
                try
                {
                choice = Int32.Parse(Console.ReadLine());
                } catch (Exception e)
                {
                    Console.WriteLine("Wpisz cyfre od 1 do 4 ");
                    goto retry;
                }

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

        public static void AddTask()
        {
            DateTime date;
            Console.WriteLine("Podaj nazwę zadania:");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj datę i godzinę zadania (yyyy-MM-dd HH:mm:ss):");
            try
            {
                date = DateTime.Parse(Console.ReadLine());
            } catch(Exception e)
            {
                Console.WriteLine("Wprowadzono złą datę");
                return;              
            }

            Task newTask = new Task { Name = name, Date = date, Status = "WAITING" };

            lock (lockObj)
            {
                tasks.Add(newTask);
            }

            Console.WriteLine("Zadanie dodane pomyślnie.");
        }

        public static void DisplayStatus()
        {
            lock (lockObj)
            {
                foreach (var task in tasks)
                {
                    Console.WriteLine($"Zadanie: {task.Name}, Data: {task.Date}, Status: {task.Status}");
                }
            }
        }

        public static void RemoveTask()
        {
            Console.WriteLine("Podaj nazwę zadania do usunięcia:");
            string taskName = Console.ReadLine();

            lock (lockObj)
            {
                Task taskToRemove = tasks.Find(t => t.Name == taskName);
                if (taskToRemove != null)
                {
                    tasks.Remove(taskToRemove);
                    Console.WriteLine("Zadanie usunięte pomyślnie.");
                }
                else
                {
                    Console.WriteLine("Zadanie nie zostało znalezione.");
                }
            }
        }
        public static void RunTasks()
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
                            Process process = new Process();
                            process.StartInfo.FileName = "powershell.exe";
                            process.StartInfo.Arguments = $"-File {scriptPath} \"{taskName}\" \"{taskDate}\"";
                            process.Start();
                            task.ProcessID = process.Id;
                            //Console.WriteLine(task.ProcessID)
                        }
                    }
                }

                Thread.Sleep(1000);
            }
        }
        static void DoneTasks()
        {
            while (true)
            {
                lock (lockObj)
                {
                    foreach(var task in tasks)
                    {
                        if(task.Status == "RUNNING")
                        {
                            if (Process.GetProcessById(task.ProcessID).HasExited)
                            {
                                task.Status = "DONE";
                            }
                        }
                    }
                }
            }
        }

    }

}
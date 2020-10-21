﻿using System;
using System.Collections.Generic;

namespace _21_Enums_and_Switch
{
    class Program
    {
        static void Main()
        {
            List<Todo> todos = new List<Todo>()
            {
                new Todo{Description = "Task 1", EstimatedHours=6, Status= Status.Completed},
                new Todo{Description = "Task 2", EstimatedHours=2, Status= Status.InProgress},
                new Todo{Description = "Task 3", EstimatedHours=8, Status= Status.NotStarted},
                new Todo{Description = "Task 4", EstimatedHours=12, Status= Status.Deleted},
                new Todo{Description = "Task 5", EstimatedHours=6, Status= Status.InProgress},
                new Todo{Description = "Task 6", EstimatedHours=2, Status= Status.NotStarted},
                new Todo{Description = "Task 7", EstimatedHours=14, Status= Status.OnHold},
                new Todo{Description = "Task 8", EstimatedHours=8, Status= Status.NotStarted},
                new Todo{Description = "Task 9", EstimatedHours=8, Status= Status.Deleted},
                new Todo{Description = "Task 10", EstimatedHours=8, Status= Status.InProgress},
                new Todo{Description = "Task 11", EstimatedHours=4, Status= Status.NotStarted},
                new Todo{Description = "Task 12", EstimatedHours=10, Status= Status.Completed},
                new Todo{Description = "Task 13", EstimatedHours=12, Status= Status.Completed},
            };

            PrintAssesement(todos);

            Console.ReadLine();
        }

        private static void PrintAssesement(List<Todo> todos)
        {
            foreach (var todo in todos)
            {
                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    default:
                        break;
                }
                Console.WriteLine(todo.Description);
            }
        }
    }

    public class Todo
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }
    }
    public enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Deleted
    }
}

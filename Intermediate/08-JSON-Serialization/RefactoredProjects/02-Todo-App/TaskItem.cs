using System;
using System.Runtime.CompilerServices;

namespace Todo_App
{
    public class TaskItem
    {
        private static int _IdGenerator;

        public string Title { get; private set; }
        public string Description { get; private set; }
        public TaskStatus Status { get; private set; }
        public string ID { get; }

        public TaskItem(string id, string title, string description)
        {
            if (string.IsNullOrWhiteSpace(id) || !id.All(char.IsDigit)) throw new ArgumentException("Invalid ID!");

            if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("Invalid title!");

            if (string.IsNullOrWhiteSpace(description)) throw new ArgumentException("Invalid description");

            ID = id;
            Title = title;
            Description = description;
            Status = TaskStatus.Pending;
        }

        // Method of marking the completion of a task
        public void MarkComplete()
        {
            Status = TaskStatus.Completed;
        }

        public override string ToString()
        {
            return $"ID: {ID}\nTitle: {Title}\nDescription: {Description}\nStatus: {Status}\n";
        }
    }
}
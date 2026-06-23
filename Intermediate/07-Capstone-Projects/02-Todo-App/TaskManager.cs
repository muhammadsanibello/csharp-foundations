using System;
using System.Collections.Generic;

namespace Todo_App
{
    public class TaskManager
    {
        private Dictionary<string, TaskItem> _listOfTasks = new();

        public void AddTask(TaskItem task)
        {
            if (task is null) throw new ArgumentNullException("Task object cannot be null");

            if (_listOfTasks.ContainsKey(task.ID)) throw new ArgumentException("Task already exist");

            _listOfTasks.Add(task.ID, task);
        }

        public bool DeleteTask(string id)
        {
            return _listOfTasks.Remove(id);
        }

        public TaskItem SearchTask(string id)
        {
            if (_listOfTasks.TryGetValue(id, out var taskItem))
            {
                return taskItem;
            }
            else
            {
                return null;
            }
        }

        public bool MarkTaskCompleted(string id)
        {
            if (_listOfTasks.TryGetValue(id, out var task))
            {
                task.MarkComplete();
                return true;
            }

            return false;

        }

        public void SaveToFile()
        {
            string filePath = UtilityClass.GetFilePath();

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var task in _listOfTasks.Values)
                {
                    writer.WriteLine($"{task.ID}|{task.Title}|{task.Description}");
                }
            }
        }

        public void LoadFile()
        {
            string filePath = UtilityClass.GetFilePath();

            if (!File.Exists(filePath))
            {
                throw new ArgumentException("File doesn`t exist");
            }

            // Clear the working collection
            _listOfTasks.Clear();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string? line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split("|");

                    var taskItem = new TaskItem(parts[0], parts[1], parts[2]);

                    _listOfTasks.Add(taskItem.ID, taskItem);
                }
            }
        }

        public IEnumerable<TaskItem> GetTaskItems()
        {
            return _listOfTasks.Values
                .OrderBy(x => x.Title);
        }

        public IEnumerable<TaskItem> GetPendingTaskItems()
        {
            return _listOfTasks.Values
                .Where(x => x.Status == TaskStatus.Pending)
                .OrderBy(x => x.Title);
        }

        public IEnumerable<TaskItem> GetCompletedTaskItems()
        {
            return _listOfTasks.Values
                .Where(x => x.Status == TaskStatus.Completed)
                .OrderBy(x => x.Title);
        }
    }
}
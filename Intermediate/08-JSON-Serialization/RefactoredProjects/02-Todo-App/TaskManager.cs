using System;
using System.Collections.Generic;
using System.Text.Json;

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

        public TaskItem? SearchTask(string id)
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

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(_listOfTasks.Values, options);
            File.WriteAllText(filePath, json);
        }

        public void LoadFile()
        {
            string filePath = UtilityClass.GetFilePath();

            if (!File.Exists(filePath))
            {
                throw new ArgumentException("File doesn`t exist");
            }

            string jsonString = File.ReadAllText(filePath);

            var tasks = JsonSerializer.Deserialize<List<TaskItem>>(jsonString) ?? throw new InvalidOperationException("Failed to deserialize task");

            // Clear the working collection
            _listOfTasks.Clear();

            foreach (var task in tasks)
            {
                _listOfTasks.Add(task.ID, task);
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
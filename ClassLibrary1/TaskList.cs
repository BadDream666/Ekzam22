using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class TaskList
    {
        private string name;
        private List<Task> tasks;

        /// <summary>
        /// создание новой переменной
        /// </summary>
        /// <param name="name"></param>
        public TaskList(string name)
        {
            this.name = name;
            tasks = new List<Task>();
        }

        /// <summary>
        /// возвращает имя списка задач
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// возвращает список всех задач
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasks()
        {
            return tasks;
        }

        /// <summary>
        /// удаляет задачу из списка задач
        /// </summary>
        /// <param name="task"></param>
        public void Remove(Task task)
        {
            tasks.Remove(task);
        }

        /// <summary>
        /// возвращает задачи запланированные на сегодня в хронологическом порядке
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByToday()
        {
            List<Task> tasksByToday = new List<Task>();
            foreach (var task in tasks)
            {
                if (task.Due == DateTime.Now)
                {
                    tasksByToday.Add(task);
                }
            }
            return tasksByToday;
        }

        /// <summary>
        /// возвращает задачи на завтра и позже в хронологическом порядке
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByFuture()
        {
            List<Task> tasksByToday = new List<Task>();

            foreach (var task in tasks)
            {
                if (task.Due == DateTime.Now)
                {
                    tasksByToday.Add(task);
                }
            }
            return tasksByToday;
        }
    }
}

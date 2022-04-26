using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary12
{
    public class Application
    {
        public Application application;
        public List<TaskList> taskLists;

        public Application()
        {
            taskLists = new List<TaskList>();
        }

        /// <summary>
        /// Метод получения экземпляра приложения
        /// </summary>
        
        public Application GetApplication()
        {
            if (application == null)
                return new Application();

            return application;
        }

        /// <summary>
        /// Создает список задач с указанным именем и добавляет его в taskLists.
        /// </summary>
        /// <param name="name"></param>
        public void CreateTaskList(string name)
        {
            taskLists.Add(new TaskList(name));
        }

        /// <summary>
        /// Возвращает список задач по имени списка.
        /// </summary>
        /// <returns></returns>
        public List<string> GetTaskListNames()
        {
            if (taskLists == null)
                return null;

            List<string> taskListNames = new List<string>();

            foreach (TaskList task in taskLists)
            {
                taskListNames.Add(task.Name);
            }

            return taskListNames;
        }
        /// <summary>
        /// Метод для получения списка задач на завтра и позднее
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByFuture()
        {
            List<Task> tasksByFuture = new List<Task>();

            foreach (TaskList taskList in taskLists)
            {
                tasksByFuture.AddRange(taskList.GetTasksByFuture());
            }

            return tasksByFuture;
        }
        /// <summary>
        /// Метод получения задач на сегодня
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByToday()
        {
            List<Task> tasksByToday = new List<Task>();

            foreach (TaskList taskList in taskLists)
            {
                tasksByToday.AddRange(taskList.GetTasksByToday());
            }

            return tasksByToday;
        }

    }

}

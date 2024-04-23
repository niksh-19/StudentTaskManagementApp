using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTaskManagementApp.Components.Pages
{
    public class TaskService : ITaskService
    {
        public void InsertTask(TaskItem task)
        {
            try
            {
                using (var connection = new MySqlConnection("Server=localhost;Database=taskmanager;Uid=root;Pwd=!()("))
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO tasks (task_name, deadline, time_commitment, complexity) VALUES (@TaskName, @Deadline, @TimeCommitment, @Complexity)";
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@TaskName", task.TaskName);
                        command.Parameters.AddWithValue("@Deadline", task.Deadline);
                        command.Parameters.AddWithValue("@TimeCommitment", task.TimeCommitment);
                        command.Parameters.AddWithValue("@Complexity", task.Complexity);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException("An error occurred while inserting the task into the database.", ex);
            }
        }
    }
}

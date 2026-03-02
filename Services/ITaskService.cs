using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public interface ITaskService
    {
        List<TaskItem> GetTasks(string status);
        List<Employee> GetEmployees();
        void AddTask(TaskItem task);
        void DeleteTask(int id);

        Task<int> GetTotalTasksAsync();
        Task<int> GetPendingTasksAsync();
        Task<int> GetCompletedTasksAsync();

        Task<int> GetTasksCountByShiftAsync(string shift);
    }
}

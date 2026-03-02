using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BlazorApp1.Services
{
    public class TaskService : ITaskService
    {
        private readonly AppDbContext _context;

        public TaskService(AppDbContext context)
        {
            _context = context;
        }

        public List<TaskItem> GetTasks(string status)
        {
            var query = _context.TaskItems
                                .Include(t => t.Employee)
                                .AsQueryable();

            if (!string.IsNullOrEmpty(status))
                query = query.Where(t => t.Status == status);

            return query.ToList();
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public void AddTask(TaskItem task)
        {
            _context.TaskItems.Add(task);
            _context.SaveChanges();
        }

        public void DeleteTask(int id)
        {
            var task = _context.TaskItems.Find(id);
            if (task != null)
            {
                _context.TaskItems.Remove(task);
                _context.SaveChanges();
            }
        }

        public async Task<int> GetTotalTasksAsync()
        {
            return await _context.Tasks.CountAsync();
        }

        public async Task<int> GetPendingTasksAsync()
        {
            return await _context.Tasks
                .Where(t => t.Status == "Pending")
                .CountAsync();
        }

        public async Task<int> GetCompletedTasksAsync()
        {
            return await _context.Tasks
                .Where(t => t.Status == "Completed")
                .CountAsync();
        }

        public async Task<int> GetTasksCountByShiftAsync(string shift)
        {
            return await _context.Tasks.Where(t => t.Employee.Shift == shift).CountAsync();
        }

    }
}

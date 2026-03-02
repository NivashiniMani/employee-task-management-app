using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace BlazorApp1.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees(string searchTerm, string shift);
        Task AddEmployee(Employee employee);
        Task DeleteEmployee(int id);

        Task<int> GetTotalEmployeesAsync();
        Employee GetEmployeeById(int id);
        Task UpdateEmployee(Employee employee);
    }
}

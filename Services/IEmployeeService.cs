using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees(String searchTerm, string shift);
        void AddEmployee(Employee employee);
        void DeleteEmployee(int id);
        Employee GetEmployeeById(int id);
        void UpdateEmployee(Employee employee);
    }
}

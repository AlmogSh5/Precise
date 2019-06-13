using _2bPrecise.Models;
using System.Threading.Tasks;

namespace _2bPrecise.Data
{
    public interface IEmployeeRepository
    {
        // General
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        // Employees
        Task<Employee[]> GetAllEmployeesAsync();
        Task<Employee> GetEmployeeAsync(int id);

        // Tasks
        Task<TaskItem[]> GetTaskItemsByEmployeeAsync(int employeeId);

        // Reports
        Task<ReportItem[]> GetReportItemsByManagerAsync(int managerId);
    }
}

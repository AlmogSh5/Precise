using _2bPrecise.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2bPrecise.Data
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly EmployeeContext _context;

        public EmployeeRepository(EmployeeContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            // Only return success if at least one row was changed
            return (await _context.SaveChangesAsync()) > 0;
        }

        // Employees
        public async Task<Employee[]> GetAllEmployeesAsync()
        {
            IQueryable<Employee> query = _context.EmployeesDb;
                //.Include(e => e.ManagerId);

            query = query.OrderByDescending(e => e.Id);

            return await query.ToArrayAsync();
        }
        
        public async Task<Employee> GetEmployeeAsync(int id)
        {
            IQueryable<Employee> query = _context.EmployeesDb;
                //.Include(e => e.ManagerId);

            query = query.Where(e => e.Id == id);

            return await query.FirstOrDefaultAsync();
        }

        // Tasks
        public async Task<TaskItem[]> GetTaskItemsByEmployeeAsync(int employeeId)
        {
            IQueryable<TaskItem> query = _context.TaskItemsDb;
                //.Include(t => t.EmployeeId)
                //.Include(t => t.ManagerId);

            query = query.Where(t => t.EmployeeId == employeeId);

            query = query.OrderByDescending(t => t.DueDate);

            return await query.ToArrayAsync();
        }

        // Reports
        public async Task<ReportItem[]> GetReportItemsByManagerAsync(int managerId)
        {
            IQueryable<ReportItem> query = _context.ReportItemsDb;
                //.Include(r => r.Employee)
                //.Include(r => r.Manager);

            query = query.Where(r => r.ManagerId == managerId);

            query = query.OrderByDescending(r => r.IssuedDate);

            return await query.ToArrayAsync();
        }
    }
}

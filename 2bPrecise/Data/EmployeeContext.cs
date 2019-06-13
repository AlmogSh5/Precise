using _2bPrecise.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2bPrecise.Data
{
    public class EmployeeContext : DbContext
    {
        private readonly IConfiguration _config;

        public DbSet<Employee> EmployeesDb { get; set; }
        public DbSet<ReportItem> ReportItemsDb { get; set; }
        public DbSet<TaskItem> TaskItemsDb { get; set; }
        public EmployeeContext(DbContextOptions options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DefaultConnectionString"));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            AddInitialData(builder);
        }

        private void AddInitialData(ModelBuilder builder)
        {
            int counter = 0;
            var doctor = new Employee() { Id = ++counter, FirstName = "The", LastName = "Doctor", ManagerId = 0, Position = PositionType.Manager, ImgUrl = "https://4.bp.blogspot.com/-tWGJ-aN1PxE/WNoH4DOOYNI/AAAAAAAAVcc/7B9s7OCcDRoSI5xugYKdz2sbxKFZQRCvQCPcB/s1600/Season%2B4%2Bpromo%2B5a.jpg" };
            var sherlock = new Employee() { Id = ++counter, FirstName = "Sherlock", LastName = "Holmes", ManagerId = doctor.Id, Position = PositionType.Manager, ImgUrl = "https://www.fjackets.com/product_images/a/723/Benedict_Cumberbatch_Sherlock_Coat__78001_zoom.jpg" };
            var john = new Employee() { Id = ++counter, FirstName = "John", LastName = "Oliver", ManagerId = doctor.Id, Position = PositionType.Manager, ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/John_Oliver_November_2016.jpg/220px-John_Oliver_November_2016.jpg" };
            var matt = new Employee() { Id = ++counter, FirstName = "Matt", LastName = "Damon", ManagerId = sherlock.Id, Position = PositionType.Employee, ImgUrl = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGX06TZQG/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg" };
            var chris = new Employee() { Id = ++counter, FirstName = "Chris", LastName = "Pratt", ManagerId = john.Id, Position = PositionType.Employee, ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSlLhjtiYwT4jd3tWyuFS6Rfp7u0rTKEw8s10VXNq7gXYkxkG_s" };
            var will = new Employee() { Id = ++counter, FirstName = "Will", LastName = "Smith", ManagerId = john.Id, Position = PositionType.Employee, ImgUrl = "http://cdn01.cdn.justjared.com/wp-content/uploads/headlines/2011/12/men-in-black-3.jpg" };
            var forrest = new Employee() { Id = ++counter, FirstName = "Forrest", LastName = "Gump", ManagerId = john.Id, Position = PositionType.Employee, ImgUrl = "https://ksassets.timeincuk.net/wp/uploads/sites/55/2019/03/forrest-920x584.png" };

            builder.Entity<Employee>().HasData(new
            {
                doctor.Id,
                doctor.FirstName,
                doctor.LastName,
                doctor.ManagerId,
                doctor.Position,
                doctor.ImgUrl
            }, new
            {
                sherlock.Id,
                sherlock.FirstName,
                sherlock.LastName,
                sherlock.ManagerId,
                sherlock.Position,
                sherlock.ImgUrl
            }, new
            {
                john.Id,
                john.FirstName,
                john.LastName,
                john.ManagerId,
                john.Position,
                john.ImgUrl
            }, new
            {
                matt.Id,
                matt.FirstName,
                matt.LastName,
                matt.ManagerId,
                matt.Position,
                matt.ImgUrl
            }, new
            {
                chris.Id,
                chris.FirstName,
                chris.LastName,
                chris.ManagerId,
                chris.Position,
                chris.ImgUrl
            }, new
            {
                will.Id,
                will.FirstName,
                will.LastName,
                will.ManagerId,
                will.Position,
                will.ImgUrl
            }, new
            {
                forrest.Id,
                forrest.FirstName,
                forrest.LastName,
                forrest.ManagerId,
                forrest.Position,
                forrest.ImgUrl
            });

            var today = new DateTime(DateTime.Now.Ticks);
            var report1 = new ReportItem(++counter, forrest.Id, john.Id, "Report 1 text", today.AddDays(-50));
            var report2 = new ReportItem(++counter, forrest.Id, john.Id, "Report 2 text", today.AddDays(-43));
            var report3 = new ReportItem(++counter, will.Id, john.Id, "Report 3 text", today.AddDays(-37));
            var report4 = new ReportItem(++counter, matt.Id, sherlock.Id, "Report 4 text", today.AddDays(-28));
            var report5 = new ReportItem(++counter, john.Id, doctor.Id, "Report 5 text", today.AddDays(-15));
            var report6 = new ReportItem(++counter, sherlock.Id, doctor.Id, "Report 6 text", today.AddDays(-11));

            builder.Entity<ReportItem>().HasData(
                new { report1.Id, report1.EmployeeId, report1.ManagerId, report1.ReportText, report1.IssuedDate },
                new { report2.Id, report2.EmployeeId, report2.ManagerId, report2.ReportText, report2.IssuedDate },
                new { report3.Id, report3.EmployeeId, report3.ManagerId, report3.ReportText, report3.IssuedDate },
                new { report4.Id, report4.EmployeeId, report4.ManagerId, report4.ReportText, report4.IssuedDate },
                new { report5.Id, report5.EmployeeId, report5.ManagerId, report5.ReportText, report5.IssuedDate },
                new { report6.Id, report6.EmployeeId, report6.ManagerId, report6.ReportText, report6.IssuedDate });

            var task1 = new TaskItem(++counter, forrest.Id, john.Id, "Task 1 text", today.AddDays(-20), today.AddDays(-15));
            var task2 = new TaskItem(++counter, john.Id, sherlock.Id, "Task 2 text, changed Manager", today.AddDays(-19), today.AddDays(-11));
            var task3 = new TaskItem(++counter, will.Id, john.Id, "Task 3 text", today.AddDays(-19), today.AddDays(-15));
            var task4 = new TaskItem(++counter, chris.Id, john.Id, "Task 4 text", today.AddDays(-17), today.AddDays(-12));
            var task5 = new TaskItem(++counter, matt.Id, sherlock.Id, "Task 5 text", today.AddDays(-14), today.AddDays(-8));
            var task6 = new TaskItem(++counter, matt.Id, sherlock.Id, "Task 6 text", today.AddDays(-7), today.AddDays(-3));
            var task7 = new TaskItem(++counter, sherlock.Id, doctor.Id, "Task 7 text", today.AddDays(-3), today.AddDays(5));
            var task8 = new TaskItem(++counter, john.Id, doctor.Id, "Task 8 text", today.AddDays(-2), today.AddDays(3));

            builder.Entity<TaskItem>().HasData(
                new { task1.Id, task1.EmployeeId, task1.ManagerId, task1.TaskText, task1.AssignedDate, task1.DueDate },
                new { task2.Id, task2.EmployeeId, task2.ManagerId, task2.TaskText, task2.AssignedDate, task2.DueDate },
                new { task3.Id, task3.EmployeeId, task3.ManagerId, task3.TaskText, task3.AssignedDate, task3.DueDate },
                new { task4.Id, task4.EmployeeId, task4.ManagerId, task4.TaskText, task4.AssignedDate, task4.DueDate },
                new { task5.Id, task5.EmployeeId, task5.ManagerId, task5.TaskText, task5.AssignedDate, task5.DueDate },
                new { task6.Id, task6.EmployeeId, task6.ManagerId, task6.TaskText, task6.AssignedDate, task6.DueDate },
                new { task7.Id, task7.EmployeeId, task7.ManagerId, task7.TaskText, task7.AssignedDate, task7.DueDate },
                new { task8.Id, task8.EmployeeId, task8.ManagerId, task8.TaskText, task8.AssignedDate, task8.DueDate });
        }
    }
}

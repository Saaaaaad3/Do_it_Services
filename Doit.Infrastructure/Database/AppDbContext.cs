using Doit.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doit.Infrastructure.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<BoardEntity> Boards { get; set; }
        public DbSet<TaskListEntity> TaskLists{ get; set; }
        public DbSet<TaskEntity> Tasks { get; set; }
        public DbSet<UserEntity> Users{ get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=DoitDB;Trusted_Connection=True;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Users
            modelBuilder.Entity<UserEntity>().HasData(
                new UserEntity { UserId = 1, Username = "JohnDoe", Password = "1234", FirstName = "John", LastName = "Doe", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new UserEntity { UserId = 2, Username = "JaneDoe", Password = "5678", FirstName = "Jane", LastName = "Doe", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now }
            );

            // Seed Boards
            modelBuilder.Entity<BoardEntity>().HasData(
                new BoardEntity { BoardId = 1, UserId = 1, BoardName = "Project Alpha", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new BoardEntity { BoardId = 2, UserId = 2, BoardName = "Project Beta", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now }
            );

            // Seed TaskLists
            modelBuilder.Entity<TaskListEntity>().HasData(
                new TaskListEntity { TaskListId = 1, BoardId = 1, TaskListName = "To Do", Order = 1, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new TaskListEntity { TaskListId = 2, BoardId = 1, TaskListName = "In Progress", Order = 2, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new TaskListEntity { TaskListId = 3, BoardId = 2, TaskListName = "Completed", Order = 1, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now }
            );

            // Seed Tasks
            modelBuilder.Entity<TaskEntity>().HasData(
                new TaskEntity { TaskId = 1, TaskListId = 1, Title = "Task 1", Description = "First Task", Image = "", Order = 1, Status = "Open", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new TaskEntity { TaskId = 2, TaskListId = 1, Title = "Task 2", Description = "Second Task", Image = "", Order = 2, Status = "Open", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now }
            );
        }
    }
}

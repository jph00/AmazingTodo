using System.Data.Entity;

namespace AmazingTodo.Models {
    public class AmazingTodoContext : DbContext {
        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<AmazingTodoContext, Migrations.Configuration>());
        }

        public AmazingTodoContext() : base("name=AmazingTodoContext")
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}

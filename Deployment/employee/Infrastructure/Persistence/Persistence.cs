using Domain;

namespace Infrastructure.Persistence
{
    public class Seed
    {
        public static async Task SeedData(EmployeeDbContext context)
        {
            await Seed.SeedEmployees(context);
            await context.SaveChangesAsync();
        }

        private static async Task SeedEmployees(EmployeeDbContext context)
        {
            if (context.Employee.Any()) return;
            var list = new List<Employee> {
                new Employee(Guid.NewGuid()) {
                     FirstName = "James",
                     LastName = "Contoso"
                },
                new Employee(Guid.NewGuid()) {
                     FirstName = "Michael",
                     LastName = "Bourke"
                },
                new Employee(Guid.NewGuid()) {
                     FirstName = "Roanoke",
                     LastName = "Tosse"
                },
                new Employee(Guid.NewGuid()) {
                     FirstName = "Zeke",
                     LastName = "Chan"
                },
            };

            await context.Employee.AddRangeAsync(list);
        }

    }
}
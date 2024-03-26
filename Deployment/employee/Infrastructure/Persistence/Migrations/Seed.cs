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
                new Employee(1) {
                     FirstName = "James",
                     LastName = "Contoso"
                },
                new Employee(2) {
                     FirstName = "Michael",
                     LastName = "Bourke"
                },
                new Employee(3) {
                     FirstName = "Roanoke",
                     LastName = "Tosse"
                },
                new Employee(4) {
                     FirstName = "Zeke",
                     LastName = "Chan"
                },
            };

            await context.Employee.AddRangeAsync(list);
        }

    }
}
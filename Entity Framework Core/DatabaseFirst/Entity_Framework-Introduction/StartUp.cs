using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoftUni.Data;
using SoftUni.Models;
using System.Text;

namespace SoftUni
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using SoftUniContext dbContext = new SoftUniContext();
            dbContext.Database.EnsureCreated();

            string result = DeleteProjectById(dbContext);
            Console.WriteLine(result);
        }
        //Problem 03
        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var employees = context.Employees
                .OrderBy(e => e.EmployeeId)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.MiddleName,
                    e.JobTitle,
                    e.Salary
                })
                .ToArray();

            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary.ToString("F2")}");
            }
            return sb.ToString().TrimEnd();
        }

        //Problem 4

        //Problem 5
        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var employeesRnD = context.Employees
                .Where(e => e.Department.Name.Equals("Research and Development"))
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    DepartmentName = e.Department.Name,
                    e.Salary
                })
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.FirstName)
                .ToArray();

            foreach (var e in employeesRnD)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} from Research and Development - ${e.Salary.ToString("f2")}");
            }
            return sb.ToString().TrimEnd();
        }
        //Problem 6
        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            const string newAddressText = "Vitoshka 15";
            const int newAddressTownId = 4;

            Address newAddress = new Address()
            { 
                AddressText = newAddressText,
                TownId = newAddressTownId
            };

            Employee nakovEmployee = context
                .Employees
                .First(e => e.LastName.Equals("Nakov"));
            nakovEmployee.Address = newAddress;

            context.SaveChanges();
            string?[] addresses = context.Employees
                .Where(e=> e.AddressId.HasValue)
                .OrderByDescending(e => e.AddressId)
                .Select(e => e.Address!.AddressText)
                .Take(10)
                .ToArray();

            return String.Join(Environment.NewLine, addresses);
        }

        //RESTORE DATABASE 
        private static void RestoreDatabase(SoftUniContext context)
        {
            //This will nod insert the data in the DB
            //This would work if we were working Code-First approach
            //This is not optimal for DB-First
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
        //Problem 7 
        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var employeesWithProjects = context.Employees
                .Select(e => new
                {
                    EmployeeFirstName = e.FirstName,
                    EmployeeLastName = e.LastName,
                    ManagerFirstName = e.Manager == null ? null : e.Manager.FirstName,
                    ManagerLastName = e.Manager == null ? null : e.Manager.LastName,
                    Projects = e.EmployeesProjects
                    .Select(ep => ep.Project)
                    .Where(p => p.StartDate.Year >= 2001 && p.StartDate.Year <= 2003)
                    .Select(p => new
                    {
                        ProjectName = p.Name,
                        p.StartDate,
                        p.EndDate
                    })
                    .ToArray()
                })
                .Take(10)
                .ToArray();

            foreach (var e in employeesWithProjects)
            {
                sb.AppendLine($"{e.EmployeeFirstName} {e.EmployeeLastName} - Manager: {e.ManagerFirstName} {e.ManagerLastName}");

                foreach (var p in e.Projects)
                {
                    string startDateFormatted = p.StartDate.ToString("M/d/yyyy h:mm:ss tt");
                    string endDateFormatted = p.EndDate.HasValue ? p.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt") : "not finished";

                    sb.AppendLine($"--{p.ProjectName} - {startDateFormatted} - {endDateFormatted}");
                }
            }
            return sb.ToString().TrimEnd();
        }

        //Problem 14

        public static string DeleteProjectById(SoftUniContext context)
        {
            const int deleteProjectId = 2;
            IEnumerable<EmployeeProject> employeeProjectsDelete = context.EmployeesProjects
                .Where(ep => ep.ProjectId == deleteProjectId)
                .ToArray();

            context.EmployeesProjects.RemoveRange(employeeProjectsDelete);

            Project? deleteProject = context.Projects.Find(deleteProjectId);

            if(deleteProject != null) 
            {
                context.Projects.Remove(deleteProject);
            }

            context.SaveChanges();

            string[] projectName = context
                .Projects
                .Select(p => p.Name)
                .Take(10)
                .ToArray();

            return String.Join(Environment.NewLine, projectName);
        }
    }
}

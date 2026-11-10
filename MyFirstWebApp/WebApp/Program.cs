using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Http;
using System.Diagnostics.Eventing.Reader;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Run(async (HttpContext context) =>
{
    if (context.Request.Method == "GET")
    {
        if (context.Request.Path.StartsWithSegments("/"))
        {

            await context.Response.WriteAsync($"The method is: {context.Request.Method}\r\n");
            await context.Response.WriteAsync($"The URL is: {context.Request.Path}\r\n");


            await context.Response.WriteAsync($"\r\nHeader:\r\n");
            foreach (var key in context.Request.Headers.Keys)
            {
                await context.Response.WriteAsync($"{key} : {context.Request.Headers[key]}\r\n");
            }
        }

        else if (context.Request.Path.StartsWithSegments("/employees"))
        {
            var employees = EmployeeRepository.GetEmployees();

            foreach (var employee in employees)
            {
                await context.Response.WriteAsync($"{employee.Name} : {employee.Position} : {employee.Salary}\r\n");
            }


            //await context.Response.WriteAsync("Employee List");
        }


    }
    else if (context.Request.Method == "POST")
    {
        if (context.Request.Path.StartsWithSegments("/employees"))
        {
            using var reader = new StreamReader(context.Request.Body);
            var body = await reader.ReadToEndAsync();
            var employee = JsonSerializer.Deserialize<Employee>(body);

            EmployeeRepository.AddEmployee(employee);

        }
    }


});



app.Run();

static class EmployeeRepository
{
    private static List<Employee> employees = new List<Employee>
    {
        new Employee(1,"John Doe","Engineer",60000),
        new Employee(2,"Jane Smith","Manager",75000),
        new Employee(3,"Sam Brown","Technician",50000),
    };

    public static List<Employee> GetEmployees() => employees;

    public static void AddEmployee(Employee? employee)
    {   
        if (employee is not null) {
            employees.Add(employee);
        }
        
    }
}
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public double Salary{ get; set; }

    public Employee(int id, string name, string position, double salary)
    {
        Id = id;
        Name = name;
        Position = position;
        Salary = salary;
    }

}
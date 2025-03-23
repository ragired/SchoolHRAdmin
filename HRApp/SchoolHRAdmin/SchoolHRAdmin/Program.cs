/*
 *  Program.cs
 *  
 *  School HR Records of employees
 *  
 */
using HRAdminAPI;


namespace SchoolHRAdmin;

class Program
{
    static void Main(string[] args)
    {
        decimal totalSalary = 0;
        List<IEmployee> employeeList = new List<IEmployee>();
        Console.WriteLine("Employee Salary Data");
        SeedData(employeeList);
        /* foreach(var employee in employeeList)
         {
             totalSalary += employee.Salary;
         }
         Console.WriteLine($"Total Salary incl Bonus {totalSalary}");*/

        Console.WriteLine($"Total Salary incl Bonus {employeeList.Sum(e => e.Salary)}");
    }

    public static void SeedData(List<IEmployee> employees)
    {
        IEmployee headOFDept = new HeadOfDept
        {
            Id = 3,
            FirstName = "Brenda",
            LastName = "Br",
            Salary = 30000
        };
        employees.Add(headOFDept);

        IEmployee headMaster = new HeadMaster
        {
            Id = 5,
            FirstName = "Max",
            LastName = "Mu",
            Salary = 25000
        };
        employees.Add(headMaster);

        IEmployee teacher = new Teacher
        {
            Id = 7,
            FirstName = "Paula",
            LastName = "Pr",
            Salary = 15000
        };
        employees.Add(teacher);

        IEmployee dHM = new DeputyHeadMaster
        {
            Id = 9,
            FirstName = "Simon",
            LastName = "Si",
            Salary = 18000
        };
        employees.Add(dHM);

    }
}


public class Teacher : EmployeeBase
{
    public override decimal Salary { get => base.Salary + base.Salary*0.03m; }

}
public class HeadMaster : EmployeeBase
{
    public override decimal Salary { get => base.Salary + base.Salary * 0.02m; }

}
public class DeputyHeadMaster : EmployeeBase
{
    public override decimal Salary { get => base.Salary + base.Salary * 0.05m; }

}
public class HeadOfDept : EmployeeBase
{
    public override decimal Salary { get => base.Salary + base.Salary * 0.015m; }

}

using Day04;

HiringDate date = new HiringDate();
Console.WriteLine(date);
Console.WriteLine(sizeof(Gender));
Employee emp = new Employee();
Console.WriteLine(emp);
Console.WriteLine("-----------------------------------");
Employee[] employees =
{
    new Employee(1,"Amr Mamdouh",(SecurityLevels)Enum.Parse(typeof(SecurityLevels),"DBA"),15000,new HiringDate(1,1,2005),(Gender)Enum.Parse(typeof(Gender),"Male")),
    new Employee(2,"Amr Mamdouh Nouh",(SecurityLevels)Enum.Parse(typeof(SecurityLevels),"Guest"),1000,new HiringDate(25,1,2003),(Gender)Enum.Parse(typeof(Gender),"Female")),
    new Employee(3,"Amr Nouh",(SecurityLevels)Enum.Parse(typeof(SecurityLevels),"Guest, Developer, Secretary, DBA"),20000,new HiringDate(1,1,2005),(Gender)Enum.Parse(typeof(Gender),"Male"))
};

foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    Console.WriteLine("-----------------------------------");

}

Array.Sort(employees);

Console.WriteLine("\nSort Employee By Hiring Date:\n");
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    Console.WriteLine("-----------------------------------");

}


Console.Clear();
Employee[] employeeArr = new Employee[3];
int id;
string name;
object? privilages;
double sal;
HiringDate hireDate;
object? gender;


for (int i = 0; i < employeeArr.Length; i++)
{
    do
    {
        Console.Clear();
        Console.WriteLine($"Please Enter Employee{i + 1} ID:");
    } while (!int.TryParse(Console.ReadLine(), out id));

    do
    {
        Console.Clear();
        Console.WriteLine($"Please Enter Employee{i + 1} ID:");
        name = Console.ReadLine() ?? String.Empty;
    } while (!String.IsNullOrWhiteSpace(name) || name.Length < 3);

    do
    {
        Console.Clear();
        Console.WriteLine($"Please Enter Employee{i + 1} Privilage:");
    } while (!Enum.TryParse(typeof(SecurityLevels), Console.ReadLine(), true, out privilages));

    do
    {
        Console.Clear();
        Console.WriteLine($"Please Enter Employee{i + 1} Salary:");
    } while (!double.TryParse(Console.ReadLine(), out sal));

    do
    {
        Console.Clear();
        Console.WriteLine($"Please Enter Employee{i + 1} Hiring Date:");
    } while (!HiringDate.TryParse(Console.ReadLine(), out hireDate));

    do
    {
        Console.Clear();
        Console.WriteLine($"Please Enter Employee{i + 1} Gender:");
    } while (!Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out gender));

    employeeArr[i] = new Employee(id,
                                  name,
                                  (SecurityLevels)privilages,
                                  sal,
                                  hireDate,
                                  (Gender)gender);
}

// Display All Employees
Console.WriteLine("\nDisplay All Employess\n");
foreach (Employee empl in employeeArr)
{
    Console.WriteLine(empl);
    Console.WriteLine("-----------------------------------");

}

// Sort Employee Base On Hiring Date
Array.Sort(employeeArr);

// Display All Employees Sorted Base On Hiring Date
Console.WriteLine("\nSorted Employee\n");
foreach (var sEmp in employeeArr)
{
    Console.WriteLine(sEmp);
    Console.WriteLine("-----------------------------------");
}



// Employee Search
Console.WriteLine("\nEmployee Seach\n");
int[] ids = { 123, 456, 789 };
EmployeeSearch search = new EmployeeSearch(ids, employeeArr);
Console.WriteLine(search[123]);
Console.WriteLine("-------------------------");
Console.WriteLine("\n---> Employee Before Update <---\n");
Console.WriteLine(search[456]);
Console.WriteLine("-------------------------");
search[456] = new Employee(3, "Mohamed", (SecurityLevels)Enum.Parse(typeof(SecurityLevels), "Guest, Developer"), 20000, new HiringDate(1, 1, 2005), (Gender)Enum.Parse(typeof(Gender), "Male"));
Console.WriteLine("-------------------------");
Console.WriteLine("\n---> Employee After Update <---\n");
Console.WriteLine(search[456]);

// Search By Hiring Date
EmployeeSearch emplo = new EmployeeSearch(employees);
Console.WriteLine("\nResult of Search By Hiring Date\n");
foreach (var item in emplo[new HiringDate(1, 1, 2005)])
{
    Console.WriteLine(item);
    Console.WriteLine("-----------------------------------");
}

// Search By Hiring Date
Console.WriteLine("\nResult of Search By Name\n");
foreach (var item in emplo["amr"])
{
    Console.WriteLine(item);
    Console.WriteLine("-----------------------------------");
}
Employee employee1 = new Employee(1,"Amr",50);
Club club1 = new Club();
SocialEnsurance socialEnsurance = new SocialEnsurance();

employee1.join += club1.AddMember;
employee1.join += socialEnsurance.AddMemberToEnsurance;
employee1.reachRetirement += club1.RemoveMember;

employee1.OnJoin();
Employee employee2 = new Employee(2, "Mohamed", 60);
employee2.reachRetirement += club1.RemoveMember;
employee2.Age = 60;
class Employee
{
    public int id { get; set; }
    public string name { get; set; }
    int age;
    public int Age { 
        get
        {
            return age;
        } 
        set {
            if (value >= 60)
            {
                reachRetirement(this,age);
                age = value;
            }
        } }

    public event Action<Employee> join;
    public event Action<Employee,int> reachRetirement;

    public Employee(int id = 0, string name=null, int age= 18)
    {
        if (age >= 60)
        {
            if(reachRetirement != null)
            reachRetirement(this, age);
        }
        this.id = id;
        this.name = name;
        this.age = age;
    }

    public void OnJoin()
    {
        if (join != null)
            join(this);
    }

}

class Club
{
    public void AddMember(Employee employee)
    {
        Console.WriteLine($"The Employee {employee.name} - his age is {employee.Age} added To Club");
    }

    public void RemoveMember(Employee employee,int age)
    {
        Console.WriteLine($"The Employee {employee.name} - his age is {employee.Age} removed from Club");
    }
}

class SocialEnsurance
{
    public void AddMemberToEnsurance(Employee employee)
    {
        Console.WriteLine($"Employee {employee.name} is added to Social Ensurance");
    }
}
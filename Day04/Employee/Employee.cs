struct Employee:IComparable
{
    public int id { get; set; }
    public string name { get; set; }
    public SecurityLevels privileges { get; set; }
    public double salary { get; set; }
    public HiringDate hiringDate { get; set; }
    public Gender gender { get; set; }

    public Employee()
    {
        id = 0;
        name = string.Empty;
        privileges = SecurityLevels.Guest;
        salary = 0;
        hiringDate = new HiringDate();
        gender = Gender.None;
    }

    public Employee(int id,string name, SecurityLevels securityLevel, double salary, HiringDate hiringDate, Gender gender)
    {
        this.id = id;
        this.name = name;
        privileges = securityLevel;
        this.salary = salary;
        this.hiringDate = hiringDate;
        this.gender = gender;
    }

    public override string ToString()
    {
        return $"Employee ID: {id},\nEmployee Name: {name},\nEmployee Privilages: {privileges},\nEmployee Salary: {salary:C},\nHiringDate: {hiringDate},\nGender: {gender}";
    }

    public int CompareTo(object? obj)
    {
        if (obj is Employee)
        {
            Employee employee = (Employee)obj; // unboxing
            return hiringDate.CompareTo(employee.hiringDate);
        }
        else
        {
            throw new Exception("Compare only Hiring Date Values");
        }
    }
}
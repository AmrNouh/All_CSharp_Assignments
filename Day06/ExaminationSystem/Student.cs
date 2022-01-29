namespace ExaminationSystem
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string department { get; set; }

        const int leftAlignment = -7;
        const int rightAlignment = 40;
        public Student(int id = 0,string name = "",string dept = "")
        {
            this.Id = id;
            this.Name = name;   
            this.department = dept;
        }

        public override string ToString()
        {
            return $"\nStudentName: {Name,leftAlignment}\t\t\t{"Department:",rightAlignment} {department}\n";
        }
    }
}
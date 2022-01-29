namespace ExaminationSystem
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string department { get; set; }
        public double grade { get; set; }

        const int leftAlignment = -7;
        const int rightAlignment = 40;
        public Student(int id = 0, string name = "", string dept = "")
        {
            this.Id = id;
            this.Name = name;
            this.department = dept;
        }

        public override string ToString()
        {
            if (grade == 0)
            {
                return $"\nStudentName: {Name,leftAlignment}\t\t\t{"Department:",rightAlignment} {department}\n";
            }
            else
            {
                return $"\nStudentName: {Name,leftAlignment}\t\t\t{"Department:",rightAlignment} {department}\n\n{"Your Grade",20}: {grade}";
            }
        }
    }
}
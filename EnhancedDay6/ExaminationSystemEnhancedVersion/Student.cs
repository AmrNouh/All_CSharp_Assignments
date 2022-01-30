namespace ExaminationSystemEnhancedVersion
{
    internal class Student
    {
        const int leftAlignment = -7;
        const int rightAlignment = 40;

        public static int Id = 1;
        public string Name { get; set; }
        public string department { get; set; }
        public List<int> examAnswers { get; }
        public int grade { get; set; }

        public Student( string name = "", string dept = "")
        {
            Id++ ;
            this.Name = name;
            this.department = dept;
            this.examAnswers = new List<int>();
        }

        public override string ToString()
        {
            if (grade == 0)
            {
                return $"\n  Name: {Name}\t\t\t{"Department:",rightAlignment} {department}\n";
            }
            else
            {
                return $"\n  Name: {Name}\t\t\t{"Department:",rightAlignment} {department}\n Your Grade: {grade}";
            }
        }

        public static void TakeStudentData(Student student)
        {
            do
            {
                Console.WriteLine("Please Enter Your Name:");
                student.Name = Console.ReadLine();
            } while (!string.IsNullOrWhiteSpace(student.Name) && student.Name.Length <= 2);
            do
            {
                Console.WriteLine("Please Enter Your Department:");
                student.department = Console.ReadLine();
            } while (!string.IsNullOrWhiteSpace(student.department) && student.department.Length <= 2);

            Console.Clear();
        }
    }
}
namespace ExaminationSystem
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string department { get; set; }
        public Student(int id = 0,string name = "",string dept = "")
        {
            this.Id = id;
            this.Name = name;   
            this.department = dept;
        }
    }
}
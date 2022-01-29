namespace ExaminationSystem
{
    public class Subject
    {
        public string subjectName { get; set; }
        public string profName { get; set; }
        public double fullMark { get; set; }
        public string departmentName { get; set; }
        public string organizationName { get; set; }

        const int leftAlignment = -7;
        const int rightAlignment = 40;
        public Subject()
        {
            this.subjectName = String.Empty;
            this.profName = String.Empty;
            this.departmentName = String.Empty;
            this.organizationName = String.Empty;
            this.fullMark = 0;

        }
        public Subject(string subjectName,string profName,double fullMark,string deptName,string orgName)
        {
            this.subjectName = subjectName;
            this.profName = profName;
            this.departmentName = deptName;
            this.organizationName = orgName;
        }

        public override string ToString()
        {
            return $"\nSubject Name: {subjectName,leftAlignment}\t\t\t{"Professor Name:",rightAlignment} {profName}\nFull Mark: {fullMark,leftAlignment}\t\t\t{"Department",rightAlignment} : {departmentName}\n{organizationName,leftAlignment}";
        }
    }
}
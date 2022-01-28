namespace ExaminationSystem
{
    public class Subject
    {
        public string subjectName { get; set; }
        public string profName { get; set; }
        public string departmentName { get; set; }
        public string organizationName { get; set; }

        public Subject()
        {
            this.subjectName = String.Empty;
            this.profName = String.Empty;
            this.departmentName = String.Empty;
            this.organizationName = String.Empty;
        }
        public Subject(string subjectName,string profName,string deptName,string orgName)
        {
            this.subjectName = subjectName;
            this.profName = profName;
            this.departmentName = deptName;
            this.organizationName = orgName;
        }

        public override string ToString()
        {
            return $"Subject Name: {subjectName}\nProfessor Name: {profName}\nDepartment : {departmentName}\n{organizationName}";
        }
    }
}
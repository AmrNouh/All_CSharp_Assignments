namespace ExaminationSystemEnhancedVersion
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
        public Subject(string subjectName, string profName, string deptName, string orgName)
        {
            this.subjectName = subjectName;
            this.profName = profName;
            this.departmentName = deptName;
            this.organizationName = orgName;
        }

        public override string ToString()
        {
            return $"\n  Subject Name: {subjectName}\n  Professor Name: {profName}\n  Department : {departmentName}\n  {organizationName}";
        }

        public static void TakeSubjectInfo(Subject subjectInfo)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Please Enter Subject Name:");
                subjectInfo.subjectName = Console.ReadLine();
            } while (!string.IsNullOrWhiteSpace(subjectInfo.subjectName) && subjectInfo.subjectName.Length <= 3);
            do
            {
                Console.Clear();
                Console.WriteLine("Please Enter Professor Name:");
                subjectInfo.profName = Console.ReadLine();
            } while (!string.IsNullOrWhiteSpace(subjectInfo.profName) && subjectInfo.profName.Length <= 2);

            do
            {
                Console.Clear();
                Console.WriteLine("Please Enter Department Name:");
                subjectInfo.departmentName = Console.ReadLine();
            } while (!string.IsNullOrWhiteSpace(subjectInfo.departmentName) && subjectInfo.departmentName.Length <= 3);
            do
            {
                Console.Clear();
                Console.WriteLine("Please Enter Organization Name:");
                subjectInfo.organizationName = Console.ReadLine();
            } while (!string.IsNullOrWhiteSpace(subjectInfo.organizationName) && subjectInfo.organizationName.Length <= 3);
        }
    }
}
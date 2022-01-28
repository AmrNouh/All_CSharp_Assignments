using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    internal class EmployeeSearch
    {
        int[]? nationalIDs;
        Employee[] employees;
        int index;

        public EmployeeSearch(int size)
        {
            nationalIDs = new int[size];
            employees = new Employee[size];
            index = 0;
        }

        public EmployeeSearch(Employee[] employees)
        {
            this.employees = employees;
            index = employees.Length;
            for (int i = employees.Length - 1; i >= 0; i--)
            {
                if (employees[i].Equals(new Employee()))
                {
                    index--;
                }
            }
        }

        public EmployeeSearch(int[] ids, Employee[] employees)
        {
            this.nationalIDs = ids;
            this.employees = employees;
            this.index = ids.Length;
        }

        //Es[id] => Employee
        // Es[id] = new Employee
        public Employee? this[int id]
        {
            get
            {
                if (nationalIDs != null)
                {
                    for (int i = 0; i < index; i++)
                    {
                        if (nationalIDs[i] == id)
                        {
                            return employees[i];
                        }
                    }
                }
                Console.WriteLine("Employee Not Exist");
                return null;
            }
            set
            {
                if (value != null && nationalIDs != null)
                {
                    for (int i = 0; i < index; i++)
                    {
                        if (nationalIDs[i] == id)
                        {
                            employees[i] = (Employee)value;
                            Console.WriteLine($"Value of Employee whose NID {id} is Updated!");
                        }
                    }
                }
            }
        }

        //Es[HiringDates] => Employee
        // Es[HiringDates] = new Employee
        public Employee[]? this[HiringDate hiringDate]
        {
            get
            {
                int j = 0;
                Employee[] emp = new Employee[index];
                for (int i = 0; i < index; i++)
                {
                    if (employees[i].hiringDate.CompareTo(hiringDate) == 0)
                    {
                        emp[j] = employees[i];
                        j++;
                    }
                }
                return emp.Length > 0 ? emp : null;
            }

        }

        //Es[name] => Employee
        // Es[name] = new Employee
        public Employee[]? this[string name]
        {
            get
            {
                int j = 0;
                Employee[] emp = new Employee[index];
                for (int i = 0; i < index; i++)
                {
                    if (employees[i].name.Contains(name,StringComparison.CurrentCultureIgnoreCase))
                    {
                        emp[j] = employees[i];
                        j++;
                    }
                }
                return emp.Length > 0 ? emp : null;
            }

        }
    }
}

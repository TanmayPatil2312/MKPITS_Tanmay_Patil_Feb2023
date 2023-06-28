namespace mvc_exm2.Models
{
    public class EmpClass
    {
        public string name, designation;
        public int empid, salary;


        //constructor
        public EmpClass(string a, string b, int c, int d)
        {
            name = a;
            designation = b;
            empid = c;
            salary = d;
        }
        // creating property named Name and Age
        public string Name
        {
            get { return name; }

        }
        public string Designation
        {
            get { return designation; }
        }
        public int Empid
        {   
            get { return empid; }
        }
        public int Salary
        {
            get { return salary; }
        }

    }
}

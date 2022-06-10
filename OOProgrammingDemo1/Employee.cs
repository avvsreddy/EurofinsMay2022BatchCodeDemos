namespace OOProgrammingDemo1
{
    class Employee
    {
        
        private int salary;
        public string FirstName // Automatic Properties
        {
            get;
            set;
        }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int EmpID { get; set; }
        public int Salary
        {
            get { return salary; }
            set 
            {
                if (value < 10000)
                    salary = 10000;
                else
                    salary = value;
            }
        }

        //public Employee()
        //{
        //    EmpID = 100;
        //    Salary = 10000;
        //}
        //public Employee(int id, string fname, string mname, string lname, int sal ):this(id,fname,mname,lname)
        //{
        //    //EmpID = id;
        //    //FirstName = fname;
        //    //MiddleName = mname;
        //    //LastName = lname;
        //    Salary = sal;
        //}
        //public Employee(int id)
        //{
        //    EmpID = id;
        //}
        //public Employee(int id, string fname):this(id)
        //{
        //    //EmpID = id;
        //    FirstName = fname;
        //}
        //public Employee(int id, string fname, int sal):this(id,fname)
        //{
        //    //EmpID = id;
        //    //FirstName = fname;
        //    Salary = sal;
        //}
        //public Employee(int id, string fname, string mname, string lname):this(id,fname)
        //{
        //    //EmpID = id;
        //    //FirstName = fname;
        //    MiddleName = mname;
        //    LastName = lname;
        //}
    }
}

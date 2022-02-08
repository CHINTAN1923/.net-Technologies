using System;
namespace EMPinfo
{
    public class Employee
    {
        string firstName;
        string lastname;
        double monthlysalary;
        public Employee(string fname, string lname, double msalary)
        {
            firstName = fname;
            lastname = lname;
            monthlysalary = msalary;
        }
        public string fname
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string lname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public double msalary
        {
            get { return monthlysalary; }
            set
            {
                monthlysalary = value < 0 ? 0.0 : value;
            }
        }
        public virtual void RaiseSalary(double raise)
        {
            monthlysalary = monthlysalary + (monthlysalary * raise / 100);
        }
        public override string ToString()
        {
            return $"First Name: {firstName} \n Last Name: {lastname}\n msalary: {monthlysalary * 12}";
        }

    }
    public class PermanentEmployee : Employee
    {
        double housingRentAllowance;
        double dearnessAllowance;
        double providentFund;
        string _joiningDate;
        string _retirementDate;

        public PermanentEmployee(string fname, string lname, string
       joiningDate, string retirementDate, double msalary, double
       HRA, double DA, double
       PF) : base(fname, lname, msalary)
        {
            this.housingRentAllowance = HRA;
            this.dearnessAllowance = DA;
            this.providentFund = PF;
            this._joiningDate = joiningDate;
            this._retirementDate = retirementDate;
            this.msalary = this.msalary + housingRentAllowance +
           dearnessAllowance;
        }
        public double HRA
        {
            get => housingRentAllowance;
        }
        public double DA
        {
            get => dearnessAllowance;
        }
        public double PF
        {
            get => providentFund;
        }

        public string JoiningDate
        {
            get => _joiningDate;
            set => _joiningDate = value;
        }
        public string RetirementDate
        {
            get => _retirementDate;
            set => _retirementDate = value;
        }

        public override void RaiseSalary(double raise)
        {
            this.msalary = this.msalary + (this.msalary * raise) / 100
           + dearnessAllowance + housingRentAllowance;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nJoining date: {_joiningDate}\nRetirementdate: { _retirementDate}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
     public interface IEmpContract
    {
        int WorkHoursClause();
        string SickLeaveClase();
    }

    public class KpmgEmployee : IEmpContract
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string designation { get; set; }
        public string SickLeaveClase()
        {
            // throw new NotImplementedException();
            return "Employee is allowed to take at the most 5 sick per month";
        }

        public int WorkHoursClause()
        {
            return 8;
            //throw new NotImplementedException();
        }
    }

    public class DellEmployee : IEmpContract
     {
        public string SickLeaveClase()
        {
            // throw new NotImplementedException();
            return "Employee is allowed to take at the most 9 sick per month";
        }

        public int WorkHoursClause()
        {
            return 9;
            //throw new NotImplementedException();
        }

    }

    public class MyClass: ParentClass, IContract1, IContract2
    {
        /*
         Myclass can inherit only from 1 other class. It cannot inherit from
        multiple classes
        but, It can implement multiple interfaces
        It can also inherit from 1 class and implement multiple interfaces.
         */
    }

    internal interface IContract2
    {
    }

    internal interface IContract1
    {
    }

    public class ParentClass
    {
    }
}

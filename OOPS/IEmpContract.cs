using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public interface IEmpContract
    {
        int WorksHoursClause();
        string SickLeavesClause();

    }
    public class KpmgEmployee : IEmpContract
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string designation { get; set; }
        public string SickLeavesClause()
        {
            return "Employee is allowed to take 5 sick leaves per month";
        }

        public int WorksHoursClause()
        {
            return 8;
        }
    }
    public class DellEmployee : IEmpContract
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string designation { get; set; }
        public string SickLeavesClause()
        {
            return "Employee can take upto 20 sick leaves";
        }

        public int WorksHoursClause()
        {
            return 6;
        }
    }

}

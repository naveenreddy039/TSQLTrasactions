using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSQL_Trasactions.Model.SalaryModel
{
    public class SalaryDetailModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string JobDeacription { get; set; }

        public string Month { get; set; }

        public int EmployeeSalary { get; set; }

        public int SalaryId { get; set; }
    }
}

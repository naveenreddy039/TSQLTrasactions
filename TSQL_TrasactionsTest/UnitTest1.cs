using Microsoft.VisualStudio.TestTools.UnitTesting;
using TSQL_Trasactions;
using TSQL_Trasactions.Model.SalaryModel;

namespace TSQL_TrasactionsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSalaryDetails_AbleToUpdateSalaryDetails()
        {
            Salary salary = new Salary();
            SalaryUpdateModel updateModel = new SalaryUpdateModel()
            {
                SalaryId = 2,
                Month = "Jan",
                EmployeeSalary = 1200,
                EmployeeId = 5
            };
            int EmpSalary = salary.UpdateEmployeeSalary(updateModel);
            Assert.AreEqual(updateModel.EmployeeSalary, EmpSalary);
        }

    }
}
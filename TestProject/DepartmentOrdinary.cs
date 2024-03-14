using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUITestProject
{
    /// <summary>
    /// Департамент по работе с обычными пользователями
    /// </summary>
    public class DepartmentOrdinary : AbstractBank
    {
        protected override int DepositProcent { get; set; }
        protected override int CreditProcent { get; set; }
        public DepartmentOrdinary()
        {
            DepositProcent = 12;
            CreditProcent = 18;
        }
        public override string ToString()
        {
            return $"{this.DepositProcent},{this.CreditProcent}";
        }
    }
}

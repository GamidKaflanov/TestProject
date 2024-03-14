using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUITestProject
{
    /// <summary>
    /// Департамент для работы с Вип пользователями
    /// </summary>
    public class DepartmentVip : AbstractBank
    {
        protected override int DepositProcent { get; set; }
        protected override int CreditProcent { get; set; }
        public DepartmentVip()
        {
            DepositProcent = 14;
            CreditProcent = 16;
        }
        public override string ToString()
        {
            return $"{this.DepositProcent},{this.CreditProcent}";
        }
    }
}

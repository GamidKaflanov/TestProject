using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUITestProject
{
    /// <summary>
    /// Департамент по работе с ЮР лицами
    /// </summary>
    public class DepartmentLegalPersonality : AbstractBank
    {
        protected override int DepositProcent { get ; set ; }
        protected override int CreditProcent { get ; set ; }
        public DepartmentLegalPersonality()  
        { 
            DepositProcent = 10;
            CreditProcent = 20;
        }
        public override string ToString()
        {
            return $"{this.DepositProcent},{this.CreditProcent}";
        }
    }
}

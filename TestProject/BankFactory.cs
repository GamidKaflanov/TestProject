using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUITestProject
{
    /// <summary>
    /// Фабрика депортаментов банка
    /// </summary>
    public class BankFactory
    {
        public static IBankOperations GetDepartment(User user) 
        {
            IBankOperations bank;
            var values = new[] { "OOO", "OAO" };
            if (values.Any(user.Name.Contains))
                bank = new DepartmentLegalPersonality();
            else if (user.DepositSum > 200000)
                bank = new DepartmentVip();
            else 
                bank = new DepartmentOrdinary();
            return bank;
        }
    }
}
// Понимаю, что расширяемость, при выборке таким образом, никакая.
// Не хотел ещё больше усложнять проект

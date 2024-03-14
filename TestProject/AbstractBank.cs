using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUITestProject
{
    public abstract class AbstractBank : IBankOperations
    {
        protected abstract int DepositProcent { get; set; }
        protected abstract int CreditProcent { get; set; }
        public void Deposit(User user, int sum)
        {
            user.DepositSum+=sum+ (sum / 100) * DepositProcent;
        }

        public void GetCredit(User user, int sum)
        {
            user.Cash+=sum;
            user.Debt += sum + (sum / 100) * CreditProcent;
        }

        public void Transaction(User user1, User user2, int sum)
        {
            user2.Cash+=sum;
            user1.Cash-=sum;
        }
    }
}

// Можно было обойтись без абстрактного класса,
// так как, если в дальнейшем потребуется добавить другой департамент,
// с иной реализацией методов интерфейса - придётся изменить абстрактный класс.
// Но я решил пожертвовал практичностью в угоду красоты
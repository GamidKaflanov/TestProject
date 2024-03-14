using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUITestProject
{
    /// <summary>
    /// Интерфейс для внедрения зависимостей
    /// </summary>
    public interface IBankOperations
    {
        void GetCredit(User user, int sum);
        void Transaction(User user1, User user2,int sum);
        void Deposit(User user,int sum);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUITestProject
{
    /// <summary>
    /// Нулейвой пользователь
    /// </summary>
    public class NullUser : User
    {
        public NullUser()
        {
            this.Name = "Гость " + UserID;
            Cash = 1000;
            Debt = 0; DepositSum = 0;
        }
    }
}

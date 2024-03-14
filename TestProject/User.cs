using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUITestProject
{
    /// <summary>
    /// Пользователи банка
    /// </summary>
    public class User
    {
        static Random random = new Random();
        public int UserID { get; set; }
        public string Name { get; set; }
        public int Cash { get ; set ; }
        public int Debt { get; set; }
        public int DepositSum { get; set; }
        public User() { }
        public User(string Name)
        {
            this.Name = Name;
            Cash = random.Next(100000, 10000000);
            Debt = 0; DepositSum = 0;
        }
        public override string ToString() => 
            $"Имя: {Name} Счёт: {Cash} Долг: {Debt} Вклады: {DepositSum}";
    }
}
//Понимаю, можно было написать такую же структуру как и с департаментами банка (добавив интерфейс),
//но опять же - не хотел ещё сильнее усложнять программу

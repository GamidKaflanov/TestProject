using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUITestProject
{
    /// <summary>
    /// Фабрика пользователей
    /// </summary>
    public class UserFactory
    {
        static Random r;
        static UserFactory() { r = new Random(); }
        public static List<User> CreateRandomUsers(int count)
        {
            List<User> users = new List<User>();

            for(int i = 0; i < count; i++)
            {
                switch(r.Next(5))
                {
                    case 0: users.Add(new User("Гамид")); break;
                    case 1: users.Add(new User("Илья")); break;
                    case 2: users.Add(new User("Давид")); break;
                    case 3: users.Add(new User("Алексей")); break;
                    case 4: users.Add(new User("Магомед")); break;
                    case 5: users.Add(new User("Анастасия")); break;
                    default: users.Add(new NullUser()); break;
                }
            }
            return new List<User>(users);
        }
        public static User CreateUser(string Name)
        {
            return new User(Name);
        }
    }
}
// Можно было написать интерфейс внедрения зависимостей для пользователей и через него работать,
// но так же как и с фабрикой депортаментов - не хотел усложнять проект

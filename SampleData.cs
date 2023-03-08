using System.Linq;
using System.Numerics;
using LABA333.Models;

namespace LABA333
{
    public static class SampleData
    {
        public static void Initialize(ShopContext context)
        {
            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee
                    {
                        full_name = "Абрамов Валерий Викторович",
                        email = "abramov3232@mail.ru",
                        identifier = 1,
                        id_post = 1
                    },
                    new Employee
                    {
                        full_name = "Симонов Валерий Генадиевич",
                        email = "simonov2323@mail.ru",
                        identifier = 2,
                        id_post = 2
                    },
                    new Employee
                    {
                        full_name = "Карпов Илья Михайлович",
                        email = "karpov7232@mail.ru",
                        identifier = 3,
                        id_post = 3
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

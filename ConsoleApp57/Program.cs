using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тип доставки: 1-Пицца, 2-Суши, 3-Бургер");
            int choice = int.Parse(Console.ReadLine());
            Delivery delivery;

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Вы выбрали доставку:");
                    delivery = new PizzaDelivery();
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали доставку:");
                    delivery = new SushiDelivery();
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали доставку:");
                    delivery = new BurgerDelivery();
                    break;
                default:
                    Console.WriteLine("Неправильный выбор");
                    break;
            }
        }
        public abstract class Delivery
        {
            public abstract void Prepare();
        }

        public class PizzaDelivery : Delivery
        {
            public override void Prepare()
            {
                Console.WriteLine("Пицца доставляется в коробке");
            }
        }

        public class SushiDelivery : Delivery
        {
            public override void Prepare()
            {
                Console.WriteLine("Суши доставляются в контейнере");
            }
        }

        public class BurgerDelivery : Delivery
        {
            public override void Prepare()
            {
                Console.WriteLine("Бургер доставляется в пакетике");
            }
        }
    }
}

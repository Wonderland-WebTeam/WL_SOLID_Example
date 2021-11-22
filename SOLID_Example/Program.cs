using SOLID_Example.DIP.After;
using SOLID_Example.LSP.After;
using SOLID_Example.OCP.After;
using System;
using System.Collections.Generic;

namespace SOLID_Example
{
    internal class Program
    {
        private static void Main()
        {
            OcpExample();
            LspExample();
            DipExample();

            Console.Read();
        }

        /// <summary>
        /// OCP 範例
        /// </summary>
        public static void OcpExample()
        {
            Console.WriteLine("### OCP Example ###");

            Fruit apple = new Apple();
            Fruit banana = new Banana();

            Console.WriteLine(apple);
            Console.WriteLine(banana);
        }

        /// <summary>
        /// LSP 範例
        /// </summary>
        public static void LspExample()
        {
            Console.WriteLine("### LSP Example ###");

            FruitForLsp cherry = new Cherry();
            Console.WriteLine(cherry);

            IFruit orange = new Orange();
            var fruits = new List<IFruit> { cherry, orange };

            fruits.ForEach(f => Console.WriteLine($"{f.Name}: {f.Price}"));
        }

        /// <summary>
        /// DIP 範例
        /// </summary>
        public static void DipExample()
        {
            Console.WriteLine("### DIP Example ###");

            Line line = new Line();
            Notification notify = new Notification(line);
            notify.Notify();

            Telegram telegram = new Telegram();
            notify = new Notification(telegram);
            notify.Notify();
        }
    }
}

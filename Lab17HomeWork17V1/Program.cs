using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17HomeWork17V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номер счета будет целым числом? Введите: Да / Нет ");
            BankAkaunt<int> bank1 = new BankAkaunt<int>();
            BankAkaunt<string> bank2 = new BankAkaunt<string>();
            string a = Convert.ToString(Console.ReadLine());
            if (a == "Да")
            {
                Console.Write("Введите номер счета: ");
                bank1.Num = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите баланс: ");
                bank1.Balance = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите ФИО: ");
                bank1.Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine();
                bank1.ShowInfo();
            }
            else
            {
                Console.Write("Введите номер счета: ");
                bank2.Num = Convert.ToString(Console.ReadLine());
                Console.Write("Введите баланс: ");
                bank2.Balance = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите ФИО: ");
                bank2.Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine();
                bank2.ShowInfo();
            }
            Console.ReadKey();
        }
    }
    class BankAkaunt<T>
    {
        private T num;
        private double balance;
        private string name;
        public T Num { set { num = value; } get { return num; } }
        public double Balance { set { balance = value; } get { return balance; } }
        public string Name { set { name = value; } get { return name; } }


        public void ShowInfo()
        {
            Console.WriteLine("Номер счета: {0}", num);
            Console.WriteLine("ФИО: {0}", name);
            Console.WriteLine("Баланс: {0}$", balance);
        }

    }



}

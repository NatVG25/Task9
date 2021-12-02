using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            Console.Write("Введите целое число: X = ");
            int x = Convert.ToInt32(Console.ReadLine()); //ввод первого числа
            Console.Write("Введите целое число: Y = ");
            int y = Convert.ToInt32(Console.ReadLine()); //ввод второго числа
            Console.Write("Введите код операции: \n 1 - сложение \n 2 - вычитание \n 3 - произведение \n 4 - частное \n Ваш выбор:");//вывод кодов опеерации
            int oper = Convert.ToInt32(Console.ReadLine()); //ввод кода операции
            switch (oper) 
            {
                case 1:
                    {
                        Console.WriteLine("Результат = {0}", x + y); //сложение если код операции = 1
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Результат = {0}", x - y); //вычитание если код операции = 2
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Результат = {0}", x * y);//произведение если код операции = 3
                        break;
                    }
                case 4:
                    {
                        try  //обработка исключений в случае деления 0 на 0 и числа на 0
                        {
                            Console.WriteLine(x / y);
                        }
                        catch (Exception ex) when (x == 0 && y == 0)
                        {
                            Console.WriteLine("Деление 0 на 0!");
                            break;
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Ошибка! Деление на 0!");
                            break;
                        }
                        
                        Console.WriteLine("Результат = {0}", x / y); //частное если код операции = 4
                        break;
                    }
                default: //вывод предупреждения в случае неправильного кода операции
                    {
                        Console.WriteLine("Ошибка! Введен неправильный код операции!");
                        break;
                    }
            }
                Console.ReadKey();
        }
               
    }
        
}
  


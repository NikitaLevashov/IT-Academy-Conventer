using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var _converter = new Converter(2.61, 3.07);
           
            while(true)
            {
                Console.WriteLine("Выберите операцию: ");
                Console.WriteLine("1: Конвертация из BLR в USD");
                Console.WriteLine("2: Конвертация из BLR в EUR");
                Console.WriteLine("3: Конвертация из USD в BLR");
                Console.WriteLine("4: Конвертация из EUR в BLR");

                bool _a = int.TryParse(Console.ReadLine(),out int _temp);
                
                if(_a==false || _temp>4 || _temp<=0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введите корректное значение");
                    Console.ResetColor();
                }
                                   
                else 
                {
                    double value = _converter.Value();

                    switch (_temp)
                    {
                        case 1:
                            Console.WriteLine(String.Format("{0:f2}", _converter.ConvertToUsd(value)) + " $");
                            break;
                        case 2:
                            Console.WriteLine(String.Format("{0:f2}", _converter.ConvertToEur(value)) + " EUR");
                            break;
                        case 3:
                            Console.WriteLine(String.Format("{0:f2}", _converter.ConvertFromUsd(value)) + " BLR");
                            break;
                        case 4:
                            Console.WriteLine(String.Format("{0:f2}", _converter.ConvertFromEur(value)) + " BLR");
                            break;
                    }
                    break;
                }

            }
           
             Console.ReadKey();
        }
    }
}

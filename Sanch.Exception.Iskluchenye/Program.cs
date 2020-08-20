using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.String.Iskluchenye
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             int a = 2000000000;
             int b = 2000000000;
             int c = checked(a * b); отлавливает переполнение 
            */


            while (true)
            {
                var input = Console.ReadLine();
                if(int.TryParse(input, out int result)) // перевод вводимого сообщения в инт и запись его в result
                {
                    Console.WriteLine($"Интовый {result}");
                    break; // выход
                }
                else
                {
                    Console.WriteLine("Некорект ввод. Введите новое число");
                }
            }

            int r = 6;



            try //заключаем код который может заключать в себе какую то угрозу (слежка) (попытка выполнить код успешно)
            {
                /*
                 1 строка
                 2 строка с ошибкой
                 3 строка  
                 */


                //throw new DivideByZeroException(); //создание сгенерировать
                //throw new DivideByZeroException("dasdasdasd"); 
                throw new MyOwnException(); // генерация моего исключения
                var i = 5;
                var j = i / 0; 
                Console.WriteLine(j);//не будет выполнена, а если поменять 0 на 1 то будет


                int a = 2000000000;//не будет выполнена, а если поменять 0 на 1 то будет
                int b = 2000000000;//не будет выполнена, а если поменять 0 на 1 то будет
                int c = checked(a * b);// не будет выполнена, а если поменять 0 на 1 то будет  - Ошибка!!!!!!!!!!!!!!!!!!
            }
            //catch(/* "тип исключения" "исключение" или просто "тип исключения" (он может быть необязательным) */) //если есть исключение (отлавливаем исключение) - можно его обработать
            catch(MyOwnException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex) when (r == 5) // фильтрация!!!!!!!!!!!!!!!!!!!!!!!!!
            {
                Console.WriteLine("Деление на ноль r == 5");
            }
            catch (DivideByZeroException ex) // блоков catch может быть куча
            {
                Console.WriteLine("Деление на ноль");
                Console.WriteLine(ex.Message);//передача*****************************
            }
           
            catch (Exception ex)
            {
                // во второй строке ошибка, то никогда не перейдем на 3 строку , а перейдем в этот блок

                Console.WriteLine("Какое то исключение"); // отловили исключение
                throw; //это для переполнения
            }
            finally //обязательный!!! обязательно в этом блоке выполняется код
            {
                // мб работа с потоками (закрытие)
                // мб работа с памятью

                Console.WriteLine("Работа завершена"); //обязательно
                Console.ReadKey(); //обязательно
            }
            //var i = 5;
            //var j = i / 0; // тут ошибка
        }
    }
}

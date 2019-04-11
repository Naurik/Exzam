using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exzam
{
    public class OtvetyNaVoprosy
    {
        /*1-----
         * Console.WriteLine("Введите текст");
         * string source = Console.ReadLine();
         * var replacement = source.Replace(' ', '*'); //здесь первым входным параметром указывается какой символ изменить, 
                                                         //второй параметр означает на что изменить
           Console.WriteLine(source);
           Console.WriteLine(replacement);
           Console.ReadLine();*/

        /*2----------
         * Assembly a = Assembly.Load("MyLib");
            Object o = a.CreateInstance("vscode");
            Type type = a.GetType("7");

            Console.WriteLine("введите длину массива: ");
            int lenghtArray = int.Parse(Console.ReadLine());
            Object[] numbers = new Object[lenghtArray];
            for (int i = 0; i < lenghtArray; i++)
            {
                Random rnd = new Random();

                numbers[i] = rnd.Next(5, 15);
            }

            MethodInfo mi = type.GetMethod("add");
            Console.WriteLine(mi.Invoke(o, numbers));
            mi = type.GetMethod("sub");
            Console.WriteLine(mi.Invoke(o, numbers));
            Console.ReadLine();
         */


        /*3-------------
         * using System.Xml.Serialization;
         * 
         * Класс Item(сериализуем его свойства в xml формат)
         * XmlSerializer format = new XmlSerializer(typeof(Item));

                string path = (@"C:\Item.xml");
               using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
               {
                   format.Serialize(fs, item);
               }
            //Console.ReadLine();
         */


        /*5------------
         * Интерфейс это фактически регламент взаимодействия.
            Класс который реализует интерфейс обязан реализовывать все его методы(В чем и заключается его минус).
            В интерфейсе вы описываете лишь сигнатуры методов, то есть вы указываете что класс наследник должен уметь делать, но как он будет это делать решает сам(В чем и заключается его плюс). 
            Таким образом вы уверенны, что если класс реализует тот или иной интерфейс, все объекты данного класса имеют определенный набор методов.
         *
         * Абстрактный класс — это класс, у которого не реализован один или больше методов (некоторые языки требуют такие методы помечать специальными ключевыми словами).
         * Абстрактный класс нужен, когда нужно семейство классов, у которых есть много общего. Конечно, можно применить и интерфейс, но тогда нужно будет писать много идентичного кода.
         * Можно считать, что любой интерфейс — это уже абстрактный класс, но не наоборот.
         */

        /*6--------
         * Иногда бывают ситуации, когда необходимо чтобы тип значений мог принимать null, и это можно сделать, указав знак вопроса (?) после имени типа, при объявлении переменной.
         * Nullable-типы могут пригодиться при работе с базой данных. Некоторые поля таблицы базы данных могут принимать значение null. Например, значение булевого поля любит ли человек кошек может оставаться неизвестным. Или более практический пример. На главной странице этого сайта есть лента с уроками, и в ней несколько последних, остальные на страницах 2,3,…Номер страницы передается аргументом в http запросе ("…?page=2"), но для первого захода на сайт страницу 1 указывать в запросе не очень красиво, используя nullable-тип, переменная int, которая отвечает за номер страницы, в таком случае принимает значение null.
         * 
         */

    }
}

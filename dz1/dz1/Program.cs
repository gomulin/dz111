using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();

            Console.Write("Общее количество элементов в стеке : ");
            Console.WriteLine(myStack.Count);

            myStack.Push("first");
            myStack.Push("second");
            myStack.Push("third");
            myStack.Push("fourth");

            Console.Write("Добавил : ");
            Console.Write(myStack.Count);


            Console.Write("убрал верхний элемент из стека : ");
            Console.WriteLine(myStack.Pop());

            Console.Write("Стек пуст? : ");
            if (myStack.Count == 0)
            {
                Console.Write(true);
            }
            else
            {
                Console.Write(false);
            }

            Console.WriteLine();
            Console.Write("Общее количество элементов в стеке : ");
            Console.WriteLine(myStack.Count);

            Console.Write("Вернул элемент сверху стека : ");
            Console.WriteLine(myStack.Peek());

            Console.ReadKey();
        }
    }
}

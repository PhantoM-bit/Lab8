using System;

namespace ConsoleApp8
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //try
            //{
            //    Console.WriteLine("БЛОК TRY----------------------------------------------");
            //    MyList<Engine> newListOfElements = new MyList<Engine>();

            //    Engine newObject = new Engine();
            //    newListOfElements.AddElement(newObject);

            //    if (newListOfElements.ListOfElements == null)
            //    {
            //        throw new Exception("Нулевой указатель!!!");
            //    }
            //    else
            //    {
            //        newListOfElements.OutElements();
            //    }
            //    Console.WriteLine("КОНЕЦ БЛОКА TRY----------------------------------------");
            //}
            //catch (Exception exception)
            //{
            //    Console.WriteLine(exception.Source);
            //    Console.WriteLine(exception.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally Block");
            //    Console.WriteLine();
            //}

            MyList<int> list1 = new MyList<int>();
            list1.AddElement(10);
            list1.AddElement(10);
            list1.AddElement(10);
            list1.AddElement(10);
            list1.OutElements();

            Console.WriteLine();

            list1.WriteInFile();
            list1.OutFromFile();
        }
    }
}

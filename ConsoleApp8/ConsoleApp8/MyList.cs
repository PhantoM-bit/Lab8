using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp8
{
    interface IMethods<T>
    {
        void AddElement(T addElementPro);
        void OutElements();
        void DeleteElement(T deleteElement);
    }
    class MyList<T> : IMethods<T> where T: new()
    {

        private List<T> listOfElements;                  //Список
        public List<T> ListOfElements
        {
            get
            {
                return listOfElements;
            }
        }

        //Конструктор--------------------------------
        public MyList()
        {
            listOfElements = new List<T>();
        }
        //-------------------------------------------

        //Методы-------------------------------------
        public void AddElement(T addElement)              //Добавление элементов
        {
            Console.WriteLine("ПРОИСХОДИТ ДОБАВЛЕНИЕ...");
            listOfElements.Add(addElement);
            Console.WriteLine("ДОБАВЛЕНИЕ ЗАВЕРШЕНО");
        }
        public void OutElements()                         //Вывод списка
        {

            Console.WriteLine("ВЫВОД:");
            foreach (T element in listOfElements)
            {
                Console.WriteLine(element);
            }
        }
        public void DeleteElement(T deleteElement)        //Удаление элемента из списка
        {

            Console.WriteLine("ПРОИСХОДИТ УДАЛЕНИЕ...");
            listOfElements.Remove(deleteElement);
            Console.WriteLine("УДАЛЕНИЕ ЗАВЕРШЕНО");


        }
        public void WriteInFile()
        {
            string path = @"D:\OOP\1.txt";
            StreamWriter fileForWrite = new StreamWriter(path);
            foreach (T element in listOfElements)
            {
                fileForWrite.WriteLine(element);
            }
            fileForWrite.Close();
        }
        public void OutFromFile()
        {
            string path = @"D:\OOP\1.txt";
            StreamReader fileForRead = new StreamReader(path);
            string stringFromFile;
            if((stringFromFile = fileForRead.ReadLine()) == null)
            {
                Console.WriteLine("ФАЙЛ ПУСТ!!!");
            }
            else
            {
                Console.WriteLine(stringFromFile);
                while ((stringFromFile = fileForRead.ReadLine()) != null)
                {
                    Console.WriteLine(stringFromFile);
                }
            }
            fileForRead.Close();
        }
        //-------------------------------------------
    }
}

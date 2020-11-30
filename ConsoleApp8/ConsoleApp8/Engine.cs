using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Engine
    {
        private int power;              //Мощность двигателя
        public int Power
        {
            set
            {
                power = value;
            }
            get
            {
                return power;
            }
        }
        private int capacity;           //Объём двигателя
        public int Capacity
        {
            set
            {
                capacity = value;
            }
            get
            {
                return capacity;
            }
        }
        private bool status = false;    //Переменная состояния: включен двигатель или нет
        public bool Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        private int cost;                       //Стоимость
        public int Cost
        {
            set
            {
                cost = value;
            }
            get
            {
                return cost;
            }
        }

        private int speed;                      //Скорость
        public int Speed
        {
            set
            {
                speed = value;
            }
            get
            {
                return speed;
            }
        }

        private Machine structVar;              //Структорная переменная
        public Machine StructVar
        {
            get
            {
                return structVar;
            }
            set
            {
                structVar = value;
            }
        }

        public Mechanism enumVar;              //Переменная перечисления

        //Конструктор--------------------------------------------
        public Engine()
        {
            power = 1000;
            capacity = 500;
            cost = 1000;
            speed = 40;
            structVar = new Machine();
        }
        public Engine(int power, int capacity, bool status)
        {
            this.power = power;
            this.capacity = capacity;
            this.status = status;
            structVar = new Machine("metal", true);
        }
        //-------------------------------------------------------

        //Методы-------------------------------------------------
        public virtual void SwitchedOn()        //Запуск двигателя
        {
            Console.WriteLine("Запуск двигателя...");
            status = true;
        }
        public virtual void OnOrOff()           //Запущен ли?
        {
            if (status) Console.WriteLine("Двигатель запущен");
            else Console.WriteLine("Двигатель выключен");
        }
        public override string ToString()
        {
            return "Мощность двигателя: " + power + "Вт;" + "\n" + "Объем двигателя: " + capacity + "см^3;" + "\n"
                + "Запущен ли двигатель:" + status + ";" + "\n" + "Материал кузова: "
                + StructVar.materialOfBody + ";" + "\n" + "Наличие окон: " + StructVar.windows + ";" + "\n"
                + "Переменная перечисления1: " + Mechanism.var1 + ";" + "\n"
                + "Переменная перечисления2: " + Mechanism.var2 + ";"
                + "\n"
                + "Переменная перечисления3: " + Mechanism.var3 + ";";
        }
        //-------------------------------------------------------

        //Структура и перечисления-------------------------------
        public struct Machine
        {
            public string materialOfBody;
            public bool windows;
            public Machine(string material, bool windows)
            {
                materialOfBody = material;
                this.windows = windows;
            }
        }
        public enum Mechanism
        {
            var1,
            var2,
            var3
        }
        //-------------------------------------------------------
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_12
{
    class EventDelegateClass
    {
        private string name;

        public delegate void EventDelegate(string txt); // создане делегата
        public EventDelegateClass(string name)// конструктор
        {
            this.name = name;
        }
        public event EventDelegate Event;// создание собітия с делегатом 
        public void RaiseMyEvent()
        {// создает собітиеесли его нет  то есть генерирует собітия     
            if (Event != null)
            {
                Event(name);
            }
        }
    }
    class Class
    {
        private string text;
        public Class(string text) //конструктор
        {
            this.text = text;
        }
        public void show(string objname)
        {
            Console.WriteLine("Объект, сгенерировавший событие: " + objname);
            Console.WriteLine("Сообщение: " + text);
        }
    }
    class Program
    {
        static void Main()
        {
            EventDelegateClass Odject1 = new EventDelegateClass("Odject1");
            EventDelegateClass Odject2 = new EventDelegateClass("Odject2");

            Class ClassObject = new Class("ClassObject");

            Odject1.Event += ClassObject.show;
            Odject2.Event += ClassObject.show;

            Odject1.RaiseMyEvent();
            Console.WriteLine();

            Odject2.RaiseMyEvent();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

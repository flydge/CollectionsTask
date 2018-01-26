using System;
using System.Collections;
using CollectionsTask.Properties;


namespace CollectionsTask
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Worker worker1 = new Worker("Alex","Magnuson",25,"master of BBB");
            Worker worker2 = new Worker("Loda","Berg",24,"master of the Alliance");
            Worker worker3 = new Worker("Lorgar","Lodbroc",27,"master of Vikings");
            Worker worker4 = new Worker("Artyom","Novak",33,"master of AAA");
            Worker worker5 = new Worker("Ioan","Berg",19,"master of the Alliance");

            Crew simpleList = new Crew
            {          
                worker1,
                worker2,
                worker3,
                worker4,
                worker5
            };

            simpleList.Sort();
            foreach (var worker in simpleList)
            {
               Console.WriteLine(worker);
            }
            
         
        }
    }
}
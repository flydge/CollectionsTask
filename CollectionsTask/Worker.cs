using System;
using System.Collections;

namespace CollectionsTask.Properties
{
    public class Worker:IComparer
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _workingPosition;

        public Worker()
        {
        }

        public Worker(string firstName, string lastName, int age, string workingPosition)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _workingPosition = workingPosition;
        }
    
        public override string ToString()
        {
            return String.Format("Name:{0} {1}\nAge:{2}\nWorking position:{3}\n",
                _firstName, _lastName, _age, _workingPosition);
        }

        public int Compare(object x, object y)
        {
            Worker wx = (Worker) x;
            Worker wy = (Worker) y;
            return String.Compare(wx._workingPosition, wy._workingPosition, StringComparison.Ordinal);
        }
    }
}
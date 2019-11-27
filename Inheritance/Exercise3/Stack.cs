using System;
using System.Collections;

namespace Exercise3
{
    public class Stack
    {
        private readonly ArrayList _arrayList;

        public Stack()
        {
            _arrayList=new ArrayList();
        }
        public void Push(object obj)
        {
            if(obj==null)
                throw  new InvalidOperationException();
            _arrayList.Add(obj);
        }

        public object Pop()
        {
            var obj = _arrayList[^1];
            _arrayList.Remove(obj);
            return obj;
        }

        public void Clear()
        {
            for (int i = 0; i < _arrayList.Count; i++)
            {
                _arrayList.Remove(i);
            }
        }
    }
}
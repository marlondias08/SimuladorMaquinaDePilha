using System;
using System.Collections.Generic;
using System.Collections;

namespace MQ
{
    public class MyStack
    {
        private Stack<MyType> stack = new Stack<MyType>();

        public void push (MyType type)
        {
            stack.Push(type);
        }
        public MyType pop()
        {
            return stack.Pop();            
        }
        public MyType inspect()
        {
            return stack.Peek();
        }
    }
}
using System;
using System.Collections;

namespace CollectionsExamples.App
{
    class StackQueue
    {

        Stack<DateTime> stk = new Stack<DateTime>();
        Queue<DateTime> q = new Queue<DateTime>();

        public StackQueue() {
            for (int i=0; i<11; i++) 
            {
                stk.Push(DateTime.Now);
                q.Enqueue(DateTime.Now);
            }
        }

        public void clearStackQueue()
        {
            while (stk.Count()!=0)
            {
                stk.Pop();
            }
            while (q.Count()!=0)
            {
                q.Dequeue();
            }

        }

    }
}
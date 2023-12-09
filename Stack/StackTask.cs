﻿// Create a stack of numbers generated by a random number generator.
// Arrange stack by increasing element values, using an additional stack for this.
// Display stacks before and after conversion.

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsTask
{
    class StackTask
    {
        static Stack<int> SortStack(Stack<int> stack_)
        {
            int[] num = stack_.ToArray();
            Stack<int> stack = new Stack<int>();
            Array.Sort(num);
            for (int i = 0; i < num.Length; i++)
            {
                stack.Push(num[i]);
            }
            return stack;
        }
        static string OutputStack(Stack<int> stack_)
        {
            string returns = null;
            foreach (int i in stack_)
                returns = returns + i + ' ';
            return returns;
        }
        static public void Task()
        {
            Random random = new Random();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < random.Next(3, 21); i++)
            {
                stack.Push(random.Next(-101, 101));
            }
            Stack<int> stackSorted = SortStack(stack);
            Console.WriteLine($"\nPrimary Stack: {OutputStack(stack)}");
            Console.WriteLine($"Finaly Stack: {OutputStack(stackSorted)}");
            Console.ReadKey();
        }
    }
}

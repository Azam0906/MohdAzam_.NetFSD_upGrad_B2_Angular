using System;


namespace ArraysDemo
{
    internal class StackUndoSystem
    {
        static void Main(string[] args)
        {
            string[] stack = new string[10];
            int top = -1;
            Push(stack, ref top, "Type A");
            Push(stack, ref top, "Type B");
            Push(stack, ref top, "Type C");

            Pop(ref top);
            Pop(ref top);

            if (top >= 0)
                Console.WriteLine("Current State After Operations: " + stack[top]);
            else
                Console.WriteLine("Stack is empty");
        }

        static void Push(string[] stack, ref int top, string action)
        {
            if (top == stack.Length - 1)
                return;
            top++;
            stack[top] = action;
        }

        static void Pop(ref int top)
        {
            if (top == -1)
                return;
            top--;
        }
    }
}

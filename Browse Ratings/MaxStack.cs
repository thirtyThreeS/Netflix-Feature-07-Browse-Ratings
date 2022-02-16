using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browse_Ratings
{
    public class MaxStack
    {
        Stack<int> mainStack; // Original Values
        Stack<int> maxStack;  // Max Value w/ Top of maxStack always being max value.

        public MaxStack()
        {
            mainStack = new Stack<int>();
            maxStack = new Stack<int>();
        }

        // Removes and returns value from stack
        public int Poppers()
        {
            maxStack.Pop();         // Pop element from maxStack making it sync with mainStack
            return mainStack.Pop(); // Pop element from mainStack and return it's value
        }

        // Pushes value into the stack
        public void Pusher(int value)
        {
            mainStack.Push(value);
            if (maxStack.Count != 0 && maxStack.Peek() > value) maxStack.Push(maxStack.Peek()); // Push value in mainStack and check value with the top value of maxStack 
            else maxStack.Push(value);                                                          // If value is greater than top.. push to top in mainStack
        }                                                                                       // Else push value in maxStack

        // Returns max value in O(1)
        public int MaxRating()
        {
            return maxStack.Peek(); 
        }
    }
}

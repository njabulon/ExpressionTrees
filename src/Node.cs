using System;

namespace src {
    public class Node 
    {
        public int data;
        public char operand;
        public Node Left;
        public Node Right;

        public Node(int data, char operand = ' ')
        {
            this.data = data;
            this.operand = operand;
        }

    }

}
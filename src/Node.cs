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

    public interface Node2 
    {
        int Evaluate();
    }

    public class ValueNode : Node2{
        private int Data;
        public ValueNode(int data){
            Data = data;
        }

        public int Evaluate(){
            return Data;
        }
    }

    public enum Operand {
        ADD, SUB, MUL, DIV
    }

    public class OperationNode : Node2{
        private Operand Operand;
        public Node2 Left{get;set;}
        public Node2 Right{get;set;}
        public OperationNode(Operand operand){
            Operand = operand;
        }
        
        public int Evaluate(){
            
            var left = Left.Evaluate();
            var right = Right.Evaluate();

            switch (Operand){
                case Operand.ADD:
                return left + right; 
            }
            return 0;
        }
    }

}
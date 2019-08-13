using System;
using src;
using Xunit;

namespace test {
    public class UnitTest1 {
        [Fact]
        public void Evaluate_GivenEmptyTree_ExpectZero () {
            //Given
            var tree = new Tree ();
            var expected = 0;

            //When
            var actual = Evaluator.Evaluate (tree.Root);

            //Then
            Assert.Equal (actual, expected);
        }

        [Fact]
        public void Evaluate_GivenValidTree_ExpectResult () {
            //Given
            var tree = new Tree { Root = new Node (0, '*') };
            tree.Root.Left = new Node(0, '+');
            tree.Root.Right = new Node(0, '-');
            tree.Root.Left.Left = new Node(3);
            tree.Root.Left.Right = new Node(2);
            tree.Root.Right.Left = new Node(5);
            tree.Root.Right.Right = new Node(1);
            var expected = 20;

            //When
            var actual = Evaluator.Evaluate (tree.Root);

            //Then
            Assert.Equal (actual, expected);
        }
    }
}
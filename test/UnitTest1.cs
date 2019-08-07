using System;
using Xunit;
using src;

namespace test {
    public class UnitTest1 {
        [Fact]
        public void Evaluate_GivenEmptyTree_ExpectZero () {
            //Given
            var tree = new Tree();
            var expected = 0;

            //When
            var actual = Evaluator.Evaluate(tree.Root);

            //Then
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Evaluate_GivenValidTree_ExpectResult () {
            //Given
            var tree = new Tree{Root = new Node()};
            var expected = 0;

            //When
            var actual = Evaluator.Evaluate(tree.Root);

            //Then
            Assert.Equal(actual, expected);
        }
    }
}
using System;
using System.Collections.Generic;

namespace AscendingTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tree = new Node()
            {
                LeftChild = new Node()
                {
                    LeftChild = new Node() { LeftChild = null, RightChild = null, Weight = 9 },
                    RightChild = new Node() { LeftChild = null, RightChild = null, Weight = 79 },
                    Weight = 1
                },
                RightChild = new Node()
                {
                    LeftChild = new Node() { LeftChild = null, RightChild = null, Weight = 10 },
                    RightChild = new Node() { LeftChild = null, RightChild = null, Weight = 6 },
                    Weight = 25
                },

                Weight= 5
            };
            var result  = GetOrderedWeights(tree);

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        public class Node
        {
            public Node LeftChild { get; set; }
            public Node RightChild { get; set; }
            public int Weight { get; set; }
        }

        public static List<int> GetOrderedWeights(Node tree)
        {
            // implement here
            List<int> weights = new List<int>();
            int temporaryVariable = 0;

            weights.Add(tree.Weight);
            weights.Add(tree.LeftChild.Weight);
            weights.Add(tree.RightChild.Weight);
            weights.Add(tree.LeftChild.LeftChild.Weight);
            weights.Add(tree.LeftChild.RightChild.Weight);
            weights.Add(tree.RightChild.LeftChild.Weight);
            weights.Add(tree.RightChild.RightChild.Weight);

            for (int i = 0; i <= weights.Count - 1; i++)
            {
                for (int j = i + 1; j < weights.Count; j++)
                {
                    if (weights[i] > weights[j])
                    {
                        temporaryVariable = weights[i];
                        weights[i] = weights[j];
                        weights[j] = temporaryVariable;
                    }
                }
            }

            return weights;

        }
    }
}

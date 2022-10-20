using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTechHomework
{
    public class Branch
    {
        private List<Branch> _branches;

        public Branch()
        {
            _branches = new List<Branch>();
        }
        public void AddBranch(Branch branch)
        {
            _branches.Add(branch);
        }
        public Branch GetBranch(int index)
        {
            return _branches[index];
        }
        public int Count()
        {
            return (_branches.Count);
        }

        public static int MaxDepth(Branch branch, int currentDepth = 1)
        {
            if (branch.Count() == 0)
            {
                return currentDepth;
            }

            return Enumerable.Range(0, branch.Count()).Max(i => MaxDepth(branch.GetBranch(i), currentDepth + 1));
        }

        public static Branch InitializeTree()
        {
            Branch root = new Branch();
            Branch branch2 = new Branch();
            Branch branch3 = new Branch();
            root.AddBranch(branch2);
            root.AddBranch(branch3);
            Branch branch4 = new Branch();
            branch2.AddBranch(branch4);
            Branch branch5 = new Branch();
            Branch branch6 = new Branch();
            Branch branch7 = new Branch();
            branch3.AddBranch(branch5);
            branch3.AddBranch(branch6);
            branch3.AddBranch(branch7);
            Branch branch8 = new Branch();
            branch5.AddBranch(branch8);
            Branch branch9 = new Branch();
            Branch branch10 = new Branch();
            branch6.AddBranch(branch9);
            branch6.AddBranch(branch10);
            Branch branch11 = new Branch();
            branch9.AddBranch(branch11);
            return root;
        }

        public static void Branches()
        {
            Branch tree = InitializeTree();

            Console.Clear();
            Console.WriteLine($"Depth of the tree: {MaxDepth(tree)}");
        }
    }
    
}

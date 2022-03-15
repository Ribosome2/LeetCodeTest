namespace TestInConsoleApp
{
    public class Tree_InvertTree
    {
        public TreeNode InvertTree(TreeNode root) {
            if (root == null)
            {
                return null;
            }

            var temp = root.left;
            root.left = root.right;
            root.right = temp;
            InvertTree(root.left);
            InvertTree(root.right);
            
            return root;
        }
    }
}
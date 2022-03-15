namespace TestInConsoleApp
{
    public class Tree_SortedArrayToBST
    {
        //        将一个按照升序排列的有序数组，转换为一棵高度平衡二叉搜索树。
        //        本题中，一个高度平衡二叉树是指一个二叉树每个节点 的左右两个子树的高度差的绝对值不超过
        public TreeNode SortedArrayToBST(int[] nums)
        {
            // 左右等分建立左右子树，中间节点作为子树根节点，递归该过程
            if (nums == null || nums.Length == 0)
            {
                return null;
            }

            return BuildTree(nums, 0, nums.Length - 1);
        }

        private TreeNode BuildTree(int[] nums, int l, int r)
        {
            if (l > r)
            {
                return null;
            }

            if (l == r)
            {
                return new TreeNode(nums[l]);
            }

            int mid = (l + r) / 2;
            TreeNode root=new TreeNode(nums[mid]);
            root.left = BuildTree(nums, l, mid - 1);
            root.right = BuildTree(nums, mid + 1, r);
            return root;
        }
    }
}
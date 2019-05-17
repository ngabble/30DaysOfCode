using System;
class Node{
    public Node left,right;
    public int data;
    public Node(int data){
        this.data=data;
        left=right=null;
    }
}
class Solution
{
    static int getHeight(Node root)
    {
        int height;
        int rightHeight = 0;
        int leftHeight = 0;
        Node current = root; 

        while (current.right != null | current.left != null)
        {
            if (current.right != null) 
            {   
                current = current.right;
                rightHeight++;
            }
            else
            {
                current = current.left;
                rightHeight++;                
            }
        }
        current = root;
        while (current.left != null | current.right != null)
        {
            if (current.left != null) 
            {   
                current = current.left;
                leftHeight++;
            }
            else
            {
                current = current.right;
                leftHeight++;                
            }
        }
        if(rightHeight > leftHeight)
        {
            height = rightHeight;
            return height;
        }
        else
        {
            height = leftHeight;
            return height;
        }
    }

    static Node insert(Node root, int data){
        if(root==null){
            return new Node(data);
        }
        else{
            Node cur;
            if(data<=root.data){
                cur=insert(root.left,data);
                root.left=cur;
            }
            else{
                cur=insert(root.right,data);
                root.right=cur;
            }
            return root;
        }
    }
    static void Main(String[] args){
        Node root=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            root=insert(root,data);            
        }
        int height=getHeight(root);
        Console.WriteLine(height);
    }
}


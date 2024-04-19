namespace Medium;


// https://leetcode.com/problems/min-stack
public class MinStack
{
    private List<int> list;
    
    public MinStack()
    {
        list = new List<int>();
    }
    
    public void Push(int val) 
    {
        list.Add(val);
    }
    
    public void Pop() 
    {
        list.RemoveAt(list.Count - 1);
    }
    
    public int Top()
    {
        return list[^1];
    }
    
    public int GetMin()
    {
        return list.Min();
    }
}
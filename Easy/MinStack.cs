public class MinStack {

    /** initialize your data structure here. */
    Stack<int> minStack;
    Stack<int> stack;
    int min = 0;
    public MinStack() {
        minStack = new Stack<int>();
        stack = new Stack<int>();
    }
    
    public void Push(int x) {
        if (stack.Count == 0){
            min = x;
        }
        else if (min>=x){
            minStack.Push(min);
            min = x;
        }
        stack.Push(x);
        
    }
    
    public void Pop() {
        int temp = stack.Pop();
        if (temp == min && minStack.Count!= 0){
            min = minStack.Pop();
        }
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return min;
    }
}

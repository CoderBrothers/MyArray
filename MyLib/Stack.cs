using System.Collections;
namespace Collections
{
    public class Stack<T> : IEnumerable<T>
    {
        private Array<T> _stack;

        public Stack()
        {
            _stack = new Array<T>();
        }
        public void Clear() => _stack.Clear();
        public void Push(T value) => _stack.Add(value);
        public T Peek() => _stack[_stack.Length - 1];
        public T Pop() => _stack.Pop();
        public bool Contains(T value) => _stack.Contains(value);
        public bool IsEmpty() => _stack.IsEmpty();
        public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)_stack).GetEnumerator();
        IEnumerator System.Collections.IEnumerable.GetEnumerator() => _stack.GetEnumerator();
    }
}
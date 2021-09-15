namespace four
{
    public class DequeElement<T>
    {
        public DequeElement(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public DequeElement<T> Previous;
        public DequeElement<T> Next;
    }
}
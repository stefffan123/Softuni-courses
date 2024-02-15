namespace Generics
{
    public class Box<T>
    {
        private T value;

        public Box(T value)
        {
            Value = value;
        }

        public T Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public override string ToString()
        {
            return $"{value.GetType()}: {value}";
        }
    }
}

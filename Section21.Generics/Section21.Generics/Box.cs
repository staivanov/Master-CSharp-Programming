using static System.Console;

namespace Section21.Generics
{
    public class Box<T>
    {
        private T _content;

        public Box(T initialValue)
        {
            _content = initialValue;
        }


        public T GetContent()
        {
            return _content;
        }


        public void UpdateContent(T newContent)
        {
            _content = newContent;
            WriteLine($"Updated content to {_content}");
        }
    }
}

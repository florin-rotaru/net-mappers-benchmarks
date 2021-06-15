using System.Collections;
using System.Collections.Generic;

namespace Models
{
    public class TEnumerable<T> : IEnumerable<T>
    {
        private List<T> Collection { get; set; } = new List<T>();

        public TEnumerable() { }
        
        public void Add(T item) =>
            Collection.Add(item);

        public IEnumerator<T> GetEnumerator() =>
            Collection.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() =>
            Collection.GetEnumerator();
    }


    public class CustomEnumerable : TEnumerable<int> { }
}

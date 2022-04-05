using System.Collections.Generic;
using System.Linq;

namespace PatternsThirdPart.Iterator.Abstractions
{
    public abstract class BaseEnumerable : IEnumerable
    {
        protected List<int> Collection { get; set; }
        public BaseEnumerable()
        {
            Collection = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }

        public abstract int this[int index] { get; }
        public abstract IEnumerator GetEnumerator();
        public int Count => Collection.Count();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace zadatak4 {
    class GenericListEnumerator<T> : IEnumerator<T> {

        IGenericList<T> _collection;
        static int index_next=-1;


        public GenericListEnumerator(IGenericList<T> collection) {
            _collection = collection;
        }


        public T Current {
            get {
                return _collection.GetElement(index_next);          
            }
        }

        object IEnumerator.Current {
            get {
                return Current;
            }
        }



        public bool MoveNext() {
            ++index_next;
            return index_next < _collection.Count;
        }


        public void Dispose() {}

        public void Reset() {}
    }
}

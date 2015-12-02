using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak4 {
    class GenericList<X> : IGenericList<X> {
        private int p;
        private X[] _internalStorage;

        public GenericList() {
            p = 0;
            _internalStorage = new X[4];
        }

        public GenericList(int n) {
            p = 0;
            _internalStorage = new X[n];
        }



        public int Count {
            get {
                return p;
            }
        }


        public void Add(X item) {
            if (p >= _internalStorage.Length) {
                X[] pom = new X[_internalStorage.Length];

                for (int i = 0; i < p; ++i) pom[i] = _internalStorage[i];
                _internalStorage = new X[_internalStorage.Length * 2];
                for (int i = 0; i < p; ++i) _internalStorage[i] = pom[i];

            }

            _internalStorage[p] = item;
            ++p;
        }

        public void Clear() {
            p = 0;
        }

        public bool Contains(X item) {
            for (int i = 0; i < p; ++i) if (_internalStorage[i].Equals(item)) return true;
            return false;
        }

        public object ElementAt(int index) {
            if (index < p) {
                return _internalStorage[index];
            } else {
                throw new IndexOutOfRangeException();
            }
        }

        public X GetElement(int index) {
            if (index < p) {
                return _internalStorage[index];
            } else {
                throw new IndexOutOfRangeException();
            }
        }

        public IEnumerator<X> GetEnumerator() {
            return new GenericListEnumerator<X>(this);
        }

        public int IndexOf(X item) {
            for (int i = 0; i < p; ++i) {
                if (_internalStorage[i].Equals(item)) return i;
            }
            return -1;
        }


        public bool Remove(X item) {
            for (int i = 0; i < p; ++i) if (_internalStorage[i].Equals(item)) return RemoveAt(i);

            return false;
        }

        public bool RemoveAt(int index) {
            if (index >= p) return false;

            for (int i = index; i < p; ++i)
                _internalStorage[i] = _internalStorage[i + 1];
            --p;

            return true;
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}

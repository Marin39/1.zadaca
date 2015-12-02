using System;

namespace zadatak1 {
    class IntegerList : IIntegerList{

        private int p;
        private int[] _internalStorage;

        public IntegerList() {
            p = 0;
            _internalStorage = new int[4];
        }

        public IntegerList(int n) {
            p = 0;
            _internalStorage = new int[n];
        }



        public int Count {
            get {
                return p;
            }
        }

        public void Add(int item) {
            if (p >= _internalStorage.Length) {
                int[] pom = new int[_internalStorage.Length];

                for (int i = 0; i < p; ++i) pom[i] = _internalStorage[i];
                _internalStorage = new int[_internalStorage.Length*2];
                for (int i = 0; i < p ; ++i) _internalStorage[i] = pom[i];

            } 

            _internalStorage[p] = item;
            ++p;                    
        }

        public void Clear() {
            p = 0;
        }

        public bool Contains(int item) {
            for (int i=0; i < p;++i) if (_internalStorage[i] == item) return true;
            return false;
        }

        public int GetElement(int index) {
            if (index < p) {
                return _internalStorage[index];
            } else {
                throw new IndexOutOfRangeException();
            }
        }

        public int IndexOf(int item) {
            for(int i = 0; i < p ; ++i) {
                if (_internalStorage[i] == item) return i;
            }
            return -1;
        }

        public bool Remove(int item) {
            for(int i=0;i< p; ++i) if (_internalStorage[i] == item) return RemoveAt(i);
            
            return false;
        }

        public bool RemoveAt(int index) {
            if (index >=p) return false;

            for (int i = index; i <p; ++i)
                _internalStorage[i] = _internalStorage[i+1];          
            --p;

            return true;
        }
    }
}

using System;
using System.Collections;

namespace InterfaceDemo {
    class Program {
        static void Main(string[] args) {
            int[] nums1 = new int[] { 1, 2, 3, 4, 5 };
            ArrayList nums2 = new ArrayList { 1, 2, 3, 4, 5 };
            var nums3 = new ReadOnlyCollection(nums1);

            Console.WriteLine($"Sum of int[]: {Sum(nums1)}");
            Console.WriteLine($"Avg of int[]: {Avg(nums1)}");
            Console.WriteLine($"Sum of ArrayList: {Sum(nums2)}");
            Console.WriteLine($"Avg of ArrayList: {Avg(nums2)}");
            Console.WriteLine($"Sum of ReadOnlyCollection: {Sum(nums3)}");
            Console.WriteLine($"Avg of ReadOnlyCollection: {Avg(nums3)}");
            //Sum of int[]: 15
            //Avg of int[]: 3
            //Sum of ArrayList: 15
            //Avg of ArrayList: 3
            //Sum of ReadOnlyCollection: 15
            //Avg of ReadOnlyCollection: 3
        }

        static int Sum(IEnumerable nums) {
            int sum = 0;
            foreach (var num in nums) {
                sum += (int)num;
            }
            return sum;
        }

        static double Avg(IEnumerable nums) {
            int sum = 0;
            int count = 0;
            foreach (var num in nums) {
                sum += (int)num;
                count++;
            }
            return (1.0 * sum / count);
        }
    }

    // 自定义类 实现接口 IEnumerable
    class ReadOnlyCollection : IEnumerable {
        private int[] _array;

        public ReadOnlyCollection(int[] array) {
            _array = array;
        }

        public IEnumerator GetEnumerator() {
            return new Enumerator(this);
        }

        // 内部类
        public class Enumerator : IEnumerator {
            private ReadOnlyCollection _collection;
            private int _head;

            public Enumerator(ReadOnlyCollection collection) {
                _collection = collection;
                _head = -1;
            }

            public object Current {
                get {
                    object o = _collection._array[_head];
                    return o;
                }
            }

            public bool MoveNext() {
                return (++_head < _collection._array.Length);
            }

            public void Reset() {
                _head = -1;
            }
        }
    }
}

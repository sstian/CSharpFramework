using System;

namespace GenericMethod {
    class Program {
        static void Main(string[] args) {
            int[] a1 = { 11, 12, 13 };
            int[] a2 = { 21, 22, 23 };
            double[] b1 = { 110, 120, 130 };
            double[] b2 = { 210, 220, 230 };

            var resa = Zip(a1, a2);
            var resb = Zip(b1, b2);
            Console.WriteLine(string.Join(", ", resa));
            Console.WriteLine(string.Join(", ", resb));
            //11, 21, 12, 22, 13, 23
            //110, 210, 120, 220, 130, 230
        }

        static T[] Zip<T>(T[] a, T[] b) {
            T[] zipped = new T[a.Length + b.Length];
            int ai = 0, bi = 0, zi = 0;
            while (ai < a.Length || bi < b.Length) {
                if (ai < a.Length) { zipped[zi++] = a[ai++]; }
                if (bi < b.Length) { zipped[zi++] = b[bi++]; }
            }
            return zipped;
        }
    }
}

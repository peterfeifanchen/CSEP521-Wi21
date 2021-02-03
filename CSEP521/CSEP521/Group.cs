using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEP521 {
    public class Group {

        int n;
        int order;

        int[,] G;
        int[] elts;

        public int N {
            get;
        }
        public Group (int n) {
            this.n = n;

            order = Totient(n);

            elts = new int[order];
            G = new int[order, order];

            int count = 0;
            for (int i = 0; i < n; i++) {
                if (GCD(i,n) == 1) {
                    elts[count] = i;
                    count++;
                }
            }

            for (int i = 0; i < order; i++)
                for (int j = 0; j < order; j++)
                    G[i, j] = elts[i]* elts[j] % n;
                 
        }


        public string GroupTable() {

            return TableToString(G, order, order, 3);
        }

        public string PowerTable() {
            int[,] T = new int[order, n-1];

            for (int i = 0; i < order; i++) {
                int a = elts[i];
                T[i, 0] = a;
                for (int j = 1; j < n - 1; j++)
                    T[i, j] = T[i, j - 1] * a % n;
            }

            return TableToString(T, order, n - 1, 3);
        }

        public string TableToString(int[,] T, int r, int c, int padding) {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < r; i++) {
                for (int j = 0; j < c; j++)
                    sb.Append(T[i, j].ToString().PadLeft(padding));
                sb.Append("\r\n");
            }
            return sb.ToString();

        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < n; i++) {
                for (int j = 1; j < n; j++)
                    sb.Append(G[i, j].ToString().PadLeft(3));
                sb.Append("\r\n");
            }
            return sb.ToString();
        }

        public int Power(int a, int x) {
            int r = 1;
            for (int i = 0; i < x; i++)
                r = r * a % n;

            return r;
        }

        public int GCD(int x, int y) {
            int a = x;
            int b = y;
            int t;
            Console.WriteLine("A: " + a + ", B: " + b);
            while (b != 0) {
                t = b;
                b = a % b;
                a = t;
                Console.WriteLine("A: " + a + ", B: " + b);
            }

            return a;
        }


        public int Totient(int k) {
            int phi = 0;
            for (int i = 1; i < k; i++) {
                if (GCD(i, k) == 1)
                    phi++;
            }

            return phi;
        }
        public string TestFunction() {

            int[] powers = new int[22];
            int[] exponent = new int[22];


            int a = 2;
            powers[0] = a;
            exponent[0] = 1;

            int p = 1048579;

            for (int i = 1; i < 21; i++) {
                long temp1 = (long) powers[i - 1] * (long) powers[i - 1];
                long temp2 = temp1 % p;
                powers[i] = (int)temp2;
                exponent[i] = exponent[i - 1] + exponent[i - 1];
            }

            long temp3 = (long)powers[20] * a * a;
            long temp4 = temp3 % p;
            powers[21] = (int)temp4;
            exponent[21] = exponent[20] + 2;





            /*            int[] tots = new int[n - 2];

                        for (int i = 2; i < n; i++)
                            tots[i-2] = Totient(i);

                        return Algorithm.ArrayToString(tots);
                        */
            return Algorithm.ArrayToString(powers) + "\r\n" + Algorithm.ArrayToString(exponent);

        }


    }
}

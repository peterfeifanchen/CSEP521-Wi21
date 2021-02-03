using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEP521 {
    class IncrementalMatching {

        struct Pref {
            public Pref(int i, int r) {
                Index = i;
                Rank = r;
            }

            public int Index { get; }
            public int Rank { get;  }

        }

        int n;
        Random random;

        public IncrementalMatching(int n, Random random) {

            this.n = n;
            this.random = random;
        }
        public void GaleShapley(Trace trace) {
            Stack<int> unMatched = new Stack<int>();
            int[] mMatching = new int[n];
            int[] wMatching = new int[n];
            int[] pos = new int[n];

            for (int i = 0; i < n; i++) {
                unMatched.Push(i);
                mMatching[i] = -1;
                wMatching[i] = -1;
                pos[i] = -1;
            }

            List<Pref>[] mPref = new List<Pref>[n];
            List<Pref>[] wPref = new List<Pref>[n];
            for (int i = 0; i < n; i++) {
                mPref[i] = new List<Pref>();
                wPref[i] = new List<Pref>();
            }

            while (unMatched.Count > 0) {
                int m = unMatched.Pop();

                pos[m]++;
                int mRank = pos[m];
                int w = AddWtoMPref(mRank, mPref[m]);

                int wRank = AddMtoWPref(m, wPref[w]);

                int m1 = wMatching[w];
   //             trace.Append(m + " proposes to " + w + " [" + w + "," + m1 + "]");

                if (wPrefers(m, m1, wPref[w])) {
                    wMatching[w] = m;
                    mMatching[m] = w;
                    if (m1 != -1) {
                        mMatching[m1] = -1;
                        unMatched.Push(m1);
                    }
   //                 trace.AppendLine("  Accepted");

                }
                else {
                    unMatched.Push(m);
     //               trace.AppendLine("  Rejected");
                }
            }

            trace.Matching = mMatching;
            trace.MRank = MRank(mMatching, mPref);
            trace.WRank = WRank(mMatching, wPref);

            if (n < 40) {
                trace.MPrefs = PrefsToString(mPref);
                trace.WPrefs = PrefsToString(wPref);
            }
        }

        private int AddWtoMPref(int rank, List<Pref> pList) {
            bool flag;
            int index;

            do {
                index = random.Next(n);
                flag = true;
                foreach (Pref p in pList)
                    if (index == p.Index)
                        flag = false;

            } while (!flag);

            pList.Add(new Pref(index, rank));
            return index;
        }

        private int AddMtoWPref(int index, List<Pref> pList) {
            bool flag;
            int rank;

            do {
                rank = random.Next(n);
                flag = true;
                foreach (Pref p in pList)
                    if (rank == p.Rank)
                        flag = false;

            } while (!flag);

            pList.Add(new Pref(index, rank));
            return rank;
        }

        bool wPrefers(int m1, int m2, List<Pref> pList) {

            if (m2 == -1) return true;

            return LookupRank(m1, pList) < LookupRank(m2, pList);
        }

        int LookupRank(int index, List<Pref> pList) {
            foreach (Pref p in pList) {
                if (p.Index == index)
                    return p.Rank;
            }
            return -1;
        }

        long MRank(int[] matching, List<Pref>[] pLists) {
            return Rank(matching, pLists);
        }

        long WRank(int[] matching, List<Pref>[] pLists) {
            return Rank(Algorithm.InvertPermutation(matching), pLists);
        }

        long Rank(int[] matching, List<Pref>[] pLists) {
            long rank = n;
            for (int i = 0; i < n; i++)
                rank += LookupRank(matching[i], pLists[i]);

            return rank;
        }

        string PrefsToString(List<Pref>[] pLists) {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++) {
                sb.Append("[" + i + "]: ");
                sb.Append(PrefsToString(pLists[i]));
                sb.Append("\r\n");
            }


            return sb.ToString();
        }

        string PrefsToString(List<Pref> pList) {
            StringBuilder sb = new StringBuilder();

            foreach (Pref p in pList)
                sb.Append("(" +p.Index + ", " + p.Rank + ") ");

            return sb.ToString();
        }
    }
}

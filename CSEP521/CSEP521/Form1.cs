using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSEP521 {
    public partial class Form1 : Form {

        Random random;
        StableMatching matchingInstance;

        public Form1() {
            InitializeComponent();
            Init();
        }

        private void Init() {
            random = new Random();
        }

        private void OnRunButtonClick(object sender, EventArgs e) {
            textBox1.Text = "Running";
        }

        private void OnPermuteClick(object sender, EventArgs e) {
            int n = (int) upDownN.Value;
            int[] arr = Algorithm.Permutation(n, random);
            textBox1.Text = Algorithm.ArrayToString(arr);
        }

        private void OnInitMatching(object sender, EventArgs e) {
            int n = (int)this.upDownN.Value;
            matchingInstance = new StableMatching(n);
            matchingInstance.InitRandom(random);


            textBox1.Text = matchingInstance.InstanceString();

        }

        private void OnProposeClick(object sender, EventArgs e) {
            Trace trace = new Trace(true);

            matchingInstance.GaleShapley(trace);


            String mString = "mMatching: " + Algorithm.ArrayToString(trace.Matching);
            String wString = "wMatching: " + Algorithm.ArrayToString(Algorithm.InvertPermutation(trace.Matching));




            textBox2.Text = mString + "\r\n" + wString + "\r\n" + RankString(trace);
            textBox3.Text = trace.Result;

        }

        private string RankString(Trace trace) {


            int n = trace.Matching.Length;


            return "MRank " + trace.MRank + " (" + ((float)trace.MRank) / n + ")  WRank " + trace.WRank + " (" + ((float)trace.WRank) / n + ")";

        }

        private void OnIterateClick(object sender, EventArgs e) {
            Trace trace = new Trace(true);
            int reps = (int)this.upDownReps.Value;
            int n = (int)this.upDownN.Value;

            if (n > 100)
                trace.Flag = false;

            matchingInstance = new StableMatching(n);

            long mRank = 0;
            long wRank = 0;
            string results = "";

            this.countTextBox.Text = "0";
            this.countTextBox.Refresh();

            for (int i = 0; i < reps; i++) {
                matchingInstance.InitRandom(random);
                matchingInstance.GaleShapley(trace);
                results += RankString(trace) + "\r\n";
                mRank += trace.MRank;
                wRank += trace.WRank;

                this.countTextBox.Text = i.ToString();
                this.countTextBox.Refresh();

            }

            this.countTextBox.Text = reps.ToString();

            textBox3.Text = results;
            float avgMRank = ((float)mRank) / (reps);
            float avgWRank = ((float)wRank) / (reps);

            textBox2.Text = "Avg MRank: " + avgMRank + " (" + avgMRank / n + ")  Avg WRank: " + avgWRank + " (" + avgWRank / n + ")";
        }

        private void OnBigPropClick(object sender, EventArgs e) {
            int n = (int)this.upDownN.Value;

            Trace trace = new Trace(true);
            if (n > 100)
                trace.Flag = false;

            IncrementalMatching instance = new IncrementalMatching(n, random);
            instance.GaleShapley(trace);


            String mString = "mMatching: " + Algorithm.ArrayToString(trace.Matching);
            String wString = "wMatching: " + Algorithm.ArrayToString(Algorithm.InvertPermutation(trace.Matching));


            textBox1.Text = trace.MPrefs + "\r\n\r\n" + trace.WPrefs;

            textBox2.Text = mString + "\r\n" + wString + "\r\n" + RankString(trace);
            textBox3.Text = trace.Result;

        }

        private void OnBigIterateClick(object sender, EventArgs e) {
            Trace trace = new Trace(true);
            int reps = (int)this.upDownReps.Value;
            int n = (int)this.upDownN.Value;
            if (n > 100)
                trace.Flag = false;

            IncrementalMatching instance = new IncrementalMatching(n, random);

            long mRank = 0;
            long wRank = 0;
            string results = "";

            this.countTextBox.Text = "0";
            this.countTextBox.Refresh();

            for (int i = 0; i < reps; i++) {
                
                instance.GaleShapley(trace);
                results += RankString(trace) + "\r\n";
                mRank += trace.MRank;
                wRank += trace.WRank;

                this.countTextBox.Text = i.ToString();
                this.countTextBox.Refresh();

            }

            this.countTextBox.Text = reps.ToString();

            textBox5.Text = results;
            float avgMRank = ((float)mRank) / (reps);
            float avgWRank = ((float)wRank) / (reps);

            textBox4.Text = "Avg MRank: " + avgMRank + " (" + avgMRank / n + ")  Avg WRank: " + avgWRank + " (" + avgWRank / n + ")";
        }

        private void OnGroupTableClick(object sender, EventArgs e) {
            int n = (int)this.upDownN.Value;


            Group group = new Group(n);

            textBox1.Text = group.GroupTable();
        }

        private void OnPowerTableClick(object sender, EventArgs e) {
            int n = (int)this.upDownN.Value;


            Group group = new Group(n);

            textBox1.Text = group.PowerTable();
        }


        private void TestFunctionClick(object sender, EventArgs e) {
            int n = (int)this.upDownN.Value;


            Group group = new Group(n);

            textBox1.Text = group.TestFunction();

        }
    }
}


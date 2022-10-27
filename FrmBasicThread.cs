using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moya_Threads
{
    public partial class FrmBasicThread : Form
    {
        Thread ThreadA, ThreadB;
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lblthread.Text = "-Before Starting Thread-";

            ThreadStart run = new ThreadStart(MyThreadClass.Thread1);
            ThreadA = new Thread(run);
            ThreadA.Name = "Thread A Process";
            ThreadB = new Thread(run);
            ThreadB.Name = "Thread B Process";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            if(!ThreadA.IsAlive && !ThreadB.IsAlive)
            {
                lblthread.Text = "-End of Thread-";

                Console.WriteLine(lblthread.Text);
            }
            

        }
    }
}

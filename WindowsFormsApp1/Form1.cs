using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }
        private Thread threadA, threadB, threadC, threadD;


        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart delthread1 = new ThreadStart(MyThreadClass.Thread1);
            ThreadStart delthread2 = new ThreadStart(MyThreadClass.Thread2);

            try
            {
                Console.WriteLine("-Thread Starts-");

                threadA = new Thread(delthread1);
                threadA.Name = "Thread A Process";

                threadB = new Thread(delthread2);
                threadB.Name = "Thread B Process";

                threadC = new Thread(delthread1);
                threadC.Name = "Thread C Process";

                threadD = new Thread(new ThreadStart(delthread2));
                threadD.Name = "Thread D Process";


                threadA.Priority = System.Threading.ThreadPriority.Highest;
                threadB.Priority = System.Threading.ThreadPriority.Normal;
                threadC.Priority = System.Threading.ThreadPriority.AboveNormal;
                threadD.Priority = System.Threading.ThreadPriority.BelowNormal;

                threadA.Start();
                threadB.Start();
                threadC.Start();
                threadD.Start();

                threadA.Join();
                threadB.Join();
                threadC.Join();
                threadD.Join();
            }

            catch (Exception ex)
            {
                MessageBox.Show(Text + " - " + ex.Message, "Exception");
            }

            finally
            {
                threadStarts.Text = "-End of Thread-";
                Console.WriteLine("-Thread Ends-");
            }
        }
    }
}

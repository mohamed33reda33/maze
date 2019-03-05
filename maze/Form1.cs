using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maze
{
    public partial class maze : Form
    {
        public maze()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void maze_Load(object sender, EventArgs e)
        {

        }

        //correct path function 
        void coPath()
        {
            
            // مصفوفة هخزن فيها المسار الصحيح
            int[] path = new int[256];
            path[0] = 1;

            for(int i=1;i<256;i++)
            {
                if (path[i] == 256) { break; }
                Random r = new Random();
                int rNum = r.Next(1,2);
                if (rNum == 2)
                {
                    rNum *= 8;
                    path[i] = path[i - 1] + rNum;
                }
                else
                {
                    path[i] = path[i - 1] + rNum;
                }
            }

            string str = string.Join("->", path);
            textBox1.Text = str;
        }
        // لما بضغط عليه بيستدعي دالة المسار الصحيح
        private void button258_Click(object sender, EventArgs e)
        {
            coPath();
        }
    }
}

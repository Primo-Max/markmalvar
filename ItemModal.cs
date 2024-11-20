using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sales
{
    public partial class ItemModal : Form
    {
        public ItemModal()
        {
            InitializeComponent();
        }
       
        private void Modal_Effect_Timer_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                Modal_Effect_Timer.Stop();

            }
            else
            {
                Opacity = 0.3;
            }

        }
        int i;
        private void ItemModal_Load(object sender, EventArgs e)
        {
           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static int parentX,parentY;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (ItemModal modal = new ItemModal())
            {
                
                modal.Owner = modalBackground;
                parentX = this.Location.X;
                parentY = this.Location.Y;

                modal.ShowDialog();
                modalBackground.Dispose();

            };
            
            


            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}

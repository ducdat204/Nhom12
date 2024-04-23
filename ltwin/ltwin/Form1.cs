using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ltwin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadMatrix();
        }
        void LoadMatrix()
        {
            for (int i = 0; i < 6; i++) 
            {
                for (int j = 0; j < 7; j++) 
                {
                    Button btn = new Button();
                    pnlMatrix.Controls.Add(btn);
                }
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

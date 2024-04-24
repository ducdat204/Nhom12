using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ltwin
{
    public partial class Form1 : Form
    {
        #region Peoperties
        private List< List<Button>> matrix;
        #endregion
        public Form1()
        {
            InitializeComponent();
            LoadMatrix();
        }
        void LoadMatrix()
        {
            Button oldBtn = new Button() { Width = 0,Height = 0, Location = new Point(-Cons.margin, 0)};
            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                for (int j = 0; j < Cons.DayOfWeek; j++) 
                {
                    Button btn = new Button() { Width = Cons.dateButtonWidth, Height = Cons.dateButtonHeight};
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);
                    pnlMatrix.Controls.Add(btn);
                    oldBtn = btn;

                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.dateButtonHeight)};
            }
            AddNumberIntoMatrixByDate(dtpkDate.Value);
        }
        void AddNumberIntoMatrixByDate(DateTime date);

     



    

      
    }
}

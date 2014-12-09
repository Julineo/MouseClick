using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MouseOperationsNS;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(100,100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MouseOperations Mouse = new MouseOperations(); --mouse only one, so this is works as an interface
            MouseOperationsNS.MouseOperations.SetCursorPosition(140, 140);
            MouseOperationsNS.MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
            MouseOperationsNS.MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click!");
        }
    }
}

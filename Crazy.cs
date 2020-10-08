using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crazy
{
    public delegate void Delegate1(object sender, EventArgs e);
    public partial class Crazy : Form
    {
        public Crazy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Text = "Click Me";
            button.Size = new Size(100, 50);
            button.Location = new Point(150, 100);
            this.Controls.Add(button);

            // button.Click += new EventHandler(button1_click1);
            button.Click += delegate (object sender1, EventArgs e1)
            {
                MessageBox.Show("Yeyy! This is Crazy");
            };

            button.Click += delegate (object sender2, EventArgs e2)
            {
                MessageBox.Show("Yeyy! This is priting Crazy");
            };
        }

        private void button1_click1(object sender,EventArgs e)
        {
            MessageBox.Show("Yeyy! this ic Crazy");
        }
    }
}

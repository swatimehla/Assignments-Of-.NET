using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace This_Is_Printing_Again
{
    public partial class Printing_Again : Form
    {
        public Printing_Again()
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
                MessageBox.Show("This is Printing Again");
            };

            button.Click += delegate (object sender2, EventArgs e2)
            {
                MessageBox.Show("Yeyy! This is Crazy");
            };
        }

        private void button_click1(object sender,EventArgs e)
        {
            MessageBox.Show("This is Printing Again");
        }
    }
}

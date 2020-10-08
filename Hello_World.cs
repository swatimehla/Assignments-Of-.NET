using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWORLD
{
    public delegate void MyDelegate(object sender, EventArgs e);
    public partial class Hello_World : Form
    {
        public Hello_World()
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
                MessageBox.Show("Hello World");
            };

            button.Click += delegate (object sender2, EventArgs e2)
            {
                MessageBox.Show("Programming is Fun");
            };
        }

        private void button1_click1(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

    }
}

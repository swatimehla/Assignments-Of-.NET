using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace This_is_Printing
{
    public delegate void MyDelegate(object sender, EventArgs e);
    public partial class This_Is_Printing : Form
    {
        public This_Is_Printing()
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
            button.Click += delegate (object sender1, EventArgs e1)
           {
               MessageBox.Show("This is Printing");
           };

            button.Click += delegate (object sender2, EventArgs e2)
             {
                 MessageBox.Show("This is Printing Again");
             };
        }
    }
}

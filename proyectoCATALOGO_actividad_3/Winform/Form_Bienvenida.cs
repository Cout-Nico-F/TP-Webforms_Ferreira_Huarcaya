using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class Form_Bienvenida : Form
    {
        public Form_Bienvenida()
        {
            InitializeComponent();
        }

        private void tm_1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 1;
            } 
            pb_Carga.Value += 2;
            lbl_Carga.Text = pb_Carga.Value + "%";
            if (pb_Carga.Value == 100)
            {
                tm_1.Stop();
                tm_2.Start();
            }
        }

        private void tm_2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 1;
            if(this.Opacity == 0)
            {
                tm_2.Stop();
            }
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            Close();
        }

        private void Form_Bienvenida_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            tm_1.Start();
        }
    }
}

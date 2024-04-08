using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retroalimentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "texto de ejemplo"+Environment.NewLine;
            animal animal1 = new animal("gato", 4, "domestico");
            textBox1.Text += animal1.informacion() + Environment.NewLine;
            textBox1.Text += animal1.informacion(25.8) + Environment.NewLine;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnaPruebaMas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BIntroducir_Click(object sender, EventArgs e)
        {
            int num;

            //prueba de usuario 2
            num = int.Parse(tbIntroducir.Text);

            tbRESULTADO.Text = num.ToString();
        }
    }
}

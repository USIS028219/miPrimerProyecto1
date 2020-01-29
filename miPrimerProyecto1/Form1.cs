using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimerProyecto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {
            sbyte Num1 = sbyte.Parse(TxtNum1.Text);
            sbyte Num2 = sbyte.Parse(TxtNum2.Text);

            LblRespuesta.Text = "Respuesta: " + (Num1 + Num2);

        }
    }
}

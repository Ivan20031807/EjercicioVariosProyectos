using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LlamandoDesdeWin
{
    public partial class FrmLlamadodesdeWindows : Form
    {
        public FrmLlamadodesdeWindows()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            BibliotecaDeFunciones.Operaciones ob1 = new BibliotecaDeFunciones.Operaciones();
            double num1 = Convert.ToDouble(txtsumarnumero.Text);
            double num2 = Convert.ToDouble(txtssegundonumero.Text);
            int Fac = Convert.ToInt32(txtfactorial.Text);
            double x1 = ob1.suma(num1, num2);
            double fac = ob1.factorial(Fac);
            this.txtsumaresultado.Text = x1.ToString();
            this.txtfactorialresultado.Text = fac.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microsell_Lite.Productos
{
    public partial class Frm_Explo_Prod : Form
    {
        public Frm_Explo_Prod()
        {
            InitializeComponent();
        }

        private void Frm_Explo_Prod_Load(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnl_titu_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitario obj = new Utilitario();

            if (e.Button ==MouseButtons.Left)
            {
                obj.Mover_formulario(this);

            }
        }
    }
}

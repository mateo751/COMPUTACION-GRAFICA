using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_15_11_22
{
    public partial class frmVectores : Form
    {
        
        ClasVector ObjVector =  new ClasVector(0,0);
        
        public frmVectores()
        {
            InitializeComponent();
        }

        private void btnDibujarEje_Click(object sender, EventArgs e)
        {
            ObjVector.DrawPlano(picCanvas);
        }

        private void btnDibujarVector_Click(object sender, EventArgs e)
        {

            ObjVector.ReadData(numX, numY);
            ObjVector.DrawVector(ObjVector, Color.Blue, picCanvas);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bodega
{
    
    public partial class Form2 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
            TxFecha.Text = DateTime.Now.ToString();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BtRegistros_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registros registro = new Registros();
            registro.Show();
        }
        

        private void BtCajaC_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CajaChica caja = new CajaChica();
            caja.Show();
        }

        private void BtEgresos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Egresos egreso = new Egresos();
            egreso.Show();
        }

        private void BtCon_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaEdicion consulta = new ConsultaEdicion();
            consulta.Show();

        }

        private void BtReporte_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reportes reporte = new Reportes();
            reporte.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 inicio = new Form1();
            inicio.Show();
        }

        private void TxFecha_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}

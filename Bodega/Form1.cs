using System;

using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Bodega
{
    
    public partial class Form1 : Form
    {
        //Conectamos a la Base de datos
        BaseDeDatos bd = new BaseDeDatos();

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



        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void pictureBox2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = bd.selectstring("select nombreusuario from usuario where nombreusuario = '" + TxUsuario.Text + "'");
            string contraseña = bd.selectstring("select contraseña from usuario where contraseña = '" + TxContraseña.Text + "'");

            if (TxUsuario.TextLength > 0 && TxContraseña.TextLength > 0)
            {
                if (usuario == TxUsuario.Text && contraseña == TxContraseña.Text)
                {
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Alguno de los campos son incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Llene los campos correspondientes para acceder");
            }
            /*this.Hide();
            Form2 form = new Form2();
            form.Show();*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
  
}

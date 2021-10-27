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
using System.Data.SqlClient;

namespace Bodega
{
    public partial class Registros : Form
    {
        //Inicializacion Base de datos
        BaseDeDatos bd = new BaseDeDatos();
        SqlConnection cn = new SqlConnection(@"Data Source=localhost;initial catalog=INTECAP;Integrated Security=True");


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

        private void Registros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iNTECAPDataSet1.tipounidad' Puede moverla o quitarla según sea necesario.
            //this.tipounidadTableAdapter.Fill(this.iNTECAPDataSet1.tipounidad); CREO QUE NO SE USA, LO COMENTÉ Y NO PASO NADA
            // TODO: esta línea de código carga datos en la tabla 'iNTECAPDataSet1.registroingreso' Puede moverla o quitarla según sea necesario.
            this.registroingresoTableAdapter.Fill(this.iNTECAPDataSet1.registroingreso);
            //dataGridView1.DataSource = bd.SelectDataTable("Select * from dbo.registroingreso");
            dataGridView1.DataSource = bd.SelectDataTable("SELECT r.id, r.nombre, r.cantidad, r.fecha ,e.nombre as 'Tipo de unidad' FROM registroingreso r INNER JOIN tipounidad e ON e.id = r.tipounidad_id");
            
        }
        public Registros()
        {
            InitializeComponent();
            CargarDatos();
            timer1.Start();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
            CBTipoUnidad.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        public void CargarDatos()
        {

            SqlCommand cmd = new SqlCommand("SELECT nombre from dbo.tipounidad", cn);
            cn.Open();
            SqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read())
            {
                CBTipoUnidad.Items.Add(registro["nombre"].ToString());
                // CNombre.SelectedIndex = int.Parse(registro["id"].ToString());
            }
            cn.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtRegistros_Click(object sender, EventArgs e)
        {

        }

        private void BtCajaC_Click(object sender, EventArgs e)
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
            Form1 login = new Form1();
            login.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        Boolean datoC = false;

        public void corroborar()
        {
            
            cn.Open();
            string buscar = "select nombre from dbo.registroingreso where nombre = '" + (txtNombre.Text) + "'; ";
            SqlCommand sqlcmd = new SqlCommand(buscar, cn);
            if (sqlcmd.ExecuteScalar() == null)
            {
                datoC = false;
            }
            else
            {
                string Rcantidad = sqlcmd.ExecuteScalar().ToString();
                datoC = true;
            }
            cn.Close();
              
        }

        string tipoID;

        public void UnidadID()
        {
            cn.Open();
            string buscar = "select tipounidad_id from dbo.registroingreso where nombre = '" + (txtNombre.Text) + "'; ";
            SqlCommand sqlcmd = new SqlCommand(buscar, cn);
            if (sqlcmd.ExecuteScalar() == null)
            {
            }
            else
            {
                tipoID = sqlcmd.ExecuteScalar().ToString();
            }
            cn.Close();
        }

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            corroborar();
            if (datoC == true)
            {
                UnidadID();
                string actualizar = "update dbo.registroingreso set cantidad = (cantidad + " + (Convert.ToInt32(txtCantidad.Text)) + ") where nombre = '" + (txtNombre.Text) + "'; " +
                    "update dbo.registroingreso set fecha = '"+ dateTimePicker1.Text +"' where nombre = '" + (txtNombre.Text) + "'; " +
                    "insert into dbo.historialingreso values ('" + txtNombre.Text + "' , " + txtCantidad.Text + " , '" + dateTimePicker1.Text + "' , " + tipoID + ");";
                if (bd.executecommand(actualizar))
                {
                    MessageBox.Show("Registro actualizado correctamente");

                    //dataGridView1.DataSource = bd.SelectDataTable("Select * from dbo.registroingreso");
                    dataGridView1.DataSource = bd.SelectDataTable("SELECT r.id, r.nombre, r.cantidad, r.fecha, e.nombre as 'Tipo de unidad' FROM registroingreso r INNER JOIN tipounidad e ON e.id = r.tipounidad_id");
                    CBTipoUnidad.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Error al actualizar");
                }
            }
            else
            {
                try
                {

                    string agregar = "insert into dbo.registroingreso values ('" + txtNombre.Text + "' , " + txtCantidad.Text + " , '" + dateTimePicker1.Text + "' , " + (CBTipoUnidad.SelectedIndex + 1) + ");" +
                        "insert into dbo.historialingreso values('" + txtNombre.Text + "' , " + txtCantidad.Text + " , '" + dateTimePicker1.Text + "' , " + (CBTipoUnidad.SelectedIndex + 1) + "); ";
                    if (bd.executecommand(agregar))
                    {
                        MessageBox.Show("Registro agregado correctamente");
                        //dataGridView1.DataSource = bd.SelectDataTable("Select * from dbo.registroingreso");
                        dataGridView1.DataSource = bd.SelectDataTable("SELECT r.id, r.nombre, r.cantidad, r.fecha ,e.nombre as 'Tipo de unidad' FROM registroingreso r INNER JOIN tipounidad e ON e.id = r.tipounidad_id");
                        CBTipoUnidad.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar");
                    }
                }
                catch
                {
                    MessageBox.Show("Error" + e);
                }
                txtCantidad.Clear();
                txtNombre.Text = "";
                this.Hide();
                Registros registro = new Registros();
                registro.Show();
            }

        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

<<<<<<< HEAD
        private void TxFecha_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
=======
        private void CBTipoUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {

>>>>>>> ded203d ("reporte")
        }
    }
}

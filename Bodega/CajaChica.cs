using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bodega
{
    public partial class CajaChica : Form
    {
        public CajaChica()
        {
            InitializeComponent();
            CargarDatos();
            timer1.Start();
            CBTipoUnidad.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        BaseDeDatos bd = new BaseDeDatos();
        SqlConnection cn = new SqlConnection(@"Data Source=localhost;initial catalog=INTECAP;Integrated Security=True");


        private void CajaChica_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iNTECAPDataSet1.registrocajachica' Puede moverla o quitarla según sea necesario.
            this.registrocajachicaTableAdapter.Fill(this.iNTECAPDataSet1.registrocajachica);

            //dataGridView1.DataSource = bd.SelectDataTable("Select P.id, P.nombre, P.cantidad, P.fecha, P.tipounidad_id from dbo.registrocajachica P");
            dataGridView1.DataSource = bd.SelectDataTable("SELECT r.id, r.nombre, r.cantidad, r.fecha, e.nombre as 'Tipo de unidad' FROM registrocajachica r INNER JOIN tipounidad e ON e.id = r.tipounidad_id");

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

        private void BtIngresos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registros registro = new Registros();
            registro.Show();
        }

        private void BtCajaC_Click(object sender, EventArgs e)
        {

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

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {

        }

        string tipoID;

        public void UnidadID()
        {
            cn.Open();
            string buscar = "select tipounidad_id from dbo.registrocajachica where nombre = '" + (txtNombre.Text) + "'; ";
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

        Boolean datoC = false;

        public void corroborar()
        {

            cn.Open();
            string buscar = "select nombre from dbo.registrocajachica where nombre = '" + (txtNombre.Text) + "'; ";
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

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            corroborar();
            if (datoC == true)
            {
                UnidadID();
                string actualizar = "update dbo.registrocajachica set cantidad = (cantidad + " + (Convert.ToInt32(txtCantidad.Text)) + ") where nombre = '" + (txtNombre.Text) + "'; " +
                    "update dbo.registrocajachica set fecha = '" + dateTimePicker1.Text + "' where nombre = '" + (txtNombre.Text) + "'; " +
                    "insert into dbo.historialcajachica values ('" + txtNombre.Text + "' , " + txtCantidad.Text + " , '" + dateTimePicker1.Text + "' , " + tipoID + ");";
                if (bd.executecommand(actualizar))
                {
                    MessageBox.Show("Registro actualizado correctamente");

                    //dataGridView1.DataSource = bd.SelectDataTable("Select * from dbo.registrocajachica");
                    dataGridView1.DataSource = bd.SelectDataTable("SELECT r.id, r.nombre, r.cantidad, r.fecha, e.nombre as 'Tipo de unidad' FROM registrocajachica r INNER JOIN tipounidad e ON e.id = r.tipounidad_id");
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

                    string agregar = "insert into dbo.registrocajachica values ('" + txtNombre.Text + "' , " + txtCantidad.Text + " , '" + dateTimePicker1.Text + "' , " + (CBTipoUnidad.SelectedIndex + 1) + ");" +
                        "insert into dbo.historialcajachica values('" + txtNombre.Text + "' , " + txtCantidad.Text + " , '" + dateTimePicker1.Text + "' , " + (CBTipoUnidad.SelectedIndex + 1) + "); ";
                    if (bd.executecommand(agregar))
                    {
                        MessageBox.Show("Registro agregado correctamente");
                        //dataGridView1.DataSource = bd.SelectDataTable("Select P.id, P.nombre, P.cantidad, P.fecha, P. from dbo.registrocajachica P");
                        dataGridView1.DataSource = bd.SelectDataTable("SELECT r.id, r.nombre, r.cantidad, r.fecha, e.nombre as 'Tipo de unidad' FROM registrocajachica r INNER JOIN tipounidad e ON e.id = r.tipounidad_id");
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
                CajaChica caja = new CajaChica();
                caja.Show();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CBTipoUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxFecha_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void txtNombreMAYUSCULAS(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}

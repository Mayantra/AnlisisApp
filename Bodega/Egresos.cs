using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bodega
{
    public partial class Egresos : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        SqlConnection cn = new SqlConnection(@"Data Source=localhost;initial catalog=INTECAP;Integrated Security=True");
        
        private void Egresos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iNTECAPDataSet1.area' Puede moverla o quitarla según sea necesario.
            this.areaTableAdapter.Fill(this.iNTECAPDataSet1.area);
            // TODO: esta línea de código carga datos en la tabla 'iNTECAPDataSet1.taller' Puede moverla o quitarla según sea necesario.
            this.tallerTableAdapter.Fill(this.iNTECAPDataSet1.taller);
            autocompletar();
        }

        public Egresos()
        {
            InitializeComponent();
            //autocompletar();
            timer1.Start();
            TxFecha.Text = DateTime.Now.ToString();
            CTaller.DropDownStyle = ComboBoxStyle.DropDownList;
            CBTablas.DropDownStyle = ComboBoxStyle.DropDownList;
            CArea.DropDownStyle = ComboBoxStyle.DropDownList;
            CArticulo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void Seleccionar()
        {
            String dato = CBTablas.Text;
            if (dato == "Caja_Chica")
            {
                CArticulo.Items.Clear();
                CargarDatos();
            }
            if (dato == "Ingresos")
            {
                CArticulo.Items.Clear();
                CargarDatos2();
            }


        }

        public void CargarDatos()
        {

            SqlCommand cmd = new SqlCommand("SELECT id, nombre from dbo.registrocajachica", cn);
            cn.Open();
            SqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read())
            {
                CArticulo.Items.Add(registro["nombre"].ToString());
            }
            cn.Close();

        }

        public void CargarDatos2()
        {

            SqlCommand cmd = new SqlCommand("SELECT id, nombre from dbo.registroingreso", cn);
            cn.Open();
            SqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read())
            {
                CArticulo.Items.Add(registro["nombre"].ToString());
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
            this.Hide();
            CajaChica caja = new CajaChica();
            caja.Show();
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

        private void CNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CBTablas.SelectedIndex == 0)
                {
                    cn.Open();
                    string cantidad = "select cantidad from dbo.registrocajachica where nombre = '" + (CArticulo.Text) + "'; ";
                    SqlCommand sqlcmd = new SqlCommand(cantidad, cn);
                    int Rcantidad = Convert.ToInt32(sqlcmd.ExecuteScalar());
                    cn.Close();
                    txtExistencia.Text = Rcantidad.ToString();
                }
                if (CBTablas.SelectedIndex == 1)
                {
                    cn.Open();
                    string cantidad = "select cantidad from dbo.registroingreso where nombre = '" + (CArticulo.Text) + "'; ";
                    SqlCommand sqlcmd = new SqlCommand(cantidad, cn);
                    int Rcantidad = Convert.ToInt32(sqlcmd.ExecuteScalar());
                    cn.Close();
                    txtExistencia.Text = Rcantidad.ToString();
                }

            }
            catch (Exception)
            {

                throw;
            }


        }


        private void CBTablas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Seleccionar();
            txtExistencia.Clear();
        }

        List<String> arrayFecha = new List<string>();
        List<String> arrayReceptor = new List<string>();
        List<String> arrayTaller = new List<string>();
        List<String> arrayArea = new List<string>();
        List<String> arrayTabla = new List<string>();
        List<int> arrayIdTabla = new List<int>();
        List<String> arrryArticulo = new List<string>();
        List<String> arrayObservaciones = new List<string>();
        List<int> arrayIdArticulo = new List<int>();
        List<int> cantidad = new List<int>();

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            if (txtExistencia.Text == "")
            {
                MessageBox.Show("Por favor seleccione una tabla");
            }
            else if (txtReceptor.Text == "")
            {
                MessageBox.Show("Por favor, llene el campo de Receptor");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Por favor, llene el campo de Cantidad");
            }
            else
            {
                if (txtExistencia.TextLength > 0)
                {
                    arrayFecha.Add(FEgreso.Text);
                    arrayReceptor.Add(txtReceptor.Text);
                    arrayTaller.Add(CTaller.Text);
                    arrayArea.Add(CArea.Text);
                    arrayTabla.Add(CBTablas.Text);
                    arrayIdTabla.Add(CBTablas.SelectedIndex);
                    arrryArticulo.Add(CArticulo.Text);
                    arrayObservaciones.Add(RcObservaciones.Text);
                    arrayIdArticulo.Add(CArticulo.SelectedIndex + 1);
                    cantidad.Add(int.Parse(textBox2.Text));
                    mostrarDatos();
                    textBox2.Clear();
                }

                else
                {
                    MessageBox.Show("No hay existencias del articulo seleccionado");
                }
            }
        }

        public void mostrarDatos()
        {
            try
            {
                int n = dataGridViewTablas.Rows.Add();
                dataGridViewTablas.Rows[n].Cells[0].Value = arrayFecha[n];
                dataGridViewTablas.Rows[n].Cells[1].Value = arrayReceptor[n];
                dataGridViewTablas.Rows[n].Cells[2].Value = arrayTaller[n];
                dataGridViewTablas.Rows[n].Cells[3].Value = arrayArea[n];
                dataGridViewTablas.Rows[n].Cells[4].Value = arrayTabla[n];
                dataGridViewTablas.Rows[n].Cells[5].Value = arrryArticulo[n];
                dataGridViewTablas.Rows[n].Cells[6].Value = arrayObservaciones[n];
                dataGridViewTablas.Rows[n].Cells[7].Value = cantidad[n];

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewTablas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CTaller_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string agregarEgreso = "insert into dbo.egresos values ('" + txtReceptor.Text + "' , '" + FEgreso.Text + "' ,  '" + RcObservaciones.Text + "' , " + (CTaller.SelectedIndex + 1) + " , " + (CArea.SelectedIndex + 1) + ");";
                if (bd.executecommand(agregarEgreso))
                {
                    MessageBox.Show("Registro agregado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al agregar");
                }

                cn.Open();
                string datoEgreso = "select max(id) from dbo.egresos;";

                SqlCommand sqlcmd = new SqlCommand(datoEgreso, cn);
                int idEgreso = Convert.ToInt32(sqlcmd.ExecuteScalar());

                cn.Close();
                for (int i = 0; i < arrayIdTabla.Count; i++)
                {
                    if (arrayIdTabla[i] == 1)
                    {
                        cn.Open();
                        string consultaID = "select id from dbo.registroingreso where nombre = '" + arrryArticulo[i] + "';";

                        SqlCommand cmdC = new SqlCommand(consultaID, cn);
                        int idIngreso = Convert.ToInt32(cmdC.ExecuteScalar());

                        cn.Close();
                        string agregareingreso_egresos = "insert into dbo.ingreso_egresos values ('" + idEgreso + "', " + idIngreso + ", " + cantidad[i] + ");";
                        if (bd.executecommand(agregareingreso_egresos))
                        {
                            //MessageBox.Show("Registro agregado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar");
                        }
                    }

                    else if (arrayIdTabla[i] == 0)
                    {
                        cn.Open();
                        string consultaID = "select id from dbo.registrocajachica where nombre = '" + arrryArticulo[i] + "';";

                        SqlCommand cmdC = new SqlCommand(consultaID, cn);
                        int idIngreso = Convert.ToInt32(cmdC.ExecuteScalar());

                        cn.Close();
                        string agregaregresos_chica = "insert into dbo.cajachica_egresos values ('" + idEgreso + "', " + idIngreso + ", " + cantidad[i] + ");";
                        if (bd.executecommand(agregaregresos_chica))
                        {
                            //MessageBox.Show("Registro agregado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar");
                        }
                    }


                }
                MessageBox.Show("Registro agregado correctamente en las tablas");
                for (int i = 0; i < arrayIdTabla.Count; i++)
                {
                    if (arrayIdTabla[i] == 0)
                    {
                        string actualizarCaja = "update dbo.registrocajachica set cantidad = (cantidad - " + cantidad[i] + ") where nombre = '" + (arrryArticulo[i]) + "'; ";
                        if (bd.executecommand(actualizarCaja))
                        {
                            //MessageBox.Show("Registro agregado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar");
                        }
                    }
                    if (arrayIdTabla[i] == 1)
                    {
                        string actualizarCaja = "update dbo.registroingreso set cantidad = (cantidad - " + cantidad[i] + ") where nombre = '" + (arrryArticulo[i]) + "'; ";
                        if (bd.executecommand(actualizarCaja))
                        {
                            //MessageBox.Show("Registro agregado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar");
                        }
                    }
                }

            }
            catch
            {
                MessageBox.Show("Error" + e);
            }

            arrayFecha.Clear();
            arrayReceptor.Clear();
            arrayTaller.Clear();
            arrayArea.Clear();
            arrayTabla.Clear();
            arrayIdTabla.Clear();
            arrryArticulo.Clear();
            arrayObservaciones.Clear();
            arrayIdArticulo.Clear();
            cantidad.Clear();
            dataGridViewTablas.Rows.Clear();


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Egresos egreso = new Egresos();
            egreso.Show();
        }

        private void TxFecha_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        DataTable datos = new DataTable();
        void autocompletar()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM receptor", cn);
            adaptador.Fill(datos);

            for (int i = 0; i < datos.Rows.Count; i++)
            {
                lista.Add(datos.Rows[i]["nombreR"].ToString());
            }
            txtReceptor.AutoCompleteCustomSource = lista;
        }
    }
}

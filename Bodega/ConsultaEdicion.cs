using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bodega
{
    public partial class ConsultaEdicion : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        SqlConnection cn = new SqlConnection(@"Data Source=localhost;initial catalog=INTECAP;Integrated Security=True");

        public ConsultaEdicion()
        {
            InitializeComponent();
            timer1.Start();
            cbxTablas.DropDownStyle = ComboBoxStyle.DropDownList;
            TxFecha.Text = DateTime.Now.ToString();
            btnEditar.Enabled = false;
            btnRegistrar.Enabled = false;
            btnVer.Enabled = false;
        }

        private void ConsultaEdicion_Load(object sender, EventArgs e)
        {
            
        }

        private void BtIngresos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registros ingresos = new Registros();
            ingresos.Show();
        }       

       
        private void BtReporte_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reportes reporte = new Reportes();
            reporte.Show();
        }

        private void BtCajaC_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CajaChica caja = new CajaChica();
            caja.Show();
        }

        private void BtEgresos_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Egresos egresos = new Egresos();
            egresos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void BtSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtCon_Click_1(object sender, EventArgs e)
        {

        }

        private void BtMostrar_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = bd.SelectDataTable("Select P.id, P.nombre, P.cantidad, P.fecha, P.tipounidad_id from dbo.registrocajachica P");
            switch (cbxTablas.SelectedIndex)
            {
                case 0: dataGridView1.DataSource = bd.SelectDataTable("SELECT r.id, r.nombre, r.cantidad, r.fecha ,e.nombre as 'tipo de unidad' FROM registroingreso r " +
                    "INNER JOIN tipounidad e ON e.id = r.tipounidad_id ; ");//modifica nombre
                    btnEditar.Enabled = false;
                    btnRegistrar.Enabled = false;
                    btnVer.Enabled = true;
                    break;

                case 1: dataGridView1.DataSource = bd.SelectDataTable("SELECT r.id, r.nombre, r.cantidad, r.fecha ,e.nombre as 'tipo de unidad' FROM registrocajachica r " +
                    "INNER JOIN tipounidad e ON e.id = r.tipounidad_id ; ");//modifica nombre
                    btnEditar.Enabled = false;
                    btnVer.Enabled = true;
                    btnRegistrar.Enabled = false;
                    break;

                case 2: dataGridView1.DataSource = bd.SelectDataTable("SELECT r.id, r.receptor, r.fecha,r.observaciones, t.nombre as 'taller', a.nombre as 'area' " +
                    "FROM egresos r INNER JOIN area a ON r.area_id = a.id INNER JOIN taller t ON r.taller_id = t.id ; ");
                    btnEditar.Enabled = false;
                    btnRegistrar.Enabled = false;
                    btnObtener.Enabled = false;
                    btnVer.Enabled = true;
                    break;

                case 3: dataGridView1.DataSource = bd.SelectDataTable("Select * from dbo.taller ;");//si modifica
                    btnEditar.Enabled = false;
                    btnVer.Enabled = false;
                    btnRegistrar.Enabled = true;
                    break;

                case 4: dataGridView1.DataSource = bd.SelectDataTable("Select * from dbo.area ;");//si modifica
                    btnVer.Enabled = false;
                    btnEditar.Enabled = false;
                    btnRegistrar.Enabled = true;
                    break;

                case 5: dataGridView1.DataSource = bd.SelectDataTable("Select * from dbo.tipounidad ;");//si modifica
                    btnVer.Enabled = false;
                    btnRegistrar.Enabled = true;
                    btnEditar.Enabled = false;
                    break;

                case 6:
                    dataGridView1.DataSource = bd.SelectDataTable("SELECT r.id, r.nombre, r.cantidad, r.fecha ,e.nombre as 'tipo de unidad' FROM historialingreso r " +
                        "INNER JOIN tipounidad e ON e.id = r.tipounidad_id ; ");
                    btnRegistrar.Enabled = false;
                    btnVer.Enabled = true;
                    btnEditar.Enabled = false;
                    btnObtener.Enabled = false;
                    break;

                case 7:
                    dataGridView1.DataSource = bd.SelectDataTable("SELECT r.id, r.nombre, r.cantidad, r.fecha ,e.nombre as 'tipo de unidad' FROM historialcajachica r " +
                        "INNER JOIN tipounidad e ON e.id = r.tipounidad_id ; ");
                    btnRegistrar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnVer.Enabled = true;
                    btnObtener.Enabled = false;
                    break;

                default:
                    break;
            }
        }

        Boolean datoC = false;

        public void corroborar(string tabla)
        {
           
            cn.Open();
            string buscar = "select nombre from dbo."+ tabla +" where nombre = '" + (txtNombre.Text) + "'; ";
            SqlCommand sqlcmd = new SqlCommand(buscar, cn);
            if (sqlcmd.ExecuteScalar() == null)
            {
                datoC = true;
            }
            else
            {
                datoC = false;
                MessageBox.Show("No se puede registrar mas de un dato existente");
            }
            cn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //case 3,4,5
            if(txtNombre.Text == "")
            {
                MessageBox.Show("El campo nombre esta vacío");
            }
            else
            {
                switch (cbxTablas.SelectedIndex)
                {
                    case 3:
                        corroborar("taller");
                        if (datoC == true)
                        {
                            string actualizar = "insert into dbo.taller values ('" + txtNombre.Text + "');";
                            if (bd.executecommand(actualizar))
                            {
                                MessageBox.Show("Registro agregado correctamente");

                                dataGridView1.DataSource = bd.SelectDataTable("Select * from dbo.taller");
                            }
                            else
                            {
                                MessageBox.Show("Error al registrar");
                            }
                        }
                        break;

                    case 4:
                        corroborar("area");
                        if (datoC == true)
                        {
                            string actualizar = "insert into dbo.area values ('" + txtNombre.Text + "');";
                            if (bd.executecommand(actualizar))
                            {
                                MessageBox.Show("Registro agregado correctamente");

                                dataGridView1.DataSource = bd.SelectDataTable("Select * from dbo.area");
                            }
                            else
                            {
                                MessageBox.Show("Error al registrar");
                            }
                        }
                        break;

                    case 5:
                        corroborar("tipounidad");
                        if (datoC == true)
                        {
                            string actualizar = "insert into dbo.tipounidad values ('" + txtNombre.Text + "');";
                            if (bd.executecommand(actualizar))
                            {
                                MessageBox.Show("Registro agregado correctamente");

                                dataGridView1.DataSource = bd.SelectDataTable("Select * from dbo.tipounidad");
                            }
                            else
                            {
                                MessageBox.Show("Error al registrar");
                            }
                        }
                        break;

                    default:
                        break;
                }
            }
            
            txtNombre.Clear();
        }

       
        public void ObtenerID(string tabla)
        {
           
            cn.Open();
            string buscar = "select nombre from dbo." + tabla + " where id = '" + (Convert.ToInt32(txtID.Text)) + "'; ";
            SqlCommand sqlcmd = new SqlCommand(buscar, cn);
            if (sqlcmd.ExecuteScalar() == null)
            {
                datoC = false;
                MessageBox.Show("No se encontro el identificador, por favor ingrese un identificador valido");
            }
            else
            {
                datoC = true;
                string NombreConsulta = sqlcmd.ExecuteScalar().ToString();
                txtNombre.Text = NombreConsulta;
            }
            cn.Close();
        }

        private void btnOptener_Click(object sender, EventArgs e)
        {
            btnRegistrar.Enabled = false;
            btnEditar.Enabled = true;
            switch (cbxTablas.SelectedIndex)
            {
                case 3: ObtenerID("taller");
                    break;

                case 4: ObtenerID("area");
                    break;

                case 5: ObtenerID("tipounidad");
                    break;
                default:
                    break;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnRegistrar.Enabled = true;
            switch (cbxTablas.SelectedIndex)
            {
                case 3:
                    
                    if (datoC == true)
                    {
                        string actualizar = "update dbo.taller set nombre = '" + txtNombre.Text + "' where id = '" + (Convert.ToInt32(txtID.Text)) + "';";
                        if (bd.executecommand(actualizar))
                        {
                            MessageBox.Show("Registro actualizado correctamente");

                            dataGridView1.DataSource = bd.SelectDataTable("Select * from dbo.taller");
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar");
                        }
                    }
                    break;

                case 4:
                    
                    if (datoC == true)
                    {
                        string actualizar = "update dbo.area set nombre = '" + txtNombre.Text + "' where id = '" + (Convert.ToInt32(txtID.Text)) + "';";
                        if (bd.executecommand(actualizar))
                        {
                            MessageBox.Show("Registro actualizado correctamente");

                            dataGridView1.DataSource = bd.SelectDataTable("Select * from dbo.area");
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar");
                        }
                    }
                    break;

                case 5:
                    
                    if (datoC == true)
                    {
                        string actualizar = "update dbo.tipounidad set nombre = '" + txtNombre.Text + "' where id = '" + (Convert.ToInt32(txtID.Text)) + "';";
                        if (bd.executecommand(actualizar))
                        {
                            MessageBox.Show("Registro actualizado correctamente");

                            dataGridView1.DataSource = bd.SelectDataTable("Select * from dbo.tipounidad");
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar");
                        }
                    }
                    break;

                default:
                    break;
            }
            txtID.Clear();
            txtNombre.Clear();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            switch (cbxTablas.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = bd.SelectDataTable("SELECT r.id, r.nombre, r.cantidad, r.fecha ,e.nombre as 'tipo de unidad' FROM registroingreso r " +
                "INNER JOIN tipounidad e ON e.id = r.tipounidad_id where fecha between '"+ dateTimePicker1.Text + "' and  '" + dateTimePicker2.Text + "'; ");//modifica nombre
                    
                    break;

                case 1:
                    dataGridView1.DataSource = bd.SelectDataTable("SELECT r.id, r.nombre, r.cantidad, r.fecha ,e.nombre as 'tipo de unidad' FROM registrocajachica r " +
                "INNER JOIN tipounidad e ON e.id = r.tipounidad_id where fecha between '" + dateTimePicker1.Text + "' and  '" + dateTimePicker2.Text + "'; ");//modifica nombre
                    
                    break;

                case 2:
                    dataGridView1.DataSource = bd.SelectDataTable("SELECT r.id, r.receptor, r.fecha,r.observaciones, t.nombre as 'taller', a.nombre as 'area' " +
                "FROM egresos r INNER JOIN area a ON r.area_id = a.id INNER JOIN taller t ON r.taller_id = t.id where fecha between '" + dateTimePicker1.Text + "' and  '" + dateTimePicker2.Text + "'; ");
                   
                    break;                

                case 6:
                    dataGridView1.DataSource = bd.SelectDataTable("SELECT r.id, r.nombre, r.cantidad, r.fecha ,e.nombre as 'tipo de unidad' FROM historialingreso r " +
                        "INNER JOIN tipounidad e ON e.id = r.tipounidad_id where fecha between '" + dateTimePicker1.Text + "' and  '" + dateTimePicker2.Text + "'; ");
                    
                    break;

                case 7:
                    dataGridView1.DataSource = bd.SelectDataTable("SELECT r.id, r.nombre, r.cantidad, r.fecha ,e.nombre as 'tipo de unidad' FROM historialcajachica r " +
                        "INNER JOIN tipounidad e ON e.id = r.tipounidad_id where fecha between '" + dateTimePicker1.Text + "' and  '" + dateTimePicker2.Text + "'; ");
                    
                    break;
                default:
                    break;
            }
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

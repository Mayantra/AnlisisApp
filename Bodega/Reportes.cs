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
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Bodega
{
    public partial class Reportes : Form
    {
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
        public Reportes()
        {
            InitializeComponent();
            timer1.Start();
            TxFecha.Text = DateTime.Now.ToString();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
            cbxTablas.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtIngresos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registros ingresos = new Registros();
            ingresos.Show();
        }

        private void BtCajaC_Click(object sender, EventArgs e)
        {
            this.Hide();
            CajaChica cajachica = new CajaChica();
            cajachica.Show();
        }

        private void BtEgresos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Egresos egresos = new Egresos();
            egresos.Show();
        }

        private void BtCon_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaEdicion consulta = new ConsultaEdicion();
            consulta.Show();
        }

        private void BtReporte_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        private void TxFecha_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Reporte de " + dateTimePicker1.Text + " A " + dateTimePicker2.Text + " " + cbxTablas.Text + ".pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Documento Guardado Exitosamente");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se pudo Guardar el Documento");
            }
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            try
            {

                if (cbxTablas.Text == "EGRESOS DE CAJA CHICA")
                {
                    dataGridView1.DataSource = bd.SelectDataTable("SELECT i.nombre as 'Articulo', c.cantidad, e.receptor,e.fecha,e.observaciones, a.nombre as 'Area', t.nombre as 'Taller' " +
                        " FROM cajachica_egresos c INNER JOIN egresos e ON e.id=egresos_id INNER JOIN registrocajachica i ON i.id=registrocajachica_id " +
                        " INNER JOIN area a ON a.id=e.area_id INNER JOIN taller t ON t.id=e.taller_id" +
                        " where e.fecha between  '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "';");

                }
                else
                {
                    if (cbxTablas.Text == "EGRESOS DE INGRESOS")
                    {
                        dataGridView1.DataSource = bd.SelectDataTable("SELECT i.nombre as 'Articulo', c.cantidad, e.receptor,e.fecha,e.observaciones, a.nombre as 'Area', t.nombre as 'Taller' " +
                            " FROM ingreso_egresos c INNER JOIN egresos e ON e.id=egresos_id INNER JOIN registroingreso i ON i.id=registroingreso_id INNER JOIN area a ON a.id=e.area_id INNER JOIN taller t ON t.id=e.taller_id" +
                            " where e.fecha between  '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "';");

                    }
                    else
                    {
                        if (cbxTablas.Text == "HISTORIAL DE INGRESOS DE CAJA CHICA")
                        {
                            dataGridView1.DataSource = bd.SelectDataTable(" SELECT  b.id,b.nombre,b.cantidad,b.fecha, t.nombre as 'Tipo de Unidad' FROM historialcajachica b Inner join tipounidad t ON t.id=b.tipounidad_id " +
                                "where b.fecha between  '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "';");

                        }
                        else
                        {
                            if (cbxTablas.Text == "HISTORIAL DE INGRESOS")
                            {
                                dataGridView1.DataSource = bd.SelectDataTable("SELECT  b.id,b.nombre,b.cantidad,b.fecha, t.nombre as 'Tipo de Unidad' FROM historialingreso b Inner join tipounidad t ON t.id=b.tipounidad_id " +
                                    " where b.fecha between  '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "';");

                            }
                            else
                            {
                                if (cbxTablas.Text == "INVENTARIO DE CAJACHICA")
                                {
                                    dataGridView1.DataSource = bd.SelectDataTable("SELECT rc.id, rc.nombre, rc.cantidad, rc.fecha, t.nombre FROM registrocajachica rc INNER JOIN tipounidad t ON t.id=rc.tipounidad_id " +
                                        "where rc.fecha between  '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "';");

                                }
                                else
                                {
                                    if (cbxTablas.Text == "INVENTARIO DE EGRESOS")
                                    {
                                        dataGridView1.DataSource = bd.SelectDataTable("SELECT ri.id, ri.nombre, ri.cantidad, ri.fecha, t.nombre FROM registroingreso ri INNER JOIN tipounidad t ON t.id=ri.tipounidad_id " +
                                            " where ri.fecha between  '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "';");

                                    }
                                }
                            }
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("Error" + e);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            String nombre_copia= "Bd_INTECAP Fecha " + DateTime.Now.ToString("dd_MM_yyyy") + " Hora " + DateTime.Now.ToString("hh_mm_ss");
            string comando_consulta = "BACKUP DATABASE [INTECAP] TO  DISK = N'C:\\BackupIntecap\\"+ nombre_copia + ".bak' WITH NOFORMAT, NOINIT,  NAME = N'INTECAP-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10 ";
            SqlCommand cmd = new SqlCommand(comando_consulta, cn);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("La copia ha sido creada Satisfactoriamente");
            }
            catch
            {
                MessageBox.Show("Error, Ruta no encontrada");
            }
        }
    }
}

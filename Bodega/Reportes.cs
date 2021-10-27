using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bodega
{
    public partial class Reportes : Form
    {

        //Inicializacion Base de datos
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
        public Reportes()
        {
            InitializeComponent();
            timer1.Start();
            TxFecha.Text = DateTime.Now.ToString();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
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

<<<<<<< HEAD
        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        private void TxFecha_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
=======
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (CBTipoUnidad.Text == "INGRESOS")
                {
                    dataGridView1.DataSource = bd.SelectDataTable("SELECT r.id, r.nombre, r.cantidad, r.fecha ,e.nombre FROM registroingreso r INNER JOIN tipounidad e ON e.id = r.tipounidad_id where fecha between  '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "';");

                }
                else
                {
                    if (CBTipoUnidad.Text == "EGRESOS")
                    {
                        dataGridView1.DataSource = bd.SelectDataTable("SELECT r.id, r.receptor, r.fecha,r.observaciones, a.nombre, t.nombre FROM egresos r INNER JOIN area a ON r.area_id=a.id INNER JOIN taller t ON r.taller_id=t.id where fecha between  '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "';");

                    }
                    else
                    {
                        if (CBTipoUnidad.Text == "CAJA CHICA")
                        {
                            dataGridView1.DataSource = bd.SelectDataTable("SELECT r.id, r.nombre, r.cantidad, r.fecha, e.nombre FROM registrocajachica r INNER JOIN tipounidad e ON r.tipounidad_id=e.id where fecha between  '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "';");

                        }
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("Error" + e);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



       

        private void btnPdf_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Reporte de "+dateTimePicker1.Text+" A "+dateTimePicker2.Text+" "+ CBTipoUnidad.Text+".pdf";
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
>>>>>>> ded203d ("reporte")
        }
    }
}

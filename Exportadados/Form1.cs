using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exportadados
{
    public partial class Datatoexcel : Form
    {
        public Datatoexcel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd=new SaveFileDialog() {Filter="Excel Workbook|*.xlsx" })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook()) 
                        {
                            workbook.Worksheets.Add(this.rHDataSet.CandidatoDetalhe.CopyToDataTable(), "CandidatoDetalhe");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Dados exportados com sucesso","Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,"Mensagem",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Datatoexcel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rHDataSet.Vaga' table. You can move, or remove it, as needed.
            this.vagaTableAdapter.Fill(this.rHDataSet.Vaga);
            // TODO: This line of code loads data into the 'rHDataSet.CandidatoDetalhe' table. You can move, or remove it, as needed.
            this.candidatoDetalheTableAdapter.Fill(this.rHDataSet.CandidatoDetalhe);
            // TODO: This line of code loads data into the 'rHDataSet.EntrevistaDetalhe' table. You can move, or remove it, as needed.
            this.entrevistaDetalheTableAdapter.Fill(this.rHDataSet.EntrevistaDetalhe);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

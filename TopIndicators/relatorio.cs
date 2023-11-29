using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using iTextSharp.Text;


namespace TopIndicators
{
    internal class relatorio
    {
        public void GerarRelatorio()
        {
            // Obtém os dados do datagridview
            DataTable dtData = dgvData.DataSource as DataTable;

            // Cria um novo documento PDF
            Document document = new Document.add();

            // Cria uma nova tabela
            PdfPTable table = new PdfPTable(2);

            // Adiciona cabeçalhos à tabela
            table.AddCell("Nome");
            table.AddCell("Idade");

            // Adiciona dados à tabela
            foreach (DataRow row in dtData.Rows)
            {
                table.AddCell(row["Nome"]);
                table.AddCell(row["Idade"].ToString());
            }

            // Adiciona a tabela ao documento
            document.Add(table);

            // Salva o documento
            document.Save("Relatorio.pdf");
        }
    }
}

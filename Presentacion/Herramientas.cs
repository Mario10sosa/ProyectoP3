using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Windows.Forms;
//using System.Windows.Documents;

namespace Presentacion
{
    public class Herramientas
    {
        public void GenerarPdf(System.Data.SqlClient.SqlDataReader reader)
        {
            //PdfWriter writer = new PdfWriter("demo.pdf");
            //PdfDocument pdf = new PdfDocument(writer);
            //Document document = new Document(pdf);
            //iText.Layout.Element.Paragraph header = new iText.Layout.Element.Paragraph("HEADER")
            //   .SetTextAlignment(TextAlignment.CENTER)
            //   .SetFontSize(20);

            //document.Add(header);
            //document.Close();

            //using (PdfWriter writer = new PdfWriter("C:/demo.pdf"))
            //{
            //    using (PdfDocument pdf = new PdfDocument(writer))
            //    {
            //        Document document = new Document(pdf);

            //        // Agrega un párrafo con el encabezado
            //        Paragraph header = new Paragraph("HEADER")
            //            .SetTextAlignment(TextAlignment.CENTER)
            //            .SetFontSize(20);

            //        document.Add(header);

            //        // Agrega los datos del SqlDataReader al documento PDF
            //        while (reader.Read())
            //        {
            //            for (int i = 0; i < reader.FieldCount; i++)
            //            {
            //                document.Add(new Paragraph(reader.GetName(i) + ": " + reader[i].ToString()));
            //            }

            //            // Agrega un espacio en blanco entre filas
            //            document.Add(new Paragraph("\n"));
            //        }
            //    }
            //}


        }


        public void imprimir()
        {
            SaveFileDialog guardar = new SaveFileDialog();
            string pdf = ".pdf";
            guardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + pdf;

            string paginahtml_texto = Properties.Resources.plantilla.ToString();
            
            if(guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream= new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));
                    using (StringReader sr = new StringReader(paginahtml_texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer,pdfDoc,sr);
                    }
                    pdfDoc.Close();
                    stream.Close();

                }

            }
        }
    }
}

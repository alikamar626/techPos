using System;
using System.Collections.Generic;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace TechStorePOS
{
    public static class InvoiceHelper
    {
        public static void PrintInvoice(List<CartItem> cartItems)
        {
            string invoicePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Invoice.pdf");

            Document doc = new Document(PageSize.A4, 40, 40, 40, 40);

            try
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(invoicePath, FileMode.Create));
                doc.Open();

                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

                iTextSharp.text.Font fontTitle = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontHeader = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);

                // Invoice Title
                Paragraph title = new Paragraph("Sales Invoice", fontTitle);
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20;
                doc.Add(title);

                // Table with 4 columns: Product, Quantity, Price, Total
                PdfPTable table = new PdfPTable(4);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 40f, 20f, 20f, 20f });

                // Table headers
                table.AddCell(new PdfPCell(new Phrase("Product", fontHeader)));
                table.AddCell(new PdfPCell(new Phrase("Quantity", fontHeader)));
                table.AddCell(new PdfPCell(new Phrase("Price", fontHeader)));
                table.AddCell(new PdfPCell(new Phrase("Total", fontHeader)));

                decimal total = 0m;

                // Add items
                foreach (var item in cartItems)
                {
                    table.AddCell(new PdfPCell(new Phrase(item.ProductName, fontNormal)));
                    table.AddCell(new PdfPCell(new Phrase(item.Quantity.ToString(), fontNormal)));
                    table.AddCell(new PdfPCell(new Phrase(item.Price.ToString("C"), fontNormal)));
                    decimal lineTotal = item.Price * item.Quantity;
                    table.AddCell(new PdfPCell(new Phrase(lineTotal.ToString("C"), fontNormal)));

                    total += lineTotal;
                }

                // Total row
                PdfPCell emptyCell = new PdfPCell(new Phrase(""));
                emptyCell.Border = Rectangle.NO_BORDER;
                table.AddCell(emptyCell);
                table.AddCell(emptyCell);
                PdfPCell totalCell = new PdfPCell(new Phrase("Total", fontHeader));
                totalCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                table.AddCell(totalCell);
                PdfPCell totalValueCell = new PdfPCell(new Phrase(total.ToString("C"), fontHeader));
                table.AddCell(totalValueCell);

                doc.Add(table);

                // Thank you note
                Paragraph thanks = new Paragraph("Thank you for your business!", fontNormal);
                thanks.Alignment = Element.ALIGN_CENTER;
                thanks.SpacingBefore = 20;
                doc.Add(thanks);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error creating invoice PDF: " + ex.Message);
            }
            finally
            {
                if (doc.IsOpen())
                    doc.Close();
            }

            // Automatically open the PDF after creation (optional)
            System.Diagnostics.Process.Start(invoicePath);
        }
    }
}

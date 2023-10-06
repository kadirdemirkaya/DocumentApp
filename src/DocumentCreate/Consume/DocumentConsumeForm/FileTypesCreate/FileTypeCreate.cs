using Newtonsoft.Json;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using System;
using System.IO;

namespace DocumentConsumeForm.FileTypesCreate
{
    public static class FileTypesCreate
    {
        public static class FileTypeCreate
        {
            public static bool CreatePdf(string message,string path)
            {
                PdfDocument pdf = new PdfDocument();
                PdfPage page = pdf.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Arial", 12);
                DateTime rightNow = DateTime.Now;
                gfx.DrawString(message, font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);
                string combinePath = Path.Combine(path, $"{rightNow.Month}.{rightNow.Hour}.{rightNow.Minute}.{rightNow.Second}.pdf");

                pdf.Save(combinePath);

                return true;
            }

            public static bool CreateJson(string message, string path)
            {
                DateTime rightNow = DateTime.Now;
                string combinePath = Path.Combine(path, $"{rightNow.Month}.{rightNow.Hour}.{rightNow.Minute}.{rightNow.Second}.json");
                string json = JsonConvert.SerializeObject(message);
                File.WriteAllText(combinePath, json);
                return true;
            }

            public static bool CreateText(string message, string path)
            {
                DateTime rightNow = DateTime.Now;
                string combinePath = Path.Combine(path, $"{rightNow.Month}.{rightNow.Hour}.{rightNow.Minute}.{rightNow.Second}.txt");
                File.WriteAllText(combinePath, message);
                return true;
            }
        }
    }
}

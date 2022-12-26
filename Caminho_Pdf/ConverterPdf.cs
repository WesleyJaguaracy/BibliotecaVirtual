using System;
using System.IO;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace CaminhoFisicoPdf
{
    class ConverterPdf
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ExtraiTextoDePdf(@"C:\Users\Wesle\source\repos\CaminhoFisicoPdf\TabelaNomes.pdf"));
            //Console.ReadKey();

            Console.WriteLine("Qual o caminho fisico do arquivo?");
            string caminhoPdf = Console.ReadLine();
            var nomeDoArquivo = caminhoPdf;
        }

        static string ExtraiTextoDePdf(string nomeDoArquivo)
        {
            string result = null;
            PdfReader pdfReader = new PdfReader(nomeDoArquivo);
            PdfDocument pdfDoc = new PdfDocument(pdfReader);
            for (int page = 1; page <= pdfDoc.GetNumberOfPages(); page++)
            {
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                string conteudo = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(page), strategy);
                result += conteudo;
            }
            pdfDoc.Close();
            pdfReader.Close();
            return result;
        }
    }
}

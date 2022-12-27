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

            Console.WriteLine("Qual o caminho fisico do arquivo?");
            string nomeDoArquivo = Console.ReadLine();
            Console.WriteLine();
            
            Console.WriteLine(ExtraiTextoDePdf(nomeDoArquivo));
            
            //caminho fisico a ser digitado @"C:\Users\Wesle\source\repos\CaminhoFisicoPdf\TabelaNomes.pdf"
        }

        static string ExtraiTextoDePdf(string nomeDoArquivo)
        {
            string result = null;
            PdfReader pdfReader = new PdfReader(nomeDoArquivo); //variavel PdfReader e objeto pdfReader passando o parametro nomeDoArquivo.
            PdfDocument pdfDoc = new PdfDocument(pdfReader);    //variavel PdfDocument e objeto pdfDoc passando o parametro pdfReader.
            for (int page = 1; page <= pdfDoc.GetNumberOfPages(); page++) //Faz a interação porque o texto pode ter varias paginas.
            {
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy(); // Estrategia de extração de texto e Simples estrategia de extração de textp
                string conteudo = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(page), strategy); //Pegar texto das paginas.
                result += conteudo;
            }
            pdfDoc.Close();
            pdfReader.Close();
            return result; //Retorno
        }
    }
}

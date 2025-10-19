namespace TesteParaCursos;

using ReportGenerator.Generators;

internal class Curso1934 
{

    // CURSO 19/34 - DESENVOLVIMENTO E GERENCIAMENTO DE BIBLIOTECAS

    internal void GeraRelatorios(List<Dictionary<string, string>> data)
    {
        CSVReportGenerator relatorio = new CSVReportGenerator(data);

        relatorio.Title = "Relatório de pessoas";
        relatorio.HeadLine = "Lista de pessoas cadastradas no sistema";
        relatorio.FooterLine = "Total de pessoas: " + data.Count;

        string arquivo = relatorio.GenerateReport();

        Console.WriteLine($"O arquivo {arquivo} foi gerado corretamente");

        PDFReportGenerator pdf = new PDFReportGenerator(data);

        pdf.Title = "Relatório de pessoas";
        pdf.HeadLine = "Lista de pessoas cadastradas no sistema";
        pdf.FooterLine = "Total de pessoas: " + data.Count;

        string arquivoPDF = pdf.GenerateReport();

        Console.WriteLine($"O arquivo {arquivoPDF} foi gerado corretamente");

    }

}


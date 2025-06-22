using System;
public interface Idoc
{
    void Open();
}
public class WordDocument : Idoc
{
    public void Open()
    {
        Console.WriteLine("Opening a word document..");
    }
}
public class PdfDocument : Idoc
{
    public void Open()
    {
        Console.WriteLine("Opening a PDF document..");
    }
}
public class ExcelDocument : Idoc
{
    public void Open()
    {
        Console.WriteLine("Opening an excel document..");
    }
}
public abstract class DocumentFactory
{
    public abstract Idoc CreateDocument();
}
public class WordDocumentFactory : DocumentFactory
{
    public override Idoc CreateDocument()
    {
        return new WordDocument();
    }
}
public class PdfDocumentFactory : DocumentFactory
{
    public override Idoc CreateDocument()
    {
        return new PdfDocument();
    }
}
public class ExcelDocumentFactory : DocumentFactory
{
    public override Idoc CreateDocument()
    {
        return new ExcelDocument();
    }
}
class Program
{
    static void Main(string[] args)
    {
        DocumentFactory wordFactory = new WordDocumentFactory();
        Idoc word = wordFactory.CreateDocument();
        word.Open();

        DocumentFactory pdfFactory = new PdfDocumentFactory();
        Idoc pdf = pdfFactory.CreateDocument();
        pdf.Open();

        DocumentFactory excelFactory = new ExcelDocumentFactory();
        Idoc excel = excelFactory.CreateDocument();
        excel.Open();
    }
}
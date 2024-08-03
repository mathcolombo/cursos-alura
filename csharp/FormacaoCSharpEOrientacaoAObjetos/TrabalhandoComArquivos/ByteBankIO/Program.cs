using ByteBankIO.Models;

public class Program
{
    public static void Main(string[] args)
    {
        string caminhoArquivo = "contas.txt";
        int numeroDeBytesLidos = -1;
        var buffer = new byte[1024]; //1kb

        var fluxoArquivo = new FileStream(caminhoArquivo, FileMode.Open);
        
        while(numeroDeBytesLidos != 0) {
            numeroDeBytesLidos = fluxoArquivo.Read(buffer, 0, 1024);
            EscreverBuffer(buffer);
        }

    }

    public static void EscreverBuffer(byte[] buffer)
    {
        foreach (var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write(" ");
        }
    }
}
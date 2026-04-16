namespace eserciziFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cartella = "Configurazione";
            string nomeFile = "impostazioni.log";
            string info = "info_sistema.txt";

            if (!Directory.Exists(cartella))
            {
                Directory.CreateDirectory(cartella);
            }

            string path = Path.Combine(cartella, nomeFile);

            if (!Directory.Exists(path))
            {
                File.Delete(path);
                Directory.CreateDirectory(path);
            }

            string path2 = Path.Combine(cartella, info);

            string[] lettura = File.ReadAllLines(path2);

            for(int i = 0; i < lettura.Length; i++)
            {
                Console.WriteLine(lettura[i]);
            }


        }
    }
}

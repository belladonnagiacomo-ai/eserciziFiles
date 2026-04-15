namespace eserciziFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cartella = "Configurazione";
            string nomeFile = "impostazioni.log";

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


        }
    }
}

using System.IO;

namespace MakeLobbiesEvenBetter
{
    public class NoteManager
    {
        public static string GetNote(long steamID64)
        {
            Directory.CreateDirectory("Notes");

            string path = Path.Combine("Notes", steamID64.ToString());

            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }

            return string.Empty;
        }

        public static void SaveNote(long steamID64, string note)
        {
            Directory.CreateDirectory("Notes");

            string path = Path.Combine("Notes", steamID64.ToString());

            File.WriteAllText(path, note);
        }
    }
}

using System;
using System.IO;

namespace Events.BL
{
    public class Files
    {
        public string Path { get; private set; }

        public Files(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path), "Путь к файлу не может быть пустым.");

            Path = path;
        }

        public void WriteFile()
        {
            using (var sr = new StreamWriter(Path, true))
                sr.WriteLine("Шаг назад");
        }

        public void Clear()
        {
            using (var sr = new StreamWriter(Path, false))
                sr.Write("");
        }
    }
}
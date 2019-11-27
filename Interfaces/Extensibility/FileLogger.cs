using System.IO;

namespace Extensibility
{
    public class FileLogger:ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string mesaj)
        {
            Log(mesaj,"Error");
        }

        public void LogInfo(string mesaj)
        {
            Log(mesaj,"info");
        }

        private void Log(string mesaj, string mesajType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(mesajType+ ":" + mesaj);
            }
            //streamWriter.Dispose();
        }
    }
}
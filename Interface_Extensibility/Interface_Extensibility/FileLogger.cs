using System.IO;

namespace Interface_Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            this._path = path;
        }
        public void LogError(string message)
        {
            Log(message, LogType.ERROR);
        }

        public void LogInfo(string message)
        {
            Log(message, LogType.INFO);
        }

        private void Log(string message, LogType logType)
        {
            using (var streamWriter = new StreamWriter(_path, append: true))
            {
                streamWriter.WriteLine(logType + ": " + message);
            }
        }
    }
}

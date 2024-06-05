public class FileLogger
{
    private FileWriter _fileWriter;

    public FileLogger(string filePath)
    {
        _fileWriter = new FileWriter(filePath);
    }

    public void Log(string message)
    {
        _fileWriter.WriteLine("[LOG] " + message);
    }

    public void Error(string message)
    {
        _fileWriter.WriteLine("[ERROR] " + message);
    }

    public void Warn(string message)
    {
        _fileWriter.WriteLine("[WARN] " + message);
    }
}
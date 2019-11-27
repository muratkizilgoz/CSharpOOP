namespace Extensibility
{
    public interface ILogger
    {
        void LogError(string mesaj);
        void LogInfo(string mesaj);
    }
}
using System;

namespace kOS.Safe
{
    public interface ILogger
    {
        void Log(string text);
        void Log(Exception e);
        void SuperVerbose(string s);
        void LogWarning(string s);
        void LogException(Exception exception);
        void LogError(string s);
    }
}
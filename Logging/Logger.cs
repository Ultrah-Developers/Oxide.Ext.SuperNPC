using Oxide.Core;

namespace Oxide.Ext.SuperNPC.Logging
{
    public class Logger : ILog
    {
        private LogLevel _logLevel;

        public Logger(LogLevel initialLogLevel)
        {
            SetLogLevel(initialLogLevel);
        }

        private void SetLogLevel(LogLevel levelToSet) => _logLevel = levelToSet;

        private void SendMessage(LogLevel logLevel, string message, Exception exception = null)
        {
            switch (logLevel)
            {
                case LogLevel.Info:
                    Interface.Oxide.LogInfo($"[{SuperNPCExtension._name}] {message}");
                    break;

                case LogLevel.Warning:
                    Interface.Oxide.LogWarning($"[{SuperNPCExtension._name}] {message}");
                    break;

                case LogLevel.Error:
                    Interface.Oxide.LogError($"[{SuperNPCExtension._name}] {message}");
                    break;

                case LogLevel.Debug:
                    Interface.Oxide.LogDebug($"[{SuperNPCExtension._name}] {message}");
                    break;

                case LogLevel.Exception:
                    Interface.Oxide.LogException($"[{SuperNPCExtension._name}] {message}", exception);
                    break;
            }
        }

        public void Info(string message) => SendMessage(LogLevel.Info, message);

        public void Warning(string message) => SendMessage(LogLevel.Warning, message);

        public void Error(string message) => SendMessage(LogLevel.Error, message);

        public void Debug(string message) => SendMessage(LogLevel.Debug, message);

        public void Exception(string message, Exception exception) => SendMessage(LogLevel.Exception, message, exception);
    }
}
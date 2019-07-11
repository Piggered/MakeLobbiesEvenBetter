using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MakeLobbiesEvenBetter
{
    public class LogReader
    {
        private Timer _timer;

        private FileStream _fileStream;
        private FileStream _fileStreamHeader;

        private StreamReader _streamReader;
        private StreamReader _streamReaderHeader;

        private List<string> LogLines = new List<string>();
        private string LogHeader = null;
        private long? CurrentHost;

        private readonly string[] SPLIT_SEPARATORS = new[] { "\r\n", "\r", "\n" };
        private readonly string NO_LOG_MESSAGE = "Could not find Dead by Daylight's log file. Try launching Dead by Daylight.";
        private readonly string NO_LOG_TITLE = "Log Not Found";

        public event EventHandler<SteamUser> NewHost;

        private static string GetLogPath()
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            return Path.Combine(localAppData, "DeadByDaylight", "Saved", "Logs", "DeadByDaylight.log");
        }

        public LogReader()
        {
            _fileStream = new FileStream(GetLogPath(), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            _streamReader = new StreamReader(_fileStream, Encoding.UTF8);

            _fileStreamHeader = new FileStream(GetLogPath(), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            _streamReaderHeader = new StreamReader(_fileStreamHeader, Encoding.UTF8);

            _timer = new Timer
            {
                AutoReset = true,
                Interval = 1000
            };

            _timer.Elapsed += OnElapsed;
            _timer.Start();
        }

        private void OnElapsed(object sender, ElapsedEventArgs e)
        {
            string header = _streamReaderHeader.ReadLine();
            _streamReaderHeader.BaseStream.Seek(0, SeekOrigin.Begin);
            _streamReaderHeader.DiscardBufferedData();

            if (LogHeader != null && LogHeader != header)
            {
                _streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
            }

            _streamReader.DiscardBufferedData();

            LogHeader = header;

            List<string> lines = _streamReader.ReadToEnd()
                .Split(SPLIT_SEPARATORS, StringSplitOptions.None)
                .Where(x => x.Contains("UPendingNetGame::SendInitialJoin:"))
                .ToList();

            LogLines.AddRange(lines);

            FetchLatestHost();
        }

        private void FetchLatestHost()
        {
            if (LogLines.Count > 0)
            {
                string line = LogLines.Last();

                line = line.Substring(line.IndexOf("RemoteAddr:") + 12);
                line = line.Substring(0, line.IndexOf(":"));
                long steamID = Convert.ToInt64(line);

                if (CurrentHost != steamID)
                {
                    CurrentHost = steamID;
                    NewHost?.Invoke(this, ProfileCrawler.GetUser(steamID));
                }
            }
        }

        public void ResetStream()
        {
            LogHeader = null;
            LogLines.Clear();

            OnElapsed(this, null);
        }
    }
}

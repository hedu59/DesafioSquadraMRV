using MessageConsumer.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.IO;

namespace MessageConsumer.Application.Services
{
    public class LogArchiveService : ILogArchiveService
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<LogArchiveService> _logger;
        public LogArchiveService(IConfiguration configuration, ILogger<LogArchiveService> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }
        public void SaveLog(string Log, string Exception)
        {

            try
            {
             
                // Check if file already exists. If yes, delete it.
                var data = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss").Replace(":", "").Replace(" ", "");
                var fileName = Log+ data + ".txt";
                string folderPath = AppContext.BaseDirectory;
                if (!System.IO.Directory.Exists(folderPath))
                {
                    System.IO.Directory.CreateDirectory(folderPath);
                }
                string text = "Name: LogException";
                text += "\n";
                text += Log;
                text += "\n";
                text += Exception;
                using (System.IO.StreamWriter sw = System.IO.File.CreateText(folderPath + "/LogException" + data+".txt"))
                {
                    sw.WriteLine(text);
                    sw.Close();
                }

            }
            catch (Exception ex)
            {
                _logger.LogError("Something wrong happened: ", ex.Message);
                throw;
            }
        }
    }
}
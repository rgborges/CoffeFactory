internal class FileLogger : ILogger
{
    public void Log(string message, LoggerMessageType type)
    {
        try
        {
            if(!File.Exists("log.txt")) File.Create("log.txt");
            using (StreamWriter ws = new StreamWriter("log.txt", append: true))
            {
                ws.WriteLine($"{DateTime.Now}: {message} [{type}]");
            }
        }
        catch(IOException e)
        {
            throw e;
        }
        
    }

    public Task LogAsync(string message, LoggerMessageType type)
    {
          try
        {
            if(!File.Exists("log.txt")) File.Create("log.txt");
            using (StreamWriter ws = new StreamWriter("log.txt", append: true))
            {
                return Task.Run(()=> ws.WriteLineAsync($"{DateTime.Now}: {message} [{type}]"));
            }
        }
        catch(IOException e)
        {
            throw e;
        }
    }
}
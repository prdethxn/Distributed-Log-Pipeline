namespace Shared;

public class LogEvent
{
    public int Id { get; set; } = Guid.NewGuid();
    public string Level { get; set; } = string.Empty();
    public string Message { get; set; } = string.Empty();
    public string Source { get; set; } = string.Empty();
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public Dictionary<string,string> Metadata { get; set; } = new()
}

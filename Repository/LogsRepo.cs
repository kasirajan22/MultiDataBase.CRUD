

using Microsoft.EntityFrameworkCore;

namespace MultiDataBase.CRUD;

public class LogsRepo : ILogsRepo
{
    private readonly LogDBContext _logDBContext;

    public LogsRepo(LogDBContext logDBContext)
    {
        this._logDBContext = logDBContext;
    }

    public async Task AddLog(Logs log)
    {
        await _logDBContext.Logs.AddAsync(log);
        await _logDBContext.SaveChangesAsync();
    }

    public async Task<List<Logs>> GetLogs()
    {
        return await _logDBContext.Logs.ToListAsync();
    }
}

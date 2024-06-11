namespace MultiDataBase.CRUD;

public interface ILogsRepo
{
    public Task AddLog(Logs log);
    public Task<List<Logs>> GetLogs();
}

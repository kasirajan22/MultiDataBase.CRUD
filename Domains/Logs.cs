using System.ComponentModel.DataAnnotations;

namespace MultiDataBase.CRUD;

public class Logs
{
    [Key]
    public int Id {get;set;}
    public int UserId {get;set;}
    public string? Log {get;set;}
}

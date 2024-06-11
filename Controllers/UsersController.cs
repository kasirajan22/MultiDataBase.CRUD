using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiDataBase.CRUD;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        protected readonly IUsersRepo _usersRepo;
        protected readonly ILogsRepo _logsRepo;

        public UsersController(IUsersRepo usersRepo, ILogsRepo logsRepo)
        {
            _usersRepo = usersRepo;
            _logsRepo = logsRepo;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(Users user)
        {
            await _usersRepo.AddUser(user);
            await _logsRepo.AddLog(new Logs{ Id = 1, UserId = user.Id, Log = "Insert"});
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _usersRepo.GetAllUsers());
        }
        [HttpPut]
        public IActionResult UpdateUser(Users user)
        {
            return Ok(_usersRepo.UpdateUser(user));
        }
        [HttpGet("/Id")]
        public async Task<IActionResult> GetUser(int Id)
        {
            return Ok(await _usersRepo.GetUser(Id));
        }

        [HttpGet("Logs")]
        public async Task<IActionResult> GetLogs()
        {
            return Ok(await _logsRepo.GetLogs());
        }
    }
}

using DatingApp.Data;
using Microsoft.AspNetCore.Mvc;
using DatingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
    }
}

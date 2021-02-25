using System.IO;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace FileResultBug.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {
        [HttpGet("getFile1")]
        public FileResult GetFile1()
        {
            var stream = new MemoryStream(Encoding.UTF8.GetBytes("Hello ASP.NET Core!"));
            return new FileStreamResult(stream, "text/plain") { FileDownloadName = "hello.txt" };
        }

        [HttpGet("getFile2")]
        public ActionResult<FileResult> GetFile2()
        {
            var stream = new MemoryStream(Encoding.UTF8.GetBytes("Hello ASP.NET Core!"));
            return new FileStreamResult(stream, "text/plain") { FileDownloadName = "hello.txt" };
        }
    }
}

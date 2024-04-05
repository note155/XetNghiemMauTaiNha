using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace duanxetnghiem.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;

        public ImagesController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [HttpGet("img/{imageName}")]
        public IActionResult GetImage(string imageName)
        {
            // Đường dẫn đến thư mục chứa ảnh
            var imagePath = Path.Combine(_env.ContentRootPath, "wwwroot", "img", imageName);

            if (!System.IO.File.Exists(imagePath))
            {
                // Trả về 404 nếu không tìm thấy ảnh
                return NotFound();
            }

            // Đọc tệp ảnh và trả về dưới dạng FileStreamResult
            var imageFileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            return File(imageFileStream, "image/jpeg");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using npc.project.server.Services;

namespace npc.project.server.Controllers
{
    [ApiController]
    [Route("api/page-content")]
    public class PageContentController : ControllerBase
    {
        private readonly PageEditorService _service;

        public PageContentController(PageEditorService service)
        {
            _service = service;
        }

        [HttpGet("{pageKey}")]
        public IActionResult Get(string pageKey)
        {
            var content = _service.GetContent(pageKey);
            return Ok(content);
        }

        [HttpPost("{pageKey}")]
        public IActionResult Save(string pageKey, [FromBody] string contentJson)
        {
            _service.SaveContent(pageKey, contentJson);
            return Ok();
        }
    }

}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class News : ControllerBase
    {
        /// <summary>
        /// 获取指定剧集资讯
        /// </summary>
        [HttpGet]
        [Route("{Id}")]
        public ActionResult GetNews([FromRoute] int Id)
        {
            return Ok("获取新闻");
        }

        /// <summary>
        /// 添加剧集资讯
        /// </summary>
        [HttpPost]
        public ActionResult CreateNews([FromBody] NewsModel newsModel)
        {
            return Created("", newsModel);
        }

        /// <summary>
        /// 更新剧集资讯
        /// </summary>
        [HttpPut]
        [Route("{Id}")]
        public ActionResult UpdateNews()
        {
            return Ok("新闻已更新");
        }

        /// <summary>
        /// 删除剧集资讯
        /// </summary>
        [HttpDelete]
        [Route("{Id}")]
        public ActionResult DeleteNews()
        {
            return Ok("新闻已删除");
        }

    }
}

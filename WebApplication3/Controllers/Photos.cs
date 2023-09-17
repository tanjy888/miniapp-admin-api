using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Photos : ControllerBase
    {
        /// <summary>
        /// 获取指定剧集壁纸
        /// </summary>
        [HttpGet]
        [Route("{Id}")]
        public ActionResult GetPhotos([FromRoute] int Id)
        {
            return Ok("获取指定壁纸");
        }

        /// <summary>
        /// 添加剧集壁纸
        /// </summary>
        [HttpPost]
        public ActionResult CreatePhotos([FromBody] AgreementModel newAgreement) {
            return Created("", newAgreement);
        }

        /// <summary>
        /// 更新剧集壁纸
        /// </summary>
        [HttpPut]
        [Route("{Id}")]
        public ActionResult UpdatePhotos() {
             return Ok("壁纸已更新");
        }

        /// <summary>
        /// 删除剧集壁纸
        /// </summary>
        [HttpDelete]
        [Route("{Id}")]
        public ActionResult DeletePhotos() {
            return Ok("壁纸已删除");
        }

    }
}

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Activity : ControllerBase
    {
        /// <summary>
        /// 获取指定活动
        /// </summary>
        [HttpGet]
        [Route("{Id}")]
        public ActionResult GetActivity([FromRoute] int Id) {
            return Ok("获取指定活动");
        }

        /// <summary>
        /// 添加活动
        /// </summary>
        [HttpPost]
        public ActionResult CreateActivity([FromBody] ActivityModel newActivity) {
            return Created("", newActivity);
        }

        /// <summary>
        /// 更新活动
        /// </summary>
        [HttpPut]
        [Route("{Id}")]
        public ActionResult UpdateActivity() {
             return Ok("活动已更新");
        }

        /// <summary>
        /// 删除活动
        /// </summary>
        [HttpDelete]
        [Route("{Id}")]
        public ActionResult DeleteActivity() {
            return Ok("活动已删除");
        }

        /// <summary>
        /// 启用活动
        /// </summary>
        [HttpPost]
        [Route("enable")]
        public ActionResult SetActivityEnable([Required][FromQuery] Int64 Id)
        {
            return Ok("活动已启用");
        }

        /// <summary>
        /// 获取活动类型
        /// </summary>
        [HttpGet]
        [Route("type")]
        public ActionResult GetActivityType([Required][FromQuery] int Id)
        {
            return Ok("获取活动类型");
        }

    }
}

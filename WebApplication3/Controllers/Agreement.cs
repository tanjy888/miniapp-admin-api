using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Agreement : ControllerBase
    {
        /// <summary>
        /// 获取指定用户协议
        /// </summary>
        [HttpGet]
        [Route("{Id}")]
        public ActionResult GetAgreement([FromRoute] int Id) {
            return Ok("获取指定协议");
        }

        /// <summary>
        /// 添加用户协议
        /// </summary>
        [HttpPost]
        public ActionResult CreateAgreement([FromBody] AgreementModel newAgreement) {
            return Created("", newAgreement);
        }

        /// <summary>
        /// 更新用户协议
        /// </summary>
        [HttpPut]
        [Route("{Id}")]
        public ActionResult UpdateAgreement() {
             return Ok("协议已更新");
        }

        /// <summary>
        /// 删除用户协议
        /// </summary>
        [HttpDelete]
        [Route("{Id}")]
        public ActionResult DeleteAgreement() {
            return Ok("协议已删除");
        }

    }
}

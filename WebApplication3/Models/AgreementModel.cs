using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public record AgreementModel
    {
        /// <summary>
        /// 用户协议ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 用户协议标题
        /// </summary>
        [Required]
        [StringLength(100)]
        public String Title { get; set; }

        /// <summary>
        /// 用户协议描述
        /// </summary>
        public String Description { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public record ActivityModel
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// 活动标题
        /// </summary>
        [Required]
        [StringLength(60)]
        public String Name { get; set; }

        /// <summary>
        /// 活动封面
        /// </summary>
        [Required]
        public String Cover { get; set; }

        /// <summary>
        /// 活动页面链接
        /// </summary>
        [Required]
        public String Link { get; set; }
        
    }
}

namespace WebApplication1.Models
{
    public record NewsModel
    {
        /// <summary>
        /// 新闻ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 新闻标题
        /// </summary>
        public String Title { get; set; }
        /// <summary>
        /// 新闻内容
        /// </summary>
        public String Description { get; set; }
    }
}

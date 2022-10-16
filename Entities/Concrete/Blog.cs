namespace Entities.Concrete;

public class Blog
{
    public int Id { get; set; }
    public string BlogTitle { get; set; }
    public string Content { get; set; }
    public string BlogThumbnailImage { get; set; }
    public string BlogImage { get; set; }
    public DateTime CreateDate { get; set; }
    public bool Status { get; set; }
    public int CategoryId  { get; set; }
    public Category Category { get; set; }
    public List<Comment> Comments { get; set; }
}
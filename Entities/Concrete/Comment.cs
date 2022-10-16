using Core.Entities;

namespace Entities.Concrete;

public class Comment:IEntity
{
    public int Id { get; set; }
    public string CommentUserName { get; set; }
    public string CommentTitle { get; set; }
    public string CommentContent { get; set; }
    public DateTime CommentDate { get; set; }
    public bool Status { get; set; }
    public int BlogId { get; set; }
    public List<Blog> Blogs { get; set; }
}
using Core.Entities;

namespace Entities.Concrete;

public class Contact:IEntity
{
    public int Id { get; set; }
    public string ContactUserName { get; set; }
    public string ContactMail { get; set; }
    public string ContactSubject { get; set; }
    public string ContactMessage { get; set; }
    public DateTime ContactDate { get; set; }
    public bool Status { get; set; }
}
using Core.Entities;

namespace Entities.Concrete;

public class Writer:IEntity
{
    public int Id { get; set; }
    public string WriterName { get; set; }
    public string WriterAbout { get; set; }
    public string WriterImage { get; set; }
    public string WriterMail { get; set; }
    public string WriterPass { get; set; }
    public bool WriterStatus { get; set; }
}
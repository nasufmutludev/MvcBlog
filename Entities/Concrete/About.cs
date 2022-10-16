using Core.Entities;

namespace Entities.Concrete;

public class About : IEntity
{
    public int Id { get; set; }
    public string AboutDetails1 { get; set; }
    public string AboutDetails2 { get; set; }
    public string AboutImage1 { get; set; }
    public string AboutImage2 { get; set; }
    public string AboutMapLocation { get; set; }
    public bool AboutStatus { get; set; }
}
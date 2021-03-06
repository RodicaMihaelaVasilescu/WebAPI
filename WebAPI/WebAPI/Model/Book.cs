using System;

namespace WebAPI.Models
{
  public class Book
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public DateTime PublicationDate { get; set; }
    public double Price { get; set; }
    public string Publisher { get; set; }
    public string Genre { get; set; }
    public string Language { get; set; }
    public string Description { get; set; }
    public int Pages { get; set; }

  }
}
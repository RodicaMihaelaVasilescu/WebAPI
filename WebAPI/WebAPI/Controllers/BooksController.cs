using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;
using WebAPI.Utils;

namespace WebAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class BooksController : ControllerBase
  {
    [HttpGet]
    [Route("GetBooks")]
    public IEnumerable<Book> GetBooks()
    {
      return BooksManager.Books.OrderBy(book => book.Id);
    }

    [HttpGet]
    [Route("GetBooksByYear")]
    public IEnumerable<Book> GetBooks(int year)
    {
      return BooksManager.Books.Where(book => book.PublicationDate.Year == year);
    }

    [HttpPost]
    [Route("AddNewBook")]
    public ActionResult AddNewBook(Book book)
    {
      if(BooksManager.Books.Any(b=>b.Id == book.Id))
      {
        return BadRequest();
      }
      BooksManager.Books.Add(book);
      return Ok(book);
    }

    [HttpPut]
    [Route("UpdateBookById")]
    public ActionResult UpdateBookById(Book book)
    {
      try
      {
        var bookToUpdate = BooksManager.Books.First(b => b.Id == book.Id);
        BooksManager.Books.Remove(bookToUpdate);
        BooksManager.Books.Add(book);
      }
      catch
      {
        return NotFound();
      }

      return Ok(book);
    }

    [HttpDelete]
    [Route("DeleteBookById")]
    public ActionResult DeleteBookById(int id)
    {
      Book bookToDelete = null;
      try
      {
        bookToDelete = BooksManager.Books.First(b => b.Id == id);
        BooksManager.Books.Remove(bookToDelete);
      }
      catch
      {
        return NotFound();
      }

      return Ok(bookToDelete);
    }
  }
}
using System;
using System.Collections.Generic;
using WebAPI.Models;

namespace WebAPI.Utils
{
  public static class BooksManager
  {
    public static List<Book> Books = new List<Book>
    {
        new Book
        {
            Id = 1,
            Title = "The Mysterious Affair at Styles",
            Author = "Agatha Christie",
            Description = "The Mysterious Affair at Styles is a detective novel by British writer Agatha Christie. It was written in the middle of the First World War, in 1916, and first published by John Lane in the United States in October 1920[1] and in the United Kingdom by The Bodley Head (John Lane's UK company) on 21 January 1921.",
            PublicationDate = new DateTime(1920, 10, 5),
            Pages = 290,
            Price = 22.5,
            Language = "English",
            Publisher = "Collins Crime Club",
            Genre = "Crime novel"
        },
        new Book
        {
            Id = 2,
            Title = "Death on the Nile",
            Author = "Agatha Christie",
            Description = "While on holiday in Aswan to board the steamer Karnak, set to tour along the Nile River from Shellal to Wadi Halfa, Hercule Poirot is approached by successful socialite Linnet Doyle née Ridgeway. She wants to commission him to deter her former friend Jacqueline de Bellefort from hounding and stalking her",
            PublicationDate = new DateTime(1937, 11, 1),
            Pages=288,
            Price = 32.99,
            Language = "English",
            Publisher="Collins Crime Club",
            Genre = "	Crime novel"

        },
        new Book
        {
            Id = 3,
            Title = "Pride and Prejudice",
            Author = "Jane Austen",
            Description = "In rural England in the early 19th century, Mrs. Bennet attempts to persuade Mr. Bennet to visit Mr. Bingley, a rich bachelor recently arrived in the neighbourhood. After some verbal sparring with her husband, Mrs. Bennet believes he will not call on Mr. Bingley. Shortly afterwards, he visits Netherfield, Mr. Bingley's rented residence, much to Mrs. Bennet's delight. The visit is followed by a ball at the local assembly rooms that the entire neighbourhood attends.",
            PublicationDate = new DateTime(1813, 1, 28),
            Pages = 320,
            Price = 22.5,
            Language = "English",
            Publisher = "Whitehall",
            Genre = "Classic Regency novel, Romance novel"
        },
        new Book
        {
            Id = 4,
            Title = "Around the World in Eighty Days",
            Author = "	Jules Verne",
            Description = "Phileas Fogg is a wealthy English gentleman living a solitary life in London. Despite his wealth, Fogg lives modestly and carries out his habits with mathematical precision. Very little can be said about his social life other than that he is a member of the Reform Club, where he spends the best part of his days. Having dismissed his valet for bringing him shaving water at a temperature slightly lower than expected, Fogg hires Frenchman Jean Passepartout as a replacement.",
            PublicationDate = new DateTime(1872, 1, 30),
            Pages = 180,
            Price = 18.75,
            Language = "English",
            Publisher = "Pierre-Jules Hetzel",
            Genre = "	Adventure novel"
        }
    };
  }
}
using System;
using System.Collections.Generic;
using libraryapi.FAKEDB;
using libraryapi.Models;

namespace libraryapi.Services {
    public class BooksService {
        internal IEnumerable<Book> Get () {
            return FakeDB.Books;
        }

        internal Book GetById (string id) {
            var found = FakeDB.Books.Find (book => book.Id == id);
            if (found == null) {
                throw new Exception ("Bad Id DAWG!");
            }
            return found;
        }

        internal Book Create (Book newBook) {
            FakeDB.Books.Add (newBook);
            return newBook;
        }

        internal Book Edit (Book editBook, string id) {
            var original = FakeDB.Books.Find (book => book.Id == id);
            if (original == null) {
                throw new Exception ("Bad Id DAWG!");
            }
            editBook.Id = original.Id;
            editBook.Title = editBook.Title != null ? editBook.Title : original.Title;
            editBook.Author = editBook.Author != null ? editBook.Author : original.Author;
            editBook.Description = editBook.Description != null ? editBook.Description : original.Description;
            editBook.InStock = editBook.InStock != 0 ? editBook.InStock : original.InStock;
            editBook.PageCount = editBook.PageCount != 0 ? editBook.PageCount : original.PageCount;
            editBook.Genre = editBook.Genre != null ? editBook.Genre : original.Genre;
            FakeDB.Books.Remove (original);
            FakeDB.Books.Add (editBook);
            return editBook;

        }

        internal Book Delete (string bookId) {
            var found = FakeDB.Books.Find (book => book.Id == bookId);
            if (found == null) { throw new Exception ("Bad ID DAWG!"); }
            FakeDB.Books.Remove (found);
            return found;

        }
    }
}
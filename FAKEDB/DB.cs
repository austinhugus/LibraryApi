using System.Collections.Generic;
using libraryapi.Models;

namespace libraryapi.FAKEDB {
    public static class FakeDB {
        public static List<Book> Books { get; set; } = new List<Book> () {

            new Book ("Charlottes Web", "E.B. White", "Spider is Mean", 10, 150, "Childrens"),
            new Book ("Cat in the Hat", "Dr. Seuss", "A Cat Gets Stuck In the Hat", 20, 30, "Childrens"),
            new Book ("Dracula", "Bram Stoker", "Guy get thirsty, people aren't happy about it", 5, 300, "horror"),

        };
    }

}
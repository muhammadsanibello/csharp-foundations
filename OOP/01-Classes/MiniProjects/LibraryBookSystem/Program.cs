// Library Book System

using LibraryBookSystem;

var book1 = new Book("Sugar Girl", "Kola Bibi");
var book2 = new Book("Life Changer", "Khadija Jalli");

book1.DisplayBookInfo();
book1.BorrowBook();
book1.ReturnBook();

Console.WriteLine();

book2.DisplayBookInfo();
book2.BorrowBook();
book2.ReturnBook();
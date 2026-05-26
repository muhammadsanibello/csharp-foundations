using Exercise_17_Refactor_Using_Interface;

IBorrowable book = new BorrowableBook("Life Changer");
IBorrowable dvd = new BorrowableDVD("Graphic design institute");

Library bookLibrary = new Library(book);
Library dvdLibrary = new Library(dvd);

bookLibrary.BorrowItem();
bookLibrary.BorrowItem(); // Try borrowing again

Console.WriteLine();

dvdLibrary.BorrowItem();
dvdLibrary.BorrowItem(); // Try borrowing again
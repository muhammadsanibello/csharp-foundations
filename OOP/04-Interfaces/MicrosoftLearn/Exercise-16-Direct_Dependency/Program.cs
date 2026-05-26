using Exercise_16_Direct_Dependency;

BorrowableBook book = new BorrowableBook("Life Changer");

Library library = new Library(book);
library.BorrowBook();
public class TestLibrary {
    public static void main(String[] args) {
        Library firstLibrary = new Library("10 Main St.");
        Library secondLibrary = new Library("228 Liberty St.");

        // Add books to the first library
        firstLibrary.addBook(new Book("Dan Brown", "The Da Vinci Code", 448, "308.bro", 1001));
        firstLibrary.addBook(new Book("Antoine De Saint-Exupery", "The Little Prince", 128, "400.exu", 1002));
        firstLibrary.addBook(new Book("Charles Dickens", "A Tale of Two Cities", 412, "400.dic", 1003));
        firstLibrary.addBook(new Book("J. R. R. Tolkien", "The Fellowship of the Ring", 398, "308.tol", 1004));
        firstLibrary.addBook(new Book("J. R. R. Tolkien", "The Two Towers", 327, "308.tol", 1005));

        // Test library functionality
        System.out.println("Library hours:");
        firstLibrary.printOpeningHours();
        System.out.println();

        System.out.println("Library addresses:");
        firstLibrary.printAddress();
        secondLibrary.printAddress();
        System.out.println();

        // Borrow The Two Towers from the first library and check to see if it can be borrowed if taken out again 
        System.out.println("Borrowing The Two Towers:");
        firstLibrary.borrowBook(1005);
        firstLibrary.borrowBook(1005);
        secondLibrary.borrowBook(1005);
        System.out.println();

        // Available books in the first library
        System.out.println("Books available in the first library:");
        firstLibrary.printAvailableBooks();
        System.out.println();

        // Available books in the second library
        System.out.println("Books available in the second library:");
        secondLibrary.printAvailableBooks();
        System.out.println();

        // Returning The Two Towers to the first library
        System.out.println("Returning The Two Towers:");
        firstLibrary.returnBook(1005);
        System.out.println();

        // Available books in the first library
        System.out.println("Books available in the first library:");
        firstLibrary.printAvailableBooks();
    }
}

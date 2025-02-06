/**
 * This class creates a  library system that manages a collection of books.
 * It allows users to add books, borrow books, return books, remove books, and view available books.
 * Additionally, it provides information about the library's address and opening hours.
 * 
 * @author Caelum Casserly, Liam Shearer 
 * @version (29/11/24)
 */
public class Library {
    // Fields
    private Book[] bookCollection;
    private int collectionSize;
    private String address;
    private String openingHours;

    // Constructor
    public Library(String address) {
        this.address = address;
        this.bookCollection = new Book[500];
        this.collectionSize = 0;
        this.openingHours = "9:00 - 21:00"; // Default hours
    }

    // adding a book to the collection
    public void addBook(Book book) {
        if (collectionSize < 500) {
            bookCollection[collectionSize] = book;
            collectionSize++;
        } else {
            System.out.println("Library is full. Cannot add more books.");
        }
    }

    // print opening hours
    public void printOpeningHours() {
        System.out.println("Library opening hours: " + openingHours);
    }

    // print library address
    public void printAddress() {
        System.out.println("Library address: " + address);
    }

    // borrow a book using bar code number
    public void borrowBook(int barCodeNumber) {
        for (int i = 0; i < collectionSize; i++) {
            if (bookCollection[i].getBarCodeNumber() == barCodeNumber) {
                if (bookCollection[i].isAvailable()) {
                    bookCollection[i].borrowBook();
                    System.out.println("You successfully borrowed " + bookCollection[i].getTitle());
                } else {
                    System.out.println("Sorry, " + bookCollection[i].getTitle() + " is already borrowed.");
                }
                return;
            }
        }
        System.out.println("Book with bar code number " + barCodeNumber + " not found in the library.");
    }

    // return a book using bar code number
    public void returnBook(int barCodeNumber) {
        for (int i = 0; i < collectionSize; i++) {
            if (bookCollection[i].getBarCodeNumber() == barCodeNumber) {
                bookCollection[i].returnBook();
                System.out.println("You successfully returned " + bookCollection[i].getTitle());
                return;
            }
        }
        System.out.println("Book with bar code number " + barCodeNumber + " not found in the library.");
    }

    //  print available books
    public void printAvailableBooks() {
        boolean found = false;
        for (int i = 0; i < collectionSize; i++) {
            if (bookCollection[i].isAvailable()) {
                bookCollection[i].printDetails();
                found = true;
            }
        }
        if (!found) {
            System.out.println("No books available for borrowing.");
        }
    }

    // remove a book from the collection
    public void removeBook(int barCodeNumber) {
        for (int i = 0; i < collectionSize; i++) {
            if (bookCollection[i].getBarCodeNumber() == barCodeNumber) {
                bookCollection[i] = bookCollection[collectionSize - 1];
                bookCollection[collectionSize - 1] = null;
                collectionSize--;
                System.out.println("Book with bar code number " + barCodeNumber + " has been removed.");
                return;
            }
        }
        System.out.println("Book with bar code number " + barCodeNumber + " not found in the library.");
    }

    //  print all authors
    public void printAllAuthors() {
        for (int i = 0; i < collectionSize; i++) {
            System.out.println(bookCollection[i].getAuthor());
        }
    }
}
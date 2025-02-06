/**
   * this class holds information on the books 
   * @authors (Caelum Casserly)
   * @version (29/11/24)
   */
   
  public class Book {
    
    private String author;
    private String title;
    private int pages;
    private String shelfNumber;
    private int barCodeNumber;
    private boolean available;
    private int numBorrowings;

    // Constructor
    public Book(String author, String title, int pages, String shelfNumber, int barCodeNumber) {
        this.author = author;
        this.title = title;
        this.pages = pages;
        this.shelfNumber = shelfNumber;
        this.barCodeNumber = barCodeNumber;
        this.available = true; 
        this.numBorrowings = 0;
    }

    // Accessor methods
    public String getAuthor() {
        return author;
    }

    public String getTitle() {
        return title;
    }

    public int getPages() {
        return pages;
    }

    public String getShelfNumber() {
        return shelfNumber;
    }

    public int getBarCodeNumber() {
        return barCodeNumber;
    }

    public boolean isAvailable() {
        return available;
    }

    // Mutator methods
    public void setShelfNumber(String shelfNumber) {
        this.shelfNumber = shelfNumber;
    }

    public void setBarCodeNumber(int barCodeNumber) {
        this.barCodeNumber = barCodeNumber;
    }

    public void borrowBook() {
        if (available) {
            available = false;
            numBorrowings++;
        } else {
            System.out.println("Book is already borrowed.");
        }
    }

    public void returnBook() {
        if (!available) {
            available = true;
        } else {
            System.out.println("Book was not borrowed.");
        }
    }

    // Print titles,authors,shelf numbers, barcodes, availability and pages
    public void printAuthor() {
        System.out.println("Author: " + author);
    }

    public void printTitle() {
        System.out.println("Title: " + title);
    }

    public void printPages() {
        System.out.println("Pages: " + pages);
    }

    public void printShelfNumber() {
        System.out.println("Shelf Number: " + shelfNumber);
    }

    public void printBarCodeNumber() {
        System.out.println("Bar Code Number: " + barCodeNumber);
    }

    public void printAvailability() {
        System.out.println("Available: " + (available ? "Yes" : "No"));
    }

    public void printDetails() {
        printAuthor();
        printTitle();
        printPages();
        printShelfNumber();
        printBarCodeNumber();
        printAvailability();
        System.out.println("Number of Borrows: " + numBorrowings);
    }
}

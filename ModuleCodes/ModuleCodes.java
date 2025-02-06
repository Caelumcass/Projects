
/**
 * this application prompts the user to input a module code (e.g MS220) and outputs the name of the module 
 *
 * Caelum Casserly
 * 07/10/2024
 */
import java.util.Scanner;

public class ModuleCodes
{
    public static void main(String[] args) 
    {

        Scanner scanner = new Scanner(System.in);

        // Prompt user to eneter module code
        System.out.print("Enter a module code (e.g., MS220): ");
        String moduleCode = scanner.nextLine().toUpperCase();

        // Switch-case to find the module name
        switch (moduleCode) 
        {
            case "MA208":
                System.out.println("The module code you have inputted corrolates to: Quantitative Techniques for Business");
                break;
            case "AY207":
                System.out.println("The module code you have inputted corrolates to: Management Accounting");
                break;
            case "MS321":
                System.out.println("The module code you have inputted corrolates to: Web & Interactive Media Design");
                break;
            case "MS218":
                System.out.println("The module code you have inputted corrolates to: Database Technologies");
                break;
            case "MS220":
                System.out.println("The module code you have inputted corrolates to: Advanced Application Development");
                break;
            case "MG524":
                System.out.println("The module code you have inputted corrolates to: Management");
                break;
            default:
                System.out.println("Module code not found.");
        }

        // Close the scanner
        scanner.close();
    }
}

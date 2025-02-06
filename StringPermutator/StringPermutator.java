
/**
 * prompts the user to input three strings and outputs the six permutations 
 *
 * Caelum Casserly
 * 30/09/24
 */
import java.util.Scanner;

public class StringPermutator
{
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Prompt the user to input three strings
        System.out.print("Enter the first string: ");
        String str1 = scanner.nextLine();
        
        System.out.print("Enter the second string: ");
        String str2 = scanner.nextLine();
        
        System.out.print("Enter the third string: ");
        String str3 = scanner.nextLine();

        // Output the six permutations of the strings
        System.out.println("The six permutations are:");
        System.out.println(str1 + "  " + str2 + "  " + str3);
        System.out.println(str1 + "  " + str3 + "  " + str2);
        System.out.println(str2 + "  " + str1 + "  " + str3);
        System.out.println(str2 + "  " + str3 + "  " + str1);
        System.out.println(str3 + "  " + str1 + "  " + str2);
        System.out.println(str3 + "  " + str2 + "  " + str1);

        
    }
}


/**
 * Write a description of class BattleshipGameB here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
import java.util.*;
public class BattleshipGameB
{
    private static Scanner input = new Scanner(System.in);

    /**
     * Prompts a user for a positive int value and returns it.
     * 
     * @param prompt
     *            the desired prompt message to be displayed on screen
     */

    public static int promptForInt(String prompt) {
        int number;        
        do
        {   System.out.print(prompt + ": "); 
            number = input.nextInt();
            if (number <= 0) 
                System.out.println("Enter a positive integer");
        }while (number <= 0);
        return number;
    }

    /**
     * Displays a nice picture of the river in the Console View
     * 
     * @param river
     *            the array that represents the river
     * @param showShip
     *            indicates if you wish to display the location of the ship
     */

    public static void displayRiver(int[] river, boolean showShips) {
        System.out.println();
        System.out.print("|");
        for (int val : river) {
            switch (val) {
                case -1: // No Ship
                    System.out.print("x");
                    break;
                case 0: // Unknown
                    System.out.print(" ");
                    break;
                case 1: // Ship Found
                    System.out.print(showShips ? "Y" : " ");
                    break;
                case 2: 
                    System.out.print(showShips ? "N" : " " );
                        
            }//switch
            System.out.print("|");
        }//for
        System.out.println();
        System.out.println();
    }//displayRiver

    // main method
    public static void main(String[] arg) {

        // Prompt the player to enter the size of the river
        int riverSize = promptForInt("Specify the length of the river. Minimum length is 5");

        // Create array to represent the river
        int[] river = new int[riverSize];

        // Hide the second ship which takes up 1 space
        Random randomizer = new Random();
        int secondShipPosition = randomizer.nextInt(riverSize);
        river[secondShipPosition] = 1;
        // Hide first ship which takes up 2 spaces 
        int firstShipStart;
        do{ 
            firstShipStart = randomizer.nextInt(riverSize - 1);
        } while (firstShipStart == secondShipPosition || firstShipStart + 1 == secondShipPosition); 
        // mark positions for the size 2 ship
        river[firstShipStart] = 0;
        river[firstShipStart + 1] = 0;

        System.out.println("There are 2 hidden ships somewhere in the river");

        // Loop for multple guesses
        boolean firstShipFoundPart1 = false;
        boolean firstShipFoundPart2 = false;
        boolean secondShipFound = false;

        while  (!secondShipFound || !firstShipFoundPart1 || !firstShipFoundPart2) {
            int playerGuess = promptForInt("Guess the ship's position (1 to " + riverSize + ")") - 1;

            if (playerGuess < 0 || playerGuess >= riverSize) {
                System.out.println("Your guess is out of bounds. Try a position within the river.");
                continue;
            }

            if (playerGuess == secondShipPosition && !secondShipFound) {
                System.out.println("Direct hit on the first ship!");
                river[playerGuess] = 1; // Mark as hit
                secondShipFound = true;
            } else if (playerGuess == firstShipStart && !firstShipFoundPart1) {
                System.out.println("Direct hit on part 1 of the size 2 ship!");
                river[playerGuess] = 2; // Mark as hit
                firstShipFoundPart1 = true;
            } else if (playerGuess == firstShipStart + 1 && !firstShipFoundPart2) {
                System.out.println("Direct hit on part 2 of the size 2 ship!");
                river[playerGuess] = 2; // Mark as hit
                firstShipFoundPart2 = true;
            } else if (river[playerGuess] == -1) {
            System.out.println("You have already checked this spot. Try somewhere else.");
        } else {
            System.out.println("Miss. No ship here.");
            river[playerGuess] = -1;
        }

        displayRiver(river, secondShipFound && firstShipFoundPart1 && firstShipFoundPart2);

    }

    System.out.println("Victory. You've found the hidden ships.");
    displayRiver(river, true);
    // code runs here

}//main
}

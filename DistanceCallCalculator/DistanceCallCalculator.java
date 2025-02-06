
/**
 * This program calculates the cost of a long-distance call based on the day of the week, the time the call starts,
 * and the call's duration.
 *
 * @author (Caelum Casserly)
 * @version (15/10/2024)
 */
import javax.swing.JOptionPane;
public class DistanceCallCalculator
{
    public static void main(String[] args) 
    {
        // Prompt user to input day of the week, start time and duration of the call
        String callTimeInput = JOptionPane.showInputDialog("Input the start time of the call (In 24 hour time e.g 13:40):");
        String dayOfTheWeek = JOptionPane.showInputDialog("Input the day of the week (Mon, Tue, Wed, Thu, Fri, Sat, Sun):");
        String numMinutesInput = JOptionPane.showInputDialog("Input the length of the call in minutes (Maximum minutes is 180):");
        // Parse the time and duration inputs
        int startHour = Integer.parseInt(callTimeInput.split(":")[0]);
        int startMinute = Integer.parseInt(callTimeInput.split(":")[1]);
        int duration = Integer.parseInt(numMinutesInput);

        // Validate duration
        if (duration < 1 || duration > 180) 
        {
            JOptionPane.showMessageDialog(null, "Invalid duration. It must be between 1 and 180 minutes.");
            return;
        }

        // Beginning of cost calculation
        double totalCost = 0.0;
        int remainingMinutes = duration;

        // Loop through each minute of the call to calculate based on the time of day and day of week
        while (remainingMinutes > 0) 
        {
            int presentHour = startHour;
            int presentMinute = startMinute;

            // Calculate rate based on the day and time
            double rate = 0.0;

            // Weekend rate 
            if (dayOfTheWeek.equalsIgnoreCase("Sat") || dayOfTheWeek.equalsIgnoreCase("Sun")) 
            {
                rate = 0.15;
            } 
            // Weekday rate and between certain hours
            else 
            {
                if (presentHour >= 8 && presentHour < 18) 
                {
                    rate = 0.40; 
                } 
                else 
                {
                    rate = 0.25;
                }
            }

            // Calculate the minutes until the next hour or the end of the call
            int minutesUntilNextHour = 60 - presentMinute;
            int minutesThisPortion = Math.min(remainingMinutes, minutesUntilNextHour);

            // Add the cost for these minutes
            totalCost += minutesThisPortion * rate;

            // Update remaining time and start time for the next hour
            remainingMinutes -= minutesThisPortion;
            startHour = (startHour + 1) % 24; // Move to the next hour, wrap around if needed
            startMinute = 0; // Reset minutes for the next hour
        }

        // Display the total cost
        JOptionPane.showMessageDialog(null, "The call will cost: €" + String.format("%.2f", totalCost));
    }
}


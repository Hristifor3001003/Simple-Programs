import java.util.Scanner;

/** @author Hristifor Sotirovski */

public class Main {

    public static void delayedPrint(String string)throws InterruptedException {
        for(int i = 0; i < string.length(); i++) {
            System.out.print(string.charAt(i));
            Thread.currentThread().sleep(30);
        }
    }


    public static void delayedPrintln(String string)throws InterruptedException {
        for(int i = 0; i < string.length(); i++) {
            System.out.print(string.charAt(i));
            Thread.currentThread().sleep(30);
        }
        System.out.println();
    }


    /** Here we are using recursive approach for computing GCD(a, b).
     *
     * @param a - The first integer.
     * @param b - The second integer.
     *
     * @return GCD(a, b).
     *
     * PRECONDITION - a, b are integers and a, b <= Integer.MAX_VALUE. a, b >= 0 and at least of a, b is not eqial to 0.
     * Otherwise the function might behave unpredictably.
     */

    public static int GCD(int a, int b) {


        if(a == 0) {
            return b;
        }
        if(b == 0) {
            return a;
        }
        if(a == b) {
            return a;
        }

        if(a > b) {
            return GCD(a - b, b);
        }
        else {
            return GCD(a, b - a);
        }
    }


    public static void main(String[] args)throws Exception {
        System.out.println();
        delayedPrintln("Hello how are you?");
        System.out.println();
        delayedPrintln("This program computes greatest common divisors of two positive integers, that you will enter for short.");
        delayedPrintln("Let's begin");
        System.out.println();

        boolean again = true;
        while(again) {
            System.out.println();
            Scanner scan = new Scanner(System.in);
            int a = 0, b = 0;
            boolean goodFirst = false; //  Signalize the correctnes of first input
            boolean goodSecond = false; // Signalize the correctnes of second input

            delayedPrint("Enter the first integer and then press enter: ");
            String s = scan.nextLine();
            String pattern = "^(-?[1-9][0-9]*)|(-?0)$"; // The inputs must match this regex, which is a regex for integer number.
            if (s.matches(pattern)) {
                try {
                    a = Integer.parseInt(s);
                }
                catch (Exception e) {
                    goodFirst = false;
                }
                if (a > 0)
                    goodFirst = true;
            }

            scan.reset();
            s = "";
            delayedPrint("Enter the second integer and than press enter: ");
            s = scan.nextLine();
            if (s.matches(pattern)) {
                try {
                    b = Integer.parseInt(s);
                }
                catch (Exception e) {
                    goodSecond = false;
                }
                if (b > 0)
                    goodSecond = true;
            }


            while (!(goodFirst && goodSecond)) { // If first or second input is/are not in correct format.
                if (!goodFirst && goodSecond) {// Case 1: first input is not OK, the other one is OK
                    scan.reset();
                    s = "";
                    System.out.println();
                    delayedPrintln("The first number you've entered is not in good format. ");
                    delayedPrintln("You should enter positive integer less or equal to " + Integer.MAX_VALUE);
                    delayedPrint("Please reenter the first number and press enter: ");
                    s = scan.nextLine();

                    if (s.matches(pattern)) {
                        try {
                            a = Integer.parseInt(s);
                        }
                        catch (Exception e) {
                            goodFirst = false;
                        }
                        if (a > 0)
                            goodFirst = true;
                    } else {
                        goodFirst = false;
                    }
                } else if (!goodFirst && !goodSecond) {// Case 2: both inputs are not OK

                    scan.reset();
                    s = "";
                    System.out.println();
                    delayedPrintln("The both numbers you've entered are in not good format.");
                    delayedPrintln("You should enter two positive integers less or equal to " + Integer.MAX_VALUE);
                    delayedPrint("Please reenter the first number and press enter: ");
                    s = scan.nextLine();


                    if (s.matches(pattern)) {
                        try {
                            a = Integer.parseInt(s);
                        } catch (Exception e) {
                            goodFirst = false;
                        }
                        if (a > 0)
                            goodFirst = true;
                    } else {
                        goodFirst = false;
                    }

                    scan.reset();
                    s = "";
                    System.out.println();
                    delayedPrint("Please reenter the second number and press enter: ");
                    s = scan.nextLine();

                    if (s.matches(pattern)) {
                        try {
                            b = Integer.parseInt(s);
                        } catch (Exception e) {
                            goodSecond = false;
                        }
                        if (b > 0)
                            goodSecond = true;
                    } else {
                        goodSecond = false;
                    }

                } else if (goodFirst && !goodSecond) {// First input is OK, the other one is not OK
                    scan.reset();
                    s = "";
                    System.out.println();
                    delayedPrintln("The second number you've entered is not in good format. ");
                    delayedPrintln("You should enter positive integer less or equal to " + Integer.MAX_VALUE);
                    delayedPrint("Please reenter the second number and press enter: ");
                    s = scan.nextLine();
                    if (s.matches(pattern)) {
                        try {
                            b = Integer.parseInt(s);
                        }
                        catch (Exception e) {
                            goodSecond = false;
                        }
                        if (b > 0)
                            goodSecond = true;
                    } else {
                        goodSecond = false;
                    }
                }
            }
            // Exiting the upper while loop guaranties that both inputs are in correct format and the validation is over

            System.out.println();
            delayedPrintln("The numbers you've entered are in good format.");
            System.out.println();
            try {
                delayedPrintln("The greatest common divisor of " + a + " and " + b + " is: " + GCD(a, b));
            }
            catch (StackOverflowError e) {
                System.out.println();
                delayedPrintln("An error has occured. The GCD cannot be computed, please try again. ");
            }

            again = false;
            delayedPrint("Would you like to compute again (y for yes) ? ");
            if (scan.nextLine().toLowerCase().equals("y")) {
                again = true;
                delayedPrintln("Fine. Let's go another time ");
            }
        }
        System.out.println();
        delayedPrintln("OK. Have a nice day");

    }
}
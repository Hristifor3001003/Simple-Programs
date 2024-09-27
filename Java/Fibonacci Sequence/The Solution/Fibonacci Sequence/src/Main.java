import java.util.Scanner;


/** @author Hristifor Sotirovski
 *
 *  Validation on input is also included
 */
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

    public static void main(String[] args)throws Exception {
        System.out.println();
        delayedPrintln("Hello there!");
        delayedPrintln("This program prints the first n terms of Fibonacci sequence.");
        delayedPrintln("The Fibonacci sequnce A[1], A[2], ..., A[n], ... is a sequence defined by following rules: ");
        delayedPrintln("A[1] = 0, A[2] = 1, and for n > 2 A[n] = A[n-1] + A[n-2]");
        delayedPrintln("You will now enter n (2 < n <= 80)");
        delayedPrintln("So let's begin: ");
        System.out.println();


        boolean again = true;

        while(again) {
            System.out.println();
            Scanner scan = new Scanner(System.in);
            boolean goodInput = false;
            delayedPrint("Enter the term number and then press enter : ");
            int n = 0;
            try {
                n = Integer.parseInt(scan.nextLine());
                if (n > 2 && n <= 80) {
                    goodInput = true;
                } else {
                    goodInput = false;
                }
            } catch (Exception e) {
                goodInput = false;
            }

            while (!goodInput) {
                scan.reset();
                System.out.println();
                delayedPrintln("The input you've entered is not in good format.");
                delayedPrintln("You should enter positive integer greater than 2 and smaller than 81 : ");
                delayedPrint("Please reenter the term number : ");
                try {
                    n = Integer.parseInt(scan.nextLine());
                    if (n > 2 && n <= 80) {
                        goodInput = true;
                    } else {
                        goodInput = false;
                    }
                } catch (Exception e) {
                    goodInput = false;
                }
            }


            long a = 0, b = 1;

            System.out.println();


            delayedPrintln("1 term : " + a);
            delayedPrintln("2 term : " + b);
            long next;

            for (int i = 3; i <= n; i++) {// The algorithm
                next = a + b;
                a = b;
                b = next;
                delayedPrintln(i + " term : " + next);
            }

            System.out.println();
            again = false;
            delayedPrint("Do you want to compute again? (y|Y - for YES) : ");
            if(scan.next().toLowerCase().equals("y")) {
                again = true;
                System.out.println();
                delayedPrintln("Great. Let's go one more time.");
            }

        }
        System.out.println();
        delayedPrintln("OK. Bye then...");
    }
}
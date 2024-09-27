
public class Main {

    /**
     * This method searched does the given big number have trailing nines. If no, then returns -1, or else returns the index of the first nine
	 . in the sequence of trailing nines. Example if the number is 123999 then he returns the index of
     * the first nine in the sequence of trailing nines, in this example the returned index is 3. If the number is
     * consisted only from nines, return 0. The statement "return 9999999;" will never be reached, he is here only to
     * prevent the compiler to give the error "Not all code paths return value".
     *
     * @param digits - The array that represents the (big) number.
     * @return -1 if the number does not have trailing zeroes, or else the first nine in the sequence of trailing nines.
     *
     * Time-Complexity is O(n) in worst case where n is the number of elements in digits array, O(1) in best case
     * where the number does not have trailing nines.
     */
    public static int getIndex(int[] digits) {
        if(digits[digits.length - 1] != 9) {
            return -1;
        }
        int i = 0;
        for(i = digits.length - 1; i >= 0; i--) {
            if(digits[i] != 9) {
                return i + 1;
            }
        }
        if(i == -1) {
            return 0;
        }
        return 9999999;
    }


    /** This method performs the incrementation.
     *
     * @param digits - The array that represent the (big) number.
     * @return - An array that represent incremented (big) number/
     *
     * Time-Complexity O(1) in best case where the number consist of one digit or does not have trailing nines.
     * Otherwise, O(n) where n is number of elements in "digits".
     */
    public static int[] plusOne(int[] digits) {
        if(digits.length == 1) {
            if(digits[0] == 9) {
                int[] incremented = {1, 0};
                return incremented;
            }
            digits[0]++;
            return digits;
        }// O(1)
        int[] incremented;
        if(getIndex(digits) == 0) {
            incremented = new int[digits.length + 1];// Here we have O(n) where n = digits.length; because Java must
            incremented[0] = 1;                      // initialize all n + 1 elements to 0, one by one.
            return incremented;
        }// O(n)
        else if(getIndex(digits) == -1) {
            digits[digits.length - 1]++;
            return digits;
        }// O(1)
        else {
            incremented = new int[digits.length];// Here also have O(n)
            int p = getIndex(digits); // O(n) in worst case
            for(int i = 0; i < p; i++) {
                incremented[i] = digits[i];
            }// O(p) , p < n
            incremented[p - 1]++;
            return incremented;
        }// O(n)

    }


    public static void main(String[] args) {


        int[] number1 = {1, 0, 0, 0};
        System.out.print("The number is: ");
        for(int i = 0; i < number1.length; i++) {
            System.out.print(number1[i]);
        }
        System.out.println();
        System.out.print("Incremented by one is: ");
        int[] number1inc = plusOne(number1);
        for(int i = 0; i < number1inc.length; i++) {
            System.out.print(number1inc[i]);
        }// 1000 + 1 = 1001

        System.out.println();
        System.out.println();

        int[] number2 = {1, 0, 0, 0, 3, 0, 9, 3, 1, 2, 9, 4, 9, 9, 9, 9};
        System.out.print("The number is: ");
        for(int i = 0; i < number2.length; i++) {
            System.out.print(number2[i]);
        }
        System.out.println();
        System.out.print("Incremented by one is: ");
        int[] number2inc = plusOne(number2);
        for(int i = 0; i < number2inc.length; i++) {
            System.out.print(number2inc[i]);
        }// 1000309312949999 + 1 = 1000309312950000

        System.out.println();
        System.out.println();

        int[] number3 = {9, 9, 9};
        System.out.print("The number is: ");
        for(int i = 0; i < number3.length; i++) {
            System.out.print(number3[i]);
        }
        System.out.println();
        System.out.print("Incremented by one is: ");
        int[] number3inc = plusOne(number3);
        for(int i = 0; i < number3inc.length; i++) {
            System.out.print(number3inc[i]);
        }// 999 + 1 = 1000

        System.out.println();
        System.out.println();

        int[] number4 = {6, 5, 5, 3, 6};
        System.out.print("The number is: ");
        for(int i = 0; i < number4.length; i++) {
            System.out.print(number4[i]);
        }
        System.out.println();
        System.out.print("Incremented by one is: ");
        int[] number4inc = plusOne(number4);
        for(int i = 0; i < number4inc.length; i++) {
            System.out.print(number4inc[i]);
        }// 65536 + 1 = 65537


    }
}
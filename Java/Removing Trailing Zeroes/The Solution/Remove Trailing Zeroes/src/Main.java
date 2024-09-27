
/**
 * @author Hristifor Sotirovski
 *
 * Note:
 * From leetcode:
 *
 * 756 / 756 test cases passed.
 * Status: Accepted
 * Runtime: 1 ms
 * Memory Usage: 43.6 MB
 *
 * This runtime beats 100% of Java Submissions
 */
public class Main {


    /** Removes trailing zeroes from a number num which is represented as a string.
     *
     * @param num - The number from who the trailing zeroes will be removed.
     *
     * @return - The number without trailing zeroes.
     *
     * @preconditions - 1 <= num.length <= 1000
     * num consists of only digits.
     * num doesn't have any leading zeros.
     */
    public static String removeTrailingZeros(String num) {
        if(num.length() == 1) {
            return num;
        }
        if(num.charAt(num.length() - 1) != '0') {
            return num;
        }
        else {
            int pos = num.length() - 2;
            while(num.charAt(pos) == '0') {
                pos--;
            }
            return num.substring(0, pos + 1);
        }
    }


    public static void main(String[] args) {
        System.out.println(removeTrailingZeros("123000000000")); // -> 123
        System.out.println(removeTrailingZeros("143.4300")); // -> 143.43
        System.out.println(removeTrailingZeros("-44.2300")); // -> -44.23
    }
}
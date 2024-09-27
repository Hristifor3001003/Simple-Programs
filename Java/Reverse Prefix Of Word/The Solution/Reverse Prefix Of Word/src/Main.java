/**
 * @author Hristifor Sotirovski
 *
 * Note:
 *
 * From leetcode
 * Runtime 0s - beats 100% of all submmisions
 */


public class Main {

    /**
     * Reverses a given string, so if x = x0x1...xn, the result of the method for this input will be y = xn...x2x1x0;
     *
     * @param str - The string which should be inversed.
     *
     * @return - The inversed string.
     */
    public static String reverse(String str) {
        if(str.length() == 1) {
            return str;
        }
        StringBuilder str1 = new StringBuilder();
        for(int i = str.length() - 1; i >= 0; i--) {
            str1.append(str.charAt(i));
        }
        return str1.toString();
    }


    /**
     * Reverses the prefix of the word, where ch is the last character in the prefix, and ch is first occurrence in string word.
     * @param word - The word whose prefix will be reversed.
     *
     * @param ch - The last character of the prefix of word, also first ocurrence in word.
     *
     * @return - word with reversed prefix.
     */
    public static String reversePrefix(String word, char ch) {
        int pos = word.indexOf(ch);
        if(pos != -1) {
            String str = word.substring(0, pos + 1);
            return reverse(str) + word.substring(pos + 1);
        }
        return word;
    }

    public static void main(String[] args) {
        System.out.println(reversePrefix("eatingbananas", 'g')); // -> gnitaebananas
        System.out.println(reversePrefix("i like to move it move it", 'e')); // -> ekil i to move it move it
    }
}
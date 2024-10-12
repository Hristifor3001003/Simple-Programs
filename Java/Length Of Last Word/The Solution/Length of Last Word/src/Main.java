
public class Main {

    public static int lengthOfLastWord(String s) {
        int index = s.length() - 1;

        while(s.charAt(index) == ' ') {
            index--;
        }

        int counter = 0;

        while(index >= 0 && s.charAt(index) != ' ' ) {
            counter++;
            index--;
        }

        return counter;

    }


    public static void main(String[] args) {
        String s = "    Worlda         ";
        System.out.println("The length of the last word is: " + lengthOfLastWord(s)); // 6
    }
}
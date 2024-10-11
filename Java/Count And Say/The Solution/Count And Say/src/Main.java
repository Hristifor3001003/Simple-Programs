
public class Main {
    public static String RLE(String str) {
        StringBuilder output = new StringBuilder("");

        int index = 0;

        while(index < str.length()) {
            if(index != str.length() - 1) {
                Integer counter = 1;
                Character c = str.charAt(index);
                while(index < str.length() - 1 && c.charValue() == str.charAt(index + 1)) {
                    counter++;
                    index++;
                }

                output.append(counter.toString());
                output.append(c.toString());
            }
            else {
                output.append("1" + ((Character)str.charAt(index)).toString());
            }
            index++;
        }

        return output.toString();
    }


    // An iterative solution
    public static String countAndSay(int n) {
        if(n == 1) {
            return "1";
        }
        else {
            String digitString = "1";

            for(int index = 1; index <= n - 1; index++) {
                digitString = RLE(digitString);
            }

            return digitString;

        }
    }

    public static void main(String[] args) {
        System.out.println("Count and Say of 4 is " + countAndSay(4));
    }
}
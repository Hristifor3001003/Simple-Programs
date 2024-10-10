
public class Main {
    public static int binarySearch(int[] array, int target, int left, int right) {
        if(left <= right) {
            int middle = left + (right - left) / 2;

            if(array[middle] == target) {
                return middle;
            }

            if(right - left == 1) {//  If the current subarray has two elements

                if(target < array[left]) {
                    return left;
                }

                if(array[left] < target && target < array[right]) {
                    return right;
                }

                if(target > array[right]) {
                    return right + 1;
                }
            }
            else if(right - left == 0) { // If the current subaray has one element

                if(target < array[left]) {
                    return left;
                }

                return left + 1;
            }

            if(target < array[middle]) {
                return binarySearch(array, target, left, middle - 1);
            }

            return binarySearch(array, target, middle + 1, right);
        }

        return -1; // This is never returned. It only serves to compiler not throw "missing return statement" error.
    }


    public static void main(String[] args) {
        int[] array = {1, 2, 3, 4, 5, 7};
        int target = 6;
        System.out.println("The index is: " + binarySearch(array, target, 0, array.length - 1));// -> 5
    }

}
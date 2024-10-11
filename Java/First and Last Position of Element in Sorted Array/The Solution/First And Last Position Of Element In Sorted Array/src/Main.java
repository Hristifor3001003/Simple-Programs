
public class Main {

    public static int binarySearch(int[] nums, int target, int left, int right) {

        if(left <= right) {
            int middle = left + (right - left) / 2;

            if(target == nums[middle]) {
                return middle;
            }

            if(target < nums[middle]) {
                return binarySearch(nums, target, left, middle - 1);
            }

            return binarySearch(nums, target, middle + 1, right);
        }

        return -1;
    }

    public static int findFirst(int[] nums, int index) {
        int index2 = index;

        while(index2 >= 0 && nums[index2] == nums[index]) {
            index2--;
        }

        return ++index2;
    }

    public static int findLast(int[] nums, int index) {
        int index2 = index;

        while(index2 <= nums.length - 1 && nums[index2] == nums[index]) {
            index2++;
        }

        return --index2;
    }

    public static int[] search(int[] nums, int target) {
        if(nums.length == 0) {
            return new int[] {-1, -1};
        }
        else {
            int index = binarySearch(nums, target, 0, nums.length - 1);
            if(index == -1) {
                return new int[] {-1, -1};
            }
            else {
                return new int[] {findFirst(nums, index), findLast(nums, index)};
            }
        }
    }

    public static void main(String[] args) {
        int[] nums = {5, 7, 7, 8, 8, 10};
        int target = 8;

        System.out.println("[" + search(nums, target)[0] + ", " + search(nums, target)[1] + "]"); // [3, 4]
    }
}
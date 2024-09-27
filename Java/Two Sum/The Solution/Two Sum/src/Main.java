/**
 * @author Hristifor Sotirovski
 */
public class Main {

    /**
     * This is the well known merge-sort algorithm which sorts a given array in O(nLog(n)) time, but also has
     * memory-complexity of O(n) time, where n is the number of elements in the array.
     *
     * This method for a given array A, and indices p, q (p < r), sorts the portion of array starting with index p,
     * and ending with index r, i.e. the array A[p], A[p + 1], ..., A[r]
     *
     * @param A - the array which portion A[p], A[p + 1], ..., A[r] to be sorted.
     * @param p - the beginning index
     * @param r - the ending index
     */
    public static void mergeSort(ArrayElement[] A, int p, int r) {
        if(p < r) {
            int q = (int)Math.floor((p + r) / 2.0);
            mergeSort(A, p, q);
            mergeSort(A, q + 1, r);
            merge(A, p, q, r);
        }
    }


    /**
     * This method is used in merge-sort method which merges two sorted sub-arrays from array A,
     * i.e. the first sub-array is A[p], A[p + 1], ..., A[q] which have q - p + 1 elements, and the second
     * sub-array is A[q + 1], A[q + 2], ..., A[r] which have r - q elements.
     *
     * @param A - The array which sub-arrays to be merged.
     * @param p - The beginning index of the first sub-array.
     * @param q - The ending index of the first sub-array, and q + 1 is the beginning index of the second sub array.
     * @param r - The ending index of the second sub-array.
     *
     * Also merged sub-arrays are then copied in the original array A.
     */
    private static void merge(ArrayElement[] A, int p, int q, int r) {
        int n1 = q - p + 1;
        int n2 = r - q;

        ArrayElement[] L = new ArrayElement[n1];
        ArrayElement[] R = new ArrayElement[n2];

        int i = 0;
        int j = 0;

        for(i = 0; i < n1; i++) {
            L[i] = new ArrayElement(A[p + i].getIndex(), A[p + i].getValue());
        }
        for(j = 0; j < n2; j++) {
            R[j] = new ArrayElement(A[q + j + 1].getIndex(), A[q + j + 1].getValue());

        }

        i = 0;
        j = 0;
        for(int k = p; k <= r; k++) {
            if(i >= n1) {
                A[k].setValue(R[j].getValue());
                A[k].setIndex(R[j].getIndex());
                j++;
            }
            else if(j >= n2) {
                A[k].setValue(L[i].getValue());
                A[k].setIndex(L[i].getIndex());
                i++;
            }
            else if(L[i].getValue() <= R[j].getValue()) {
                A[k].setValue(L[i].getValue());
                A[k].setIndex(L[i].getIndex());
                i++;
            }
            else {
                A[k].setValue(R[j].getValue());
                A[k].setIndex(R[j].getIndex());
                j++;
            }

        }
    }


    /**
     * This is also well known binary-search algorithm which searches a given value "v" in array "arr", from index "from",
     * to index "to" in the array. If the value "val" is not in the array "arr", -1 is returned, but if value "val" is
     * in the array, his index is returned. This algorithm only works if the array "arr" is sorted. Time Complexity of
     * this algorithm is O(log(n)) where n is the number of elements in array.
     *
     * @param arr - The array on which the searching will be performed.
     * @param v - The value which will be searched.
     * @param from - The beginning index of the portion of array.
     * @param to - The ending index of the portion of array.
     * @return - The index of "v" if v is in the array, otherwise -1;
     *
     * @preconditions
     * from, to must be valid indices.
     * array "arr" must be sorted.
     * Otherwise, the behavior of the algorithm is unknown.
     */
    public static int binarySearch(ArrayElement[] arr, int v, int from, int to) {
        if(from == to) {
            if(arr[from].getValue() == v) {
                return arr[from].getIndex();
            }
            else {
                return -1;
            }
        }
        else {
            int n = to - from + 1;
            int k = n / 2;
            if(v == arr[from + k - 1].getValue()) {
                return arr[from + k - 1].getIndex();
            }
            else if (v == arr[from + k].getValue()) {
                return arr[from + k].getIndex();
            }
            else if(v < arr[from + k - 1].getValue()) {
                return binarySearch(arr, v, from, from + k - 1);
            }
            else {
                return binarySearch(arr, v, from + k, to);
            }
        }
    }

    /**
     * This method is the solution of the exercise. The challenge is that Time-Complexity of this method to be lower
     * than O(n^2). With a little analysis of the algorithm, can be obtained that this algorithm runs in O(nlog(n)) time,
     * which is lower than O(n^2) because limit(nlog(n) / n^2) is 0, when n goes to +infinity.
     *
     * @param nums - The array in which we will search for two elements num[x], and num[y] such that num[x] + num[y] = target.
     * @param target - The target number/
     * @return Two element array with the indices x, y.
     */
    public static int[] twoSum(int[] nums, int target) {
        var Nums = new ArrayElement[nums.length];
        for(int i = 0; i < nums.length; i++) {
            Nums[i] = new ArrayElement(i, nums[i]);
        } // O(n)
        mergeSort(Nums, 0, nums.length - 1); //O(nlog(n)
        int[] indices = new int[2];

        int pos1 = 0;
        int pos2 = 0;
        for(int i = 0; i < nums.length - 1; i++) {
            pos1 = binarySearch(Nums, target - Nums[i].getValue(), i + 1, nums.length - 1);// O(log(n))
            pos2 = Nums[i].getIndex();
            if(pos1 != -1) {
                break;
            }
        }// O(nlog(n)
        indices[0] = pos1;
        indices[1] = pos2;
        return indices;
    }


    public static void main(String[] args) {
        int[] arr = {11, 7, 2, 15};
        int target = 9;

        int[] sol = twoSum(arr, target);

        System.out.println("The first index is: " + sol[0] + ", and the first value is: " + arr[sol[0]]); // 1 and 7
        System.out.println("The second index is " + sol[1] + ", and the second value is: " + arr[sol[1]]);// 2 and 2
    }
}

class ArrayElement {
    private int index;
    private int value;

    public ArrayElement() {
    }

    public ArrayElement(int index, int value) {
        this.index = index;
        this.value = value;
    }

    public int getIndex(){ return index; }
    public int getValue(){ return value; }

    public void setIndex(int index) { this.index = index; }
    public void setValue(int value) { this.value = value; }
}
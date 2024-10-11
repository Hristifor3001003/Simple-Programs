
public class Main {

    public static void rotate(int[][] matrix) {

        // Transposing the matrix
        for(int i = 0; i < matrix.length; i++) {
            for(int j = i + 1; j < matrix.length; j++) {
                int tmp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = tmp;

            }
        }

        // Reversing the columns
        for(int i = 0; i < matrix.length; i++) {
            for(int j = 0; j < matrix.length / 2; j++) {
                int tmp = matrix[i][j];
                matrix[i][j] = matrix[i][matrix.length - (j + 1)];
                matrix[i][matrix.length - (j + 1)] = tmp;
            }
        }
    }



    public static void main(String[] args) {
        int[][] matrix = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};

        System.out.println("The input matrix is: ");
        for(int i = 0; i < matrix.length; i++) {
            for(int j = 0; j < matrix.length; j++) {
                System.out.print(matrix[i][j] + " ");
            }
            System.out.println();
        }

        System.out.println();System.out.println();

        rotate(matrix);

        System.out.println("The matrix rotated by 90 deg clockwise is: ");
        for(int i = 0; i < matrix.length; i++) {
            for(int j = 0; j < matrix.length; j++) {
                System.out.print(matrix[i][j] + " ");
            }
            System.out.println();
        }
    }
}
namespace Sort_Colors
{
    internal class Program
    {





        public static int CheckForZeroes(int[] nums, int leftPointer)
        {
            while(leftPointer < nums.Length && nums[leftPointer] == 0) 
            {
                leftPointer++;
            }

            return leftPointer;
        }

        public static int CheckForTwos(int[] nums, int rightPointer)
        {
            while(rightPointer >= 0 && nums[rightPointer] == 2)
            {
                rightPointer--;
            }

            return rightPointer;
        }

        public static void TransferLeft(int[] nums, int index, int leftPointer)
        {
            for(int i = index; i > leftPointer; i--)
            {
                nums[i] = nums[i - 1];
            }

            nums[leftPointer] = 0;
        }

        public static void TransferRight(int[] nums, int index, int rightPointer)
        {
            for(int i = index; i < rightPointer; i++)
            {
                nums[i] = nums[i + 1];
            }

            nums[rightPointer] = 2;
        }


        public static void SortColors(int[] nums)
        {
            int leftPointer = 0;
            int rightPointer = nums.Length - 1;

            leftPointer = CheckForZeroes(nums, leftPointer);
            if(leftPointer == nums.Length)
            {
                return;
            }

            rightPointer = CheckForTwos(nums, rightPointer);
            if(rightPointer == -1)
            {
                return;
            }

            int index = leftPointer;

            while(index <= rightPointer)
            {
                if (nums[index] == 0)
                {
                    TransferLeft(nums, index, leftPointer);
                    index++;
                    leftPointer++;

                }
                else if (nums[index] == 2)
                {
                    TransferRight(nums, index, rightPointer);
                    rightPointer--;
                }
                else
                {
                    index++;
                }
            }



        }
        static void Main(string[] args)
        {
            int[] colors = {2, 2, 2, 2, 2, 2, 2, 2, 2,  1, 2, 0, 0, 0, 2, 1, 2, 0, 2, 0, 1, 1, 1 };

            SortColors(colors);

            Console.Write(colors[0]);
            for(int i = 1; i < colors.Length; i++)
            {
                Console.Write(", " + colors[i]);
            }

            


        }
    }
}

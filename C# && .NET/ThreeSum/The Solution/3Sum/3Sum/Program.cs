using System.Collections;
using System.Globalization;

namespace _3Sum
{

    public class MyList : IList<IList<int>>
    {
        // Internal backing field (using List<List<int>> for simplicity)
        private List<IList<int>> _list = new List<IList<int>>();

        // Implementing the indexer (this[] allows accessing list elements)
        public IList<int> this[int index]
        {
            get => _list[index];
            set => _list[index] = value;
        }

        // Implementing the Count property
        public int Count => _list.Count;

        // Implementing the IsReadOnly property (for this example, we'll say it's not read-only)
        public bool IsReadOnly => false;

        // Implementing Add method
        public void Add(IList<int> item)
        {
            _list.Add(item);
        }

        // Implementing Clear method
        public void Clear()
        {
            _list.Clear();
        }

        // Implementing Contains method
        public bool Contains(IList<int> item)
        {
            return _list.Contains(item);
        }

        // Implementing CopyTo method
        public void CopyTo(IList<int>[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        // Implementing GetEnumerator
        public IEnumerator<IList<int>> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        // Implementing IndexOf method
        public int IndexOf(IList<int> item)
        {
            return _list.IndexOf(item);
        }

        // Implementing Insert method
        public void Insert(int index, IList<int> item)
        {
            _list.Insert(index, item);
        }

        // Implementing Remove method
        public bool Remove(IList<int> item)
        {
            return _list.Remove(item);
        }

        // Implementing RemoveAt method
        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        // Explicit non-generic interface implementation (IEnumerable)
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }

    }


    internal class Program
    {

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> triplets = new MyList();

            Array.Sort(nums);

            for(int i = 0; i <= nums.Length - 2; i++)
            {
                if(i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int l = i + 1;
                int r = nums.Length - 1;

                while(l < r)
                {
                    int total = nums[i] + nums[l] + nums[r];

                    if(total < 0)
                    {
                        l++;
                    }
                    else if(total > 0)
                    {
                        r--;
                    }
                    else
                    {
                        List<int> triplet = [nums[i], nums[l], nums[r]];
                        triplets.Add(triplet);

                        while(l < r && nums[l] == triplet[1])
                        {
                            l++;
                        }
                        while(l < r && nums[r] == triplet[2])
                        {
                            r--;
                        }
                    }
                }
            }

            return (IList<IList<int>>)triplets;

            

        }



        static void Main(string[] args)
        {
            int[] nums = { -6, -7, -8, 1, -5, 1, 2, -5, 3, 4, 10, 14 };

            MyList list = (MyList)ThreeSum(nums);

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i][0] + " " + list[i][1] + " " + list[i][2]);
            }
        }
    }
}

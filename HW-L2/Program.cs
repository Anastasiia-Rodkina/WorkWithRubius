using System;

namespace HWl2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write( "Укажите размер массива:");
            string inpn = Console.ReadLine();
            inpn = inpn == "" ? "0" : inpn ?? "0";
            
            int n = int.Parse(inpn);
            
            int[] nums = new int [n];
            
            
            for (int i = 0; i < n; i++)
            {
                Console.Write( "Введите элемент массива:");
                nums [i] = int.Parse(Console.ReadLine());
            }
            
            Array.Sort(nums);
            int maxValue = nums[nums.Length-1];
            
            int k = nums.Length-2;
            int max2Value = nums[0];
            
            for (int i = k; i >= 0; i--)
            {
                int tempValue = nums[i];
                if (tempValue < maxValue)
                {
                    max2Value = tempValue;
                    break;
                }
            }
            
            Console.WriteLine(max2Value);
        }
    }
}
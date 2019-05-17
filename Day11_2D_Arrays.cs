using System;

class Solution 
    static int Hourglass(int[][] arr)
    {
        int largest = -63;
        int j = 0;
        for (int i = 0; i < arr.Length-2; i++)
        {
            for (j = 0; j < arr.Length-2; j++)
            {
            int x = arr[i][j];
            int y = arr[i][j+1];
            int z = arr[i][j+2];
            int xx = arr[i+1][j+1];
            int yy = arr[i+2][j];
            int zz = arr[i+2][j+1];
            int n = arr[i+2][j+2];
            
                int hgSum = (x + y + z + xx + yy + zz + n);
            
                if (hgSum > largest)
                {
                    largest = hgSum;
                }
            }
        }
        return largest;
    }
    static void Main(string[] args) {
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }
        int result = Hourglass(arr);
        Console.Write(result);
    }
}


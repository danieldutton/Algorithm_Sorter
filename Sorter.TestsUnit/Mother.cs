namespace Sorter._UnitTests
{
    public static class Mother
    {
        public static int[] GetTenUnsortedIntegers()
        {
            return new[]{7, 1, 4, 3, 6, 2, 8, 5, 10, 9};
        }

        public static int[] GetTenSortedIntegers()
        {
            return new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        }

        public static int[] GetOneHundredSortedIntegers()
        {
            return new[]
                {
                    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                    21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
                    41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 
                    61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80,
                    81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100
                };
        }

        public static int[] GetOneHundredUnSortedIntegers()
        {
            return new[]
                {
                    20, 14, 13, 7, 5, 6, 4, 8, 9, 10, 11, 12, 3, 2, 15, 16, 17, 18, 19, 1,
                    21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
                    41, 42, 43, 44, 45, 88, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 
                    61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80,
                    81, 82, 83, 84, 85, 86, 87, 46, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100
                };
        }

        public static long GetTestStartTime()
        {
            return 314;
        }

        public static long GetTestStopTime()
        {
            return 414;
        }

        public static long GetTestElapsedTime()
        {
            return 100;
        }

        public static string GetFaultFreeTestString()
        {
            return "100 \n 200 \n 300 \n 400 \n 500";    
        }

        public static string GetFaultyTestString()
        {
            return "100 \n 200 \n 300 \n 400 500";
        }
    }
}

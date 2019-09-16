namespace HackerRank
{
    public class MainCountingValleys
    {
        public static int CountingValleys(int n, string s)
        {
            var actualHeight = 0;
            var valleyCount = 0;
            foreach (var direction in s)
            {
                if (direction == 'U')
                {
                    actualHeight++;
                }
                else
                {
                    actualHeight--;
                }


                // Checks if direction is down e first time in down direction
                if (actualHeight == -1 && direction == 'D')
                {
                    valleyCount++;
                }
            }

            return valleyCount;
        }
    }
}

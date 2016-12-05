namespace Codility.FrogJump
{
    class Solution
    {
        public int solution(int X, int Y, int D)
        {
            int dist = Y - X;
            double times = dist/(double)D;
            dist = (int)times;
            return times - dist > 0 ? dist + 1 : dist;
        }
    }
}

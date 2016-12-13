namespace Codility
{
    using System;
    using BracketsRotation;

    class Program
    {
        static void Main(string[] args)
        {
            MaxDoubleSliceSum();
        }

        static void MaxDoubleSliceSum()
        {
            Action<int[], int> action = (a, result) =>
            {
                var s = new MaxDoubleSliceSum.Solution();
                int res = s.solution(a);

                if (res != result)
                    throw new Exception();
            };

            action(new[] { 3, 2, 6, -1, 4, 5, -1, 2 }, 17);
            action(new[] { 5, 17, 0, 3 }, 17);
            action(new[] { 5,-2,17,3 }, 17);
        }

        static void MaxSliceSum()
        {
            Action<int[], int> action = (a, result) =>
            {
                var s = new MaxSliceSum.Solution();
                int res = s.solution(a);

                if (res != result)
                    throw new Exception();
            };

            action(new[] {3, 2, -6, 4, 0}, 5);
        }
        static void MaxProfit()
        {
            Action<int[], int> action = (a, result) =>
            {
                var s = new MaxProfit.Solution();
                int res = s.solution(a);

                if (res != result)
                    throw new Exception();
            };

            action(new[] {23171, 21011, 21123, 21366, 21013, 21367}, 356);
            action(new[] {10, 9, 9, 8, 7, 6}, 0);
        }

        static void EquiLeader()
        {
            Action<int[], int> action = (a, result) =>
            {
                var s = new EquiLeader.Solution();
                int res = s.solution(a);

                if (res != result)
                    throw new Exception();
            };

            action(new[] { 4, 4, 2, 5, 3, 4, 4, 4 }, 3);
            action(new[] { 0 }, 0);
            action(new[] { 0, 0 }, 1);
            action(new[] { 4, 3, 4, 4, 4, 2 }, 2);
            action(new[] { 1, 2, 1, 1, 2, 1 }, 3);
            action(new[] { 1, 1,1 }, 2);
        }

        static void Dominator()
        {
            Action<int[], int> action = (a, result) =>
            {
                var s = new Dominator.Solution();
                int res = s.solution(a);

                if (res != result)
                    throw new Exception();
            };

            action(new[] {3, 4, 3, 2, 3, -1, 3, 3}, 7);
        }

        static void Fish()
        {
            Action<int[], int[], int> action = (a, b, result) =>
            {
                var s = new Fish.Solution();
                int res = s.solution(a, b);

                if (res != result)
                    throw new Exception();
            };

            action(new[] { 4, 3, 2, 1, 5 }, new[] { 0, 1, 0, 0, 0 }, 2);
            action(new[] { 4, 3, 2, 1, 5 }, new[] { 1, 0, 0, 0, 0 }, 1);
            action(new[] { 4, 3, 2, 1, 5 }, new[] { 1, 1, 0, 0, 1 }, 3);
            action(new[] { 4, 3, 2, 1, 5 }, new[] { 0, 0, 1, 1, 0 }, 3);
        }

        static void Nesting()
        {
            Action<string, int> action = (s, result) =>
            {
                var sol = new Nesting.Solution();
                int res = sol.solution(s);

                if (res != result)
                    throw new Exception();
            };

            action("(()(())())", 1);
            action("())", 0);
            action("(((", 0);
        }

        static void Brackets()
        {
            Action<string, int> action = (s, result) =>
            {
                var sol = new Brackets.Solution();
                int res = sol.solution(s);

                if (res != result)
                    throw new Exception();
            };

            action("{[()()]}", 1);
            action("([)()]", 0);
            action("{{{", 0);
        }

        static void StoneWall()
        {
            Action<int[], int> action = (a, result) =>
            {
                var s = new StoneWall.Solution();
                int res = s.solution(a);

                if (res != result)
                    throw new Exception();
            };

            action(new[] { 1 }, 1);
            action(new[] { 1, 2, 1, 2, 1 }, 3);
            action(new[] { 1, 1, 1, 1, 1, 1, 1 }, 1);
            action(new[] { 1, 2, 4, 3, 2, 2, 1 }, 4);
            action(new[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 }, 7);
            action(new[] { 2, 5, 1, 4, 6, 7, 9, 10, 1 }, 8);
        }

        static void NumberOfDiscIntersections()
        {
            Action<int[], int> action = (a, result) =>
            {
                var s = new NumberOfDiscIntersections.Solution();
                int res = s.solution(a);

                if (res != result)
                    throw new Exception();
            };

            action(new[] {1, 5, 2, 1, 4, 0}, 11);
            action(new[] {1,1,1}, 3);
        }

        static void MaxProductOfThree()
        {
            Action<int[], int> action = (a, result) =>
            {
                var s = new MaxProductOfThree.Solution();
                int res = s.solution(a);

                if (res != result)
                    throw new Exception();
            };

            action(new[] { -3, 1, 2, -2, 5, 6 }, 60);
            action(new[] { -5, 5, -5, 4 }, 125);
            action(new[] { -5, -6, -4, -7, -10 }, -120);
        }

        static void Triangle()
        {
            Action<int[], int> action = (a, result) =>
            {
                var s = new Triangle.Solution();
                int res = s.solution(a);

                if (res != result)
                    throw new Exception();
            };

            action(new[] { 10, 2, 5, 1, 8, 20 }, 1);
            action(new[] { 10, 50, 5, 1 }, 0);
        }

        static void GenomicRangeQuery()
        {
            Action<string, int[], int[], int[]> action = (s, p, q, result) =>
            {
                var sol = new GenomicRangeQuery.Solution();
                int[] res = sol.solution(s, p, q);

                for (int i = 0; i < result.Length; i++)
                {
                    if (res[i] != result[i])
                        throw new Exception();
                }
            };

            action("CAGCCTA", new[] { 2, 5, 0 }, new[] { 4, 5, 6 }, new[] { 2, 4, 1 });
            action("A", new[] { 0 }, new[] { 0 }, new[] { 1 });
            action("AC", new[] { 0, 0, 1 }, new[] { 0, 1, 1 }, new[] { 1, 1, 2 });
        }

        static void MinAvgTwoSlice()
        {
            Action<int[], int> action = (a, result) =>
            {
                var s = new MinAvgTwoSlice.Solution();
                int res = s.solution(a);

                if (res != result)
                    throw new Exception();
            };

            //action(new[] {4, 2, 2, 5, 1, 5, 8}, 1);
            //action(new[] {1,2,3}, 0);
            action(new[] { -3, -5, -8, -4, -10 }, 2);
        }

        static void PassingCars()
        {
            Action<int[], int> action = (a, result) =>
            {
                var s = new PassingCars.Solution();
                int res = s.solution(a);

                if (res != result)
                    throw new Exception();
            };

            action(new[] { 0, 1, 0, 1, 1 }, 5);
            action(new[] { 1, 1, 0, 1, 1 }, 2);
            action(new[] { 1, 1, 0, 1, 1, 0, 0, 1, 0 }, 5);
        }

        static void CountDiv()
        {
            Action<int, int, int, int> action = (a, b, c, d) =>
            {
                var s = new CountDiv.Solution();
                int res = s.solution(a, b, c);

                if (res != d)
                    throw new Exception();
            };

            action(6, 11, 2, 3);
            action(11, 345, 17, 20);
            action(0, 1, 11, 1);
            action(10, 10, 5, 1);
        }

        static void MaxCounters()
        {
            Action<int, int[], int[]> action = (n, a, result) =>
            {
                var s = new MaxCounters.Solution();
                int[] res = s.solution(n, a);

                if (res.Length != result.Length)
                    throw new Exception();

                for (int i = 0; i < res.Length; i++)
                {
                    if (result[i] != res[i])
                        throw new Exception();
                }
            };

            action(5, new[] { 3, 4, 4, 6, 1, 4, 4 }, new[] { 3, 2, 2, 4, 2 });
        }

        static void MissingInteger()
        {
            Action<int[], int> action = (a, result) =>
            {
                var s = new MissingInteger.Solution();
                int res = s.solution(a);

                if (res != result)
                    throw new Exception();
            };

            action(new[] { 1, 3, 6, 4, 1, 2 }, 5);
            action(new[] { 2, 3, 6, 4, 4, 2 }, 1);
            action(new[] { 0, 3, 6, 4, 4, 2 }, 1);
            action(new[] { -1, 3, 6, 4, 4, 2 }, 1);
        }

        static void FrogRiverOne()
        {
            Action<int, int[], int> action = (x, a, result) =>
            {
                var s = new FrogRiverOne.Solution();
                int res = s.solution(x, a);

                if (res != result)
                    throw new Exception();
            };


            action(5, new[] { 1, 3, 1, 4, 2, 3, 5, 4 }, 6);
            action(5, new[] { 5, 3, 1, 4, 2, 3, 5, 4 }, 4);
        }

        static void PermCheck()
        {
            Action<int[], int> action = (a, result) =>
            {
                var s = new PermCheck.Solution();
                int res = s.solution(a);

                if (res != result)
                    throw new Exception();
            };

            action(new[] { 4, 1, 3, 2 }, 1);
            action(new[] { 4, 1, 3 }, 0);
        }

        static void TapeEquilibrium()
        {
            Action<int[], int> action = (a, result) =>
            {
                var s = new TapeEquilibrium.Solution();
                int res = s.solution(a);

                if (res != result)
                    throw new Exception();
            };

            action(new[] { 3, 1, 2, 4, 3 }, 1);
        }

        static void PermMissingElem()
        {
            Action<int[], int> a = (ar, result) =>
            {
                var s = new PermMissingElem.Solution();
                int res = s.solution(ar);

                if (res != result)
                    throw new Exception();
            };

            a(new[] { 2, 3, 1, 5 }, 4);
        }

        static void FrogJump()
        {
            Action<int, int, int, int> a = (x, y, d, result) =>
            {
                var s = new FrogJump.Solution();
                int res = s.solution(x, y, d);

                if (res != result)
                    throw new Exception();
            };

            a(10, 85, 30, 3);
        }

        static void OddOccurrencesInArray()
        {
            Action<int[], int> m = (a, result) =>
            {
                var s = new OddOccurrencesInArray.Solution();
                int res = s.solution(a);

                if (res != result)
                {
                    throw new Exception();
                }
            };

            m(new[] { 9, 3, 9, 3, 9, 7, 9 }, 7);
            m(new[] { 42 }, 42);
        }

        static void CyclicRotation()
        {
            Action<int[], int, int[]> method = (array, k, result) =>
            {
                var s = new CyclicRotation.Solution();
                int[] res = s.solution(array, k);

                for (int i = 0; i < array.Length; i++)
                {
                    if (result[i] != res[i])
                    {
                        throw new Exception();
                    }
                }
            };

            method(new[] { 3, 8, 9, 7, 6 }, 3, new[] { 9, 7, 6, 3, 8 });
        }

        static void BinaryGap()
        {
            Action<int, int> invoke = (n, result) =>
            {
                var s = new BinaryGap.Solution();
                int res = s.solution(n);

                if (res != result)
                    throw new Exception();
            };

            invoke(9, 2);
            invoke(529, 4);
            invoke(20, 1);
            invoke(15, 0);
            invoke(1041, 5);
        }

        static void BracketsRotation()
        {
            BracketsRotation(")))(((", 0, 0);
            BracketsRotation(")))(((", 2, 4);
            BracketsRotation(")))((()", 2, 6);
            BracketsRotation("((((", 2, 4);
            BracketsRotation("((((", 0, 0);
            BracketsRotation("(((()))(", 2, 8);
            BracketsRotation("()", 2, 2);
            BracketsRotation("()", 0, 2);
            BracketsRotation("", 20, 0);
            BracketsRotation("((((())", 1, 6);
            BracketsRotation("))()(()(()", 2, 10);
            BracketsRotation(")(", 1, 0);
            BracketsRotation("(()))))(()((()))", 1, 8);
            BracketsRotation("(()()()))))(()((()))", 1, 10);
            BracketsRotation("()(()))()(((", 2, 10);
        }

        static void Sorting()
        {
            Sorting(new[] { 1, 2, 3, 2, 5, 2 }, 4);
            Sorting(new[] { 1, 2, 3, 4, 5, 6 }, 0);
            Sorting(new[] { 1, 2, 3, 4, 5, 6, 5 }, 2);
            Sorting(new[] { 2, 1, 2, 3, 2, 5, 2 }, 7);
            Sorting(new[] { 1, 2, 3, 2, 5, 2, 2 }, 5);
            Sorting(new[] { 1, 2, 6, 5, 5, 8, 9 }, 3);
            Sorting(new[] { 1, 2, 3, 100, 50, 60, 70 }, 4);
            Sorting(new[] { 1, 2, 3, 100, 50, 60, 70, 101 }, 4);
            Sorting(new[] { 1, 2, 3, 100, 50, 60, 70, 71 }, 5);
            Sorting(new[] { 1, 2, 3, 100, 50, 60, 70, 101, 100 }, 6);
        }

        static void Sorting(int[] A, int result)
        {
            var s = new Sorting.Solution();

            int res = s.solution(A);

            if (res != result)
                throw new Exception();
        }

        static void Nails()
        {
            Hammer(new[] { 1, 1, 3, 3, 3, 4, 5, 5, 5, 5 }, 2, 5);
            Hammer(new[] { 1, 1, 3, 3, 3, 4 }, 2, 4);
            Hammer(new[] { 1, 1, 3, 3, 3 }, 100, 5);
            Hammer(new[] { 1 }, 0, 1);
            Hammer(new[] { 1 }, 100, 1);
        }

        static void Hammer(int[] A, int K, int result)
        {
            var s = new Nails.Solution();

            int res = s.solution(A, K);

            if (res != result)
                throw new Exception();
        }

        static void BracketsRotation(string S, int k, int res)
        {
            var s = new Solution5();

            int t = s.solution(S, k);
            //s.Dispose();

            if (t != res)
                throw new Exception($"For: {S} input wrong result. {t}(wrong) != {res}(good)");
        }
    }
}

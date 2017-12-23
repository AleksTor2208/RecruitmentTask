using System;

namespace ASP_recruitment
{
    public class CarRefuelingTimeCalculator
    {
		// Task # 3
		public static string TimeCount(int[] cars, int pumps)
        {
            if (cars.Length == 0) return "0";
            var carsOnRefuiling = new int[pumps];
            var resultTime = 0;
            var currCarIndex= cars.Length - 1;          

            while (currCarIndex >= 0)
            {
                SetCarsOnRefuiling(cars, carsOnRefuiling, ref currCarIndex);
                var shortestTime = GetMinimalTime(carsOnRefuiling);
                if (IsEmptyPump(carsOnRefuiling))
                {
                    var maxTimeLeft = GetMaxTime(carsOnRefuiling);
                    resultTime += maxTimeLeft;
                    break;
                }
                var minTimePointer = Array.IndexOf(carsOnRefuiling, shortestTime);
                var firstCarLeft = carsOnRefuiling[minTimePointer];
                resultTime += firstCarLeft;
                SubtractTime(carsOnRefuiling, firstCarLeft);
            }
            return resultTime.ToString();
        }

        private static int GetMaxTime(int[] cars)
        {
            var maxTime = int.MinValue;
            foreach (var timeOnRef in cars)
            {
                if (timeOnRef > maxTime)
                {
                    maxTime = timeOnRef;
                }
            }
            return maxTime;
        }

        private static bool IsEmptyPump(int[] cars)
        {
            foreach (var car in cars)
            {
                if (car == 0)
                    return true;
            }
            return false;
        }

        private static void SetCarsOnRefuiling(int[] cars, int[] carsOnRefuiling, ref int currentCar)
        {
            for (int i = 0; i < carsOnRefuiling.Length; i++)
            {
                if (carsOnRefuiling[i] == 0)
                {
                    carsOnRefuiling[i] = cars[currentCar];
                    if (currentCar == 0) return;
                    currentCar--;
                } 
            }
        }

        private static void SubtractTime(int[] cars, int timePassed)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] -= timePassed;
            }
        }

        private static int GetMinimalTime(int[] cars)
        {
            var minTime = int.MaxValue;
            for (int index = 0; index < cars.Length; index++)
            {
                if (cars[index] < minTime)                
                    minTime = cars[index];                
            }
            return minTime;           
        }
    }
}

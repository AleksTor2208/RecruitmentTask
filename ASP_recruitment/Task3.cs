using System;

namespace ASP_recruitment
{
    class Task3
    {
        public static string TimeCount(int[] cars, int pumps)
        {
            if (cars.Length == 0) return "0";
            var carsOnRefuiling = new int[pumps];
            var resultTime = 0;
            var currentCar= cars.Length - 1;          

            while (currentCar >= 0)
            {
                SetCarsOnRefuiling(cars, carsOnRefuiling, ref currentCar);
                var minTime = GetMinRefTime(carsOnRefuiling);
                if (OnePumpIsEmpty(carsOnRefuiling))
                {
                    var maxTimeLeft = GetMaxTime(carsOnRefuiling);
                    resultTime += maxTimeLeft;
                    break;
                }
                var minTimePointer = Array.IndexOf(carsOnRefuiling, minTime);
                var firstCarLeft = carsOnRefuiling[minTimePointer];
                resultTime += firstCarLeft;
                SubtractPassedTime(carsOnRefuiling, firstCarLeft);
            }
            return resultTime.ToString();
        }

        private static int GetMaxTime(int[] cars)
        {
            var maxTime = 0;
            foreach (var timeOnRef in cars)
            {
                if (timeOnRef > maxTime)
                {
                    maxTime = timeOnRef;
                }
            }
            return maxTime;
        }

        private static bool OnePumpIsEmpty(int[] cars)
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

        private static void SubtractPassedTime(int[] cars, int timePassed)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] -= timePassed;
            }
        }

        private static int GetMinRefTime(int[] cars)
        {
            var minTime = 999;
            for (int index = 0; index < cars.Length; index++)
            {
                if (cars[index] < minTime)                
                    minTime = cars[index];                
            }
            return minTime;           
        }
    }
}

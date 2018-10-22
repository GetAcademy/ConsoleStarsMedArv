
using System;

namespace ConsoleStars
{
    class RandomStar
    {
        private static int _randomX;
        private static int _randomY;
        private static int _randomSpeedX;
        private static int _randomSpeedY;

        //public RandomStar(int randomX, int randomY, int randomSpeedX, int randomSpeedY)
        //{
        //    randomX = _randomX;
        //    randomY = _randomY;
        //    randomSpeedX = _randomSpeedX;
        //    randomSpeedY = _randomSpeedY;

        //}

        public static int GenerateRandomStar()
        {
            var windowWidth = Console.WindowWidth;
            var windowHeight = Console.WindowHeight;
            var bufferHeight = Console.BufferHeight;
            var bufferWidth = Console.BufferWidth;
            var random = new Random();

            if (_randomX <= 1)
            {
                _randomSpeedX = 1;
            }
            if (_randomX >= windowWidth - 1)
            {             
                _randomSpeedX = -1;
            }

            if (_randomY <= 1)
            {
                _randomSpeedY = 1;
            }
            if (_randomY >= windowHeight - 1)
            {
                bufferHeight = -1;
                _randomSpeedY = -1;
            }

            _randomX += _randomSpeedX;
            _randomY += _randomSpeedY;

            return random.Next(-1, 52);
        }

    }
}

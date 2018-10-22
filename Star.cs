using System;

namespace ConsoleStars
{
    public class Star
    {
        private const string _phaseChars = " .x*x.";
        protected int _x;
        protected int _y;
        private int _phase;

        public Star(int x, int y, int phase)
        {
            _x = x;
            _y = y;
            _phase = phase;
        }

        public Star(Random random)
        {
            _x = random.Next(1, 60);
            _y = random.Next(1, 40);
            _phase = random.Next(0, _phaseChars.Length);
        }

        public void Show()
        {
            Console.CursorLeft = _x;
            Console.CursorTop = _y;
            Console.Write(_phaseChars[_phase]);                      
        }

        public virtual void Update()
        {
            _phase++;
            if (_phase == _phaseChars.Length) _phase = 0;
        }
    }
}

using System;

namespace Exercise1
{
    public class Stopwatch
    {
        private TimeSpan _duration;
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _calisiyor;

        public void GetDuration()
        {
            _duration = _startTime - _stopTime;
            Console.WriteLine($"duration {_duration}");
        }

        public void Start()
        {
            if (!_calisiyor)
            {
                _calisiyor = true;
                _startTime = DateTime.Now;
                Console.WriteLine($"Start çalışıyoooo {_startTime}");
            }
            else
            {
                throw new InvalidOperationException("stop first");
            }

        }

        public void Stop()
        {
            if (_calisiyor)
            { 
                _stopTime = DateTime.Now;
                Console.WriteLine($"stop çalışıyoooo {_stopTime}");
            }
        }
    }
}
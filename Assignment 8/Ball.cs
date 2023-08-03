using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    internal class Ball
    {
        public int ID { get; set; }

        Location ball_location;
        internal Location Ball_location
        {
            get => ball_location;
            set
            {
                if (value != ball_location)
                {
                    ball_location = value;
                    //notify the subs..
                    ball_changed?.Invoke(ball_location);

                }
            }
        }
        public event Action<Location> ball_changed;

        public override string ToString() => $"Ball {ID} @ {ball_location} ";
    }
}

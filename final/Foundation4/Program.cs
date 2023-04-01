using System;
using System.Collections.Generic;

namespace FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
           
            RunningActivity running = new RunningActivity(DateTime.Parse("04/01/2023"), 35, 3.0);
            CyclingActivity cycling = new CyclingActivity(DateTime.Parse("03/28/2023"), 40, 20);
            SwimmingActivity swimming = new SwimmingActivity(DateTime.Parse("03/29/2023"), 55, 10);

            
            List<Activity> activities = new List<Activity>();
            activities.Add(running);
            activities.Add(cycling);
            activities.Add(swimming);

           
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }

           
            Console.ReadLine();
        }
    }

    abstract class Activity
    {
        private DateTime date;
        private int length;

        public Activity(DateTime date, int length)
        {
            this.date = date;
            this.length = length;
        }

        public DateTime Date
        {
            get { return date; }
        }

        public int Length
        {
            get { return length; }
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            return $"{date.ToString("dd MMM yyyy")} {GetType().Name} ({length} min) - Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min/km";
        }
    }

    class RunningActivity : Activity
    {
        private double distance;

        public RunningActivity(DateTime date, int length, double distance) : base(date, length)
        {
            this.distance = distance;
        }

        public override double GetDistance()
        {
            return distance;
        }

        public override double GetSpeed()
        {
            return distance / Length * 60;
        }

        public override double GetPace()
        {
            return Length / distance;
        }
    }

    class CyclingActivity : Activity
    {
        private int speed;

        public CyclingActivity(DateTime date, int length, int speed) : base(date, length)
        {
            this.speed = speed;
        }

        public override double GetDistance()
        {
            return speed / 60.0 * Length;
        }

        public override double GetSpeed()
        {
            return speed;
        }

        public override double GetPace()
        {
            return 60.0 / speed * GetDistance();
        }
    }

    class SwimmingActivity : Activity
    {
        private int laps;

        public SwimmingActivity(DateTime date, int length, int laps) : base(date, length)
        {
            this.laps = laps;
        }

        public override double GetDistance()
        {
            return laps * 50 / 1000.0;
        }

        public override double GetSpeed()
        {
            return GetDistance() / Length * 60;
        }

        public override double GetPace()
        {
            return Length / GetDistance();
        }

        public override string GetSummary()
        {
            return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({Length} min) - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min/mile";
        }
    }
}
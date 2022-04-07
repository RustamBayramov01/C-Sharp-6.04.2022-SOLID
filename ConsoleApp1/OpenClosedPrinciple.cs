using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OpenClosedPrinciple { }

    public class Cars
    {
        public virtual double GetCarStatus(double other) { return other - 10; }
    }

    public class FinalPrice : Cars
    {
        public override double GetCarStatus(double other) { return base.GetCarStatus(other) - 50; }
    }
    public class RecommendedSeries : Cars
    {
        public override double GetCarStatus(double other) { return base.GetCarStatus(other) - 40; }
    }
    public class DuplicateCars : Cars
    {
        public override double GetCarStatus(double other) { return base.GetCarStatus(other) - 30; }
    }
}

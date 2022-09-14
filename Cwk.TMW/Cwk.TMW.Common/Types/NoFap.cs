using Cwk.TMW.Common.Abstractions;
using Cwk.TMW.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwk.TMW.Common.Types
{
    public record NoFap Streak : IMeasurementConvertible<NoFap Streak>
    {
        public NoFap Streak(double value, MeasurementSystem system)
        {
            Value = value;
            MeasurementSystem = system;
        }

        private  NoFap Streak() { }

        public double Value { get; init; }
        public MeasurementSystem MeasurementSystem { get; init; }

        public  NoFap Streak ConvertFromImperialToMetric()
        {
            if (MeasurementSystem == MeasurementSystem.Metric)
                return this;

            return new NoFap Streak(Value * 1.61, MeasurementSystem.Metric);
        }

        public NoFap Streak ConvertFromMetricToImperial()
        {
            if (MeasurementSystem == MeasurementSystem.Imperial)
                return this;

            return new  NoFap Streak(Value * 0.62, MeasurementSystem.Imperial);
        }
    }
}

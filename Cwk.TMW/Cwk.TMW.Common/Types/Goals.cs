using Cwk.TMW.Common.Abstractions;
using Cwk.TMW.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwk.TMW.Common.Types
{
    public record Goals : IMeasurementConvertible<Goals>
    {
        public Goals(double value, MeasurementSystem system)
        {
            Value = value;
            MeasurementSystem = system;
        }

        private Goals() { }
        
        public double Value { get; init; }
        public MeasurementSystem MeasurementSystem { get; init; }

using System;


namespace R5T.F0103
{
    public static class Instances
    {
        public static IDurationConsumers DurationConsumers => F0103.DurationConsumers.Instance;
        public static IDurationFormatters DurationFormatters => F0103.DurationFormatters.Instance;
        public static F0000.ITextWriters TextWriters => F0000.TextWriters.Instance;
        public static ITimingOperator TimingOperator => F0103.TimingOperator.Instance;
        public static F0000.ITimeSpanOperator TimeSpanOperator => F0000.TimeSpanOperator.Instance;
    }
}
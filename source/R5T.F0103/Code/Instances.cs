using System;


namespace R5T.F0103
{
    public static class Instances
    {
        public static IDurationConsumers DurationConsumers => F0103.DurationConsumers.Instance;
        public static IDurationFormatters DurationFormatters => F0103.DurationFormatters.Instance;
        public static L0066.ITextWriters TextWriters => L0066.TextWriters.Instance;
        public static ITimingOperator TimingOperator => F0103.TimingOperator.Instance;
        public static L0066.ITimeSpanOperator TimeSpanOperator => L0066.TimeSpanOperator.Instance;
    }
}
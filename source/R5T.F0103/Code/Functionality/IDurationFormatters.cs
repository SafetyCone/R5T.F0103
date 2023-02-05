using System;

using R5T.T0132;


namespace R5T.F0103
{
    [FunctionalityMarker]
    public partial interface IDurationFormatters : IFunctionalityMarker
    {
        public string TotalSeconds_WithMilliseconds(TimeSpan duration)
        {
            var output = Instances.TimeSpanOperator.ToString_NumberOfSeconds_WithMilliseconds(duration);
            return output;
        }
    }
}

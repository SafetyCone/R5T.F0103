using System;
using System.IO;

using R5T.T0132;


namespace R5T.F0103
{
    [FunctionalityMarker]
    public partial interface IDurationConsumers : IFunctionalityMarker
    {
        public void OutputToWriter(
            TimeSpan duration,
            TextWriter writer,
            Func<TimeSpan, string> durationFormatter)
        {
            var durationRepresentation = durationFormatter(duration);

            writer.WriteLine(durationRepresentation);
        }

        public void OutputToConsole(
            TimeSpan duration,
            Func<TimeSpan, string> durationFormatter)
        {
            this.OutputToWriter(
                duration,
                Instances.TextWriters.Console,
                durationFormatter);
        }

        public void OutputToConsole(
            TimeSpan duration)
        {
            this.OutputToConsole(
                duration,
                Instances.DurationFormatters.TotalSeconds_WithMilliseconds);
        }
    }
}

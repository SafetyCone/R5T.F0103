using System;
using System.Diagnostics;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.F0103
{
    [FunctionalityMarker]
    public partial interface ITimingOperator : IFunctionalityMarker
    {
        public async Task<TimeSpan> Measure_Duration(Task task)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            await task;

            stopwatch.Stop();

            var duration = stopwatch.Elapsed;
            return duration;
        }

        public async Task<TimeSpan> Measure_Duration(Func<Task> action)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            await action();

            stopwatch.Stop();

            var duration = stopwatch.Elapsed;
            return duration;
        }

        public TimeSpan MeasureDuration(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            action();

            stopwatch.Stop();

            var duration = stopwatch.Elapsed;
            return duration;
        }

        public TOut MeasureDuration<TOut>(
            Func<TOut> function,
            out TimeSpan duration)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            var output = function();

            stopwatch.Stop();

            duration = stopwatch.Elapsed;
            
            return output;
        }

        public TimeSpan InTimingContext(
            Action action,
            Action<TimeSpan> durationConsumer)
        {
            var duration = this.InTimingContext(action);

            durationConsumer(duration);

            return duration;
        }

        public TimeSpan InTimingContext(Action action)
        {
            var duration = this.MeasureDuration(action);
            return duration;
        }
    }
}

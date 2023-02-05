using System;


namespace R5T.F0103
{
    public class TimingOperator : ITimingOperator
    {
        #region Infrastructure

        public static ITimingOperator Instance { get; } = new TimingOperator();


        private TimingOperator()
        {
        }

        #endregion
    }
}

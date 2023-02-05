using System;


namespace R5T.F0103
{
    public class DurationFormatters : IDurationFormatters
    {
        #region Infrastructure

        public static IDurationFormatters Instance { get; } = new DurationFormatters();


        private DurationFormatters()
        {
        }

        #endregion
    }
}

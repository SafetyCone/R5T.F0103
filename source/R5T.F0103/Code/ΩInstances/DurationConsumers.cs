using System;


namespace R5T.F0103
{
    public class DurationConsumers : IDurationConsumers
    {
        #region Infrastructure

        public static IDurationConsumers Instance { get; } = new DurationConsumers();


        private DurationConsumers()
        {
        }

        #endregion
    }
}

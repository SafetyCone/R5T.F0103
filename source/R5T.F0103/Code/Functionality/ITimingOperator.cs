using System;
using System.Diagnostics;
using System.Threading.Tasks;

using R5T.T0132;
using R5T.T0143;


namespace R5T.F0103
{
    [FunctionalityMarker]
    public partial interface ITimingOperator : IFunctionalityMarker,
        F10Y.L0001.L000.ITimingOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        F10Y.L0001.L000.ITimingOperator _F10Y_L0001_L000 => F10Y.L0001.L000.TimingOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}

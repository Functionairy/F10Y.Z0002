using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0002
{
    [ValuesMarker]
    public partial interface ITargetFrameworkMonikerSets
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.ITargetFrameworkMonikerSets _Raw => Raw.TargetFrameworkMonikerSets.Instance;

#pragma warning restore IDE1006 // Naming Styles

        /// <inheritdoc cref="Raw.ITargetFrameworkMonikerSets.N_0001"/>
        public string[] All => _Raw.N_0001;
    }
}

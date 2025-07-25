using System;

using F10Y.T0003;


namespace F10Y.Z0002.Conceptual
{
    [ValuesMarker]
    public partial interface ITargetFrameworkMonikers
    {
#pragma warning disable IDE1006 // Naming Styles

        private static Z0002.ITargetFrameworkMonikers _TargetFrameworkMonikers => Z0002.TargetFrameworkMonikers.Instance;

#pragma warning restore IDE1006 // Naming Styles


        #region Examples

        /// <summary>
        /// Any .NET Standard libraries require a runtime (they do not have one of their own).
        /// Use this target framework moniker as the default for any .NET Standard libraries that do not specify a runtime themselves.
        /// <para><inheritdoc cref="Z0002.ITargetFrameworkMonikers.net8_0" /></para>
        /// </summary>
        public string Default_ForNetStandardRuntime => _TargetFrameworkMonikers.net8_0;

        /// <summary>
        /// A complex example for use in testing parsing code.
        /// <para><inheritdoc cref="Z0002.ITargetFrameworkMonikers.net6_0_ios_15_0" /></para>
        /// </summary>
        public string Example_Complex => _TargetFrameworkMonikers.net6_0_ios_15_0;

        /// <summary>
        /// A simple example for use in testing parsing code.
        /// <para><inheritdoc cref="Z0002.ITargetFrameworkMonikers.net6_0" /></para>
        /// </summary>
        public string Example_Simple => _TargetFrameworkMonikers.net6_0;

        /// <summary>
        /// An example with an operating-system token for use in testing parsing code.
        /// <para><inheritdoc cref="Z0002.ITargetFrameworkMonikers.net6_0_windows" /></para>
        /// </summary>
        public string Example_WithOS => _TargetFrameworkMonikers.net6_0_windows;

        /// <summary>
        /// An example from the old Windows-only .NET Framework for use in testing parsing code.
        /// <para><inheritdoc cref="Z0002.ITargetFrameworkMonikers.net481" /></para>
        /// </summary>
        public string Example_OldFramework => _TargetFrameworkMonikers.net481;

        /// <summary>
        /// An example without a version for use in testing parsing code.
        /// <para><inheritdoc cref="Z0002.ITargetFrameworkMonikers.win" /></para>
        /// </summary>
        public string Example_WithoutVersion => _TargetFrameworkMonikers.win;

        #endregion

        /// <inheritdoc cref="Z0002.ITargetFrameworkMonikers.netcoreapp2_2"/>
        public string NETCoreApp_2_2 => _TargetFrameworkMonikers.netcoreapp2_2;

        /// <inheritdoc cref="Z0002.ITargetFrameworkMonikers.netcoreapp3_1"/>
        public string NETCoreApp_3_1 => _TargetFrameworkMonikers.netcoreapp3_1;

        /// <inheritdoc cref="Z0002.ITargetFrameworkMonikers.net48"/>
        public string NETFramework_4_8 => _TargetFrameworkMonikers.net48;

        /// <inheritdoc cref="Z0002.ITargetFrameworkMonikers.netstandard2_0"/>
        public string NETStandard2_0 => _TargetFrameworkMonikers.netstandard2_0;

        /// <inheritdoc cref="Z0002.ITargetFrameworkMonikers.netstandard2_1"/>
        public string NETStandard2_1 => _TargetFrameworkMonikers.netstandard2_1;

        /// <inheritdoc cref="Z0002.ITargetFrameworkMonikers.net5_0"/>
        public string NET_5_0 => _TargetFrameworkMonikers.net5_0;

        /// <inheritdoc cref="Z0002.ITargetFrameworkMonikers.net6_0"/>
        public string NET_6_0 => _TargetFrameworkMonikers.net6_0;

        /// <inheritdoc cref="Z0002.ITargetFrameworkMonikers.net6_0_windows"/>
        public string NET_6_0_Windows => _TargetFrameworkMonikers.net6_0_windows;

        /// <inheritdoc cref="Z0002.ITargetFrameworkMonikers.net7_0"/>
        public string NET_7_0 => _TargetFrameworkMonikers.net7_0;

        /// <inheritdoc cref="Z0002.ITargetFrameworkMonikers.net8_0"/>
        public string NET_8_0 => _TargetFrameworkMonikers.net8_0;

        /// <inheritdoc cref="Z0002.ITargetFrameworkMonikers.net8_0_windows"/>
        public string NET_8_0_Windows => _TargetFrameworkMonikers.net8_0_windows;
    }
}

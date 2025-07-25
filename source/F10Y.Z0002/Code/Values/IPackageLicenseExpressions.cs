using System;

using F10Y.T0003;


namespace F10Y.Z0002
{
    /// <summary>
    /// For use in .NET project files.
    /// </summary>
    /// <remarks>
    /// For a list of Nuget supported license expressions (SPDX) see <inheritdoc cref="Documentation.Links.SPDXLicenseExpressions" path="/summary"/>.
    /// </remarks>
    [ValuesMarker]
    public partial interface IPackageLicenseExpressions
    {
        /// <summary>
        /// <para><value>CC-BY-4.0</value></para>
        /// Creative Commons Attribution 4.0 International
        /// </summary>
        /// <remarks>
        /// <see href="https://spdx.org/licenses/CC-BY-4.0.html"/>
        /// </remarks>
        public string CC_BY_4_0 => "CC-BY-4.0";

        /// <summary>
        /// <para><value>MIT</value></para>
        /// MIT License
        /// </summary>
        /// <remarks>
        /// <see href="https://spdx.org/licenses/MIT.html"/>
        /// </remarks>
        public string MIT => "MIT";
    }
}

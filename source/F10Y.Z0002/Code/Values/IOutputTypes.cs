using System;

using F10Y.T0003;


namespace F10Y.Z0002
{
    /// <summary>
	/// Find "OutputType" in: <see href="https://learn.microsoft.com/en-us/visualstudio/msbuild/common-msbuild-project-properties?view=vs-2022"/>
	/// </summary>
    [ValuesMarker]
    public partial interface IOutputTypes
    {
        /// <summary>
        /// <para><value>Library</value></para>
		/// For class libraries.
        /// Default, can be omitted.
		/// </summary>
		public string Library => "Library";

        /// <summary>
        /// <para><value>Exe</value></para>
        /// Used for console applications (and if you want your WinForms or WPF application to show a console window).
        /// </summary>
        public string Exe => "Exe";

        /// <summary>
        /// <para><value>Module</value></para>
        /// Not really used? Unclear what a module is, and no good source online.
        /// </summary>
        public string Module => "Module";

        /// <summary>
        /// <para><value>WinExe</value></para>
        /// Used for WinForms and WPF applications.
        /// See also: <see href="https://learn.microsoft.com/en-us/dotnet/core/compatibility/sdk/5.0/automatically-infer-winexe-output-type"/>
        /// </summary>
        public string WinExe => "WinExe";
    }
}

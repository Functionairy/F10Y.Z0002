using System;

using F10Y.T0003;


namespace F10Y.Z0002
{
    /// <summary>
    /// Values determining the output assembly type produced by Visual Studio .NET project file.
	/// For example, executable (Exe), Windows executable (WinExe), or library (Library, the default if none is specified).
	/// </summary>
    /// <remarks>
    /// Source: find "OutputType" in <see href="https://learn.microsoft.com/en-us/visualstudio/msbuild/common-msbuild-project-properties"/>
    /// </remarks>
    [ValuesMarker]
    public partial interface IOutputTypes
    {
        /// <summary>
        /// <para><inheritdoc cref="L0000.IStrings.DEFAULT" path="descendant::value"/></para>
        /// If a project file is missing an output type property, then it is assumed to be a library.
        /// This value allows representing the situation of a missing output type property.
        /// </summary>
        public string DEFAULT => Instances.Strings.DEFAULT;

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

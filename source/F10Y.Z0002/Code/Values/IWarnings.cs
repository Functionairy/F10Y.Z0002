using System;

using F10Y.T0003;


namespace F10Y.Z0002
{
    /// <summary>
    /// Useful list: <see href="https://gist.github.com/thomaslevesque/43e4950a65961e2194e4ce082d64bc31"/>
    /// </summary>
    // Prior work: R5T.F0020.IWarnings, R5T.Z0048.
    [ValuesMarker]
    public partial interface IWarnings
    {
        /// <summary>
        /// <para><value>CS1573</value></para>
		/// Parameter 'parameter' has no matching param tag in the XML comment for 'parameter' (but other parameters do)
		/// See <see href="https://learn.microsoft.com/en-us/dotnet/csharp/misc/cs1573"/>
		/// </summary>
        /// <remarks>
        /// If any parameter of a method has a documentation comment, this warning is generated for every other parameter of the method that does not.
        /// </remarks>
		string CS1573 => "CS1573";

        /// <summary>
        /// <para><value>CS1587</value></para>
        /// XML comment is not placed on a valid language element
        /// See <see href="https://learn.microsoft.com/en-us/dotnet/csharp/misc/cs1587"/>
        /// </summary>
        /// <remarks>
        /// It can be 
        /// </remarks>
        string CS1587 => "CS1587";

        /// <summary>
        /// <para><value>CS1591</value></para>
        /// Missing XML comment for publicly visible type or member 'Type_or_Member'
        /// See <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1591"/>
        /// </summary>
        /// <remarks>
        /// When the generate-documentation-file project property is set to true,
        /// this warning is generated for each publically visible type or member that does not have a documentation comment.
        /// </remarks>
        string CS1591 => "CS1591";

        /// <summary>
        /// <para><value>IDE0059</value></para>
        /// <see href="https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0059"/>
        /// </summary>
        string IDE0059 => "IDE0059";

        /// <summary>
        /// <para><value>IDE0130</value></para>
        /// <see href="https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0130"/>
        /// </summary>
        string IDE0130 => "IDE0130";
    }
}

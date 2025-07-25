using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0002
{
    /// <summary>
    /// Dotnet target frameworks (example: <inheritdoc cref="Documentation.Examples.DotnetTargetFramework" path="descendant::value"/>).
    /// Links:
    /// <list type="bullet">
    /// <item><inheritdoc cref="Documentation.Links.DotnetTargetFrameworks" path="descendant::value"/></item>
    /// <item><inheritdoc cref="Documentation.Links.DotnetStandardVersions" path="descendant::value"/></item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// See also:
    /// * R5T.F0020.ITargetFrameworkMonikerStrings - This needs to be updated to include more values, and use the latest value declaration and documentation methodologies.
    /// * R5T.Z0057.ITargetFrameworkMonikers - This needs to be updated to use the latest value documentation methodology.
    /// </remarks>
    [ValuesMarker]
    public partial interface ITargetFrameworkMonikers
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Conceptual.ITargetFrameworkMonikers _Conceptual => Conceptual.TargetFrameworkMonikers.Instance;


        /// <summary>
        /// <para><value>aspnet50</value></para>
        /// </summary>
        public const string aspnet50_Constant = "aspnet50";

        /// <inheritdoc cref="aspnet50_Constant"/>
        public string aspnet50 => aspnet50_Constant;

        /// <summary>
        /// <para><value>aspnetcore50</value></para>
        /// </summary>
        public const string aspnetcore50_Constant = "aspnetcore50";

        /// <inheritdoc cref="aspnetcore50_Constant"/>
        public string aspnetcore50 => aspnetcore50_Constant;

        /// <summary>
        /// <para><value>dnx</value></para>
        /// </summary>
        public const string dnx_Constant = "dnx";

        /// <inheritdoc cref="dnx_Constant"/>
        public string dnx => dnx_Constant;

        /// <summary>
        /// <para><value>dnx45</value></para>
        /// </summary>
        public const string dnx45_Constant = "dnx45";

        /// <inheritdoc cref="dnx45_Constant"/>
        public string dnx45 => dnx45_Constant;

        /// <summary>
        /// <para><value>dnx451</value></para>
        /// </summary>
        public const string dnx451_Constant = "dnx451";

        /// <inheritdoc cref="dnx451_Constant"/>
        public string dnx451 => dnx451_Constant;

        /// <summary>
        /// <para><value>dnx452</value></para>
        /// </summary>
        public const string dnx452_Constant = "dnx452";

        /// <inheritdoc cref="dnx452_Constant"/>
        public string dnx452 => dnx452_Constant;

        /// <summary>
        /// <para><value>dnxcore50</value></para>
        /// </summary>
        public const string dnxcore50_Constant = "dnxcore50";

        /// <inheritdoc cref="dnxcore50_Constant"/>
        public string dnxcore50 => dnxcore50_Constant;

        /// <summary>
        /// <para><value>dotnet</value></para>
        /// </summary>
        public const string dotnet_Constant = "dotnet";

        /// <inheritdoc cref="dotnet_Constant"/>
        public string dotnet => dotnet_Constant;

        /// <summary>
        /// <para><value>dotnet50</value></para>
        /// </summary>
        public const string dotnet50_Constant = "dotnet50";

        /// <inheritdoc cref="dotnet50_Constant"/>
        public string dotnet50 => dotnet50_Constant;

        /// <summary>
        /// <para><value>dotnet51</value></para>
        /// </summary>
        public const string dotnet51_Constant = "dotnet51";

        /// <inheritdoc cref="dotnet51_Constant"/>
        public string dotnet51 => dotnet51_Constant;

        /// <summary>
        /// <para><value>dotnet52</value></para>
        /// </summary>
        public const string dotnet52_Constant = "dotnet52";

        /// <inheritdoc cref="dotnet52_Constant"/>
        public string dotnet52 => dotnet52_Constant;

        /// <summary>
        /// <para><value>dotnet53</value></para>
        /// </summary>
        public const string dotnet53_Constant = "dotnet53";

        /// <inheritdoc cref="dotnet53_Constant"/>
        public string dotnet53 => dotnet53_Constant;

        /// <summary>
        /// <para><value>dotnet54</value></para>
        /// </summary>
        public const string dotnet54_Constant = "dotnet54";

        /// <inheritdoc cref="dotnet54_Constant"/>
        public string dotnet54 => dotnet54_Constant;

        /// <summary>
        /// <para><value>dotnet55</value></para>
        /// </summary>
        public const string dotnet55_Constant = "dotnet55";

        /// <inheritdoc cref="dotnet55_Constant"/>
        public string dotnet55 => dotnet55_Constant;

        /// <summary>
        /// <para><value>dotnet56</value></para>
        /// </summary>
        public const string dotnet56_Constant = "dotnet56";

        /// <inheritdoc cref="dotnet56_Constant"/>
        public string dotnet56 => dotnet56_Constant;

        /// <summary>
        /// <para><value>net11</value></para>
        /// </summary>
        public const string net11_Constant = "net11";

        /// <inheritdoc cref="net11_Constant"/>
        public string net11 => net11_Constant;

        /// <summary>
        /// <para><value>net20</value></para>
        /// </summary>
        public const string net20_Constant = "net20";

        /// <inheritdoc cref="net20_Constant"/>
        public string net20 => net20_Constant;

        /// <summary>
        /// <para><value>net35</value></para>
        /// </summary>
        public const string net35_Constant = "net35";

        /// <inheritdoc cref="net35_Constant"/>
        public string net35 => net35_Constant;

        /// <summary>
        /// <para><value>net40</value></para>
        /// </summary>
        public const string net40_Constant = "net40";

        /// <inheritdoc cref="net40_Constant"/>
        public string net40 => net40_Constant;

        /// <summary>
        /// <para><value>net403</value></para>
        /// </summary>
        public const string net403_Constant = "net403";

        /// <inheritdoc cref="net403_Constant"/>
        public string net403 => net403_Constant;

        /// <summary>
        /// <para><value>net45</value></para>
        /// </summary>
        public const string net45_Constant = "net45";

        /// <inheritdoc cref="net45_Constant"/>
        public string net45 => net45_Constant;

        /// <summary>
        /// <para><value>net451</value></para>
        /// </summary>
        public const string net451_Constant = "net451";

        /// <inheritdoc cref="net451_Constant"/>
        public string net451 => net451_Constant;

        /// <summary>
        /// <para><value>net452</value></para>
        /// </summary>
        public const string net452_Constant = "net452";

        /// <inheritdoc cref="net452_Constant"/>
        public string net452 => net452_Constant;

        /// <summary>
        /// <para><value>net46</value></para>
        /// </summary>
        public const string net46_Constant = "net46";

        /// <inheritdoc cref="net46_Constant"/>
        public string net46 => net46_Constant;

        /// <summary>
        /// <para><value>net461</value></para>
        /// </summary>
        public const string net461_Constant = "net461";

        /// <inheritdoc cref="net461_Constant"/>
        public string net461 => net461_Constant;

        /// <summary>
        /// <para><value>net462</value></para>
        /// </summary>
        public const string net462_Constant = "net462";

        /// <inheritdoc cref="net462_Constant"/>
        public string net462 => net462_Constant;

        /// <summary>
        /// <para><value>net47</value></para>
        /// </summary>
        public const string net47_Constant = "net47";

        /// <inheritdoc cref="net47_Constant"/>
        public string net47 => net47_Constant;

        /// <summary>
        /// <para><value>net471</value></para>
        /// </summary>
        public const string net471_Constant = "net471";

        /// <inheritdoc cref="net471_Constant"/>
        public string net471 => net471_Constant;

        /// <summary>
        /// <para><value>net472</value></para>
        /// </summary>
        public const string net472_Constant = "net472";

        /// <inheritdoc cref="net472_Constant"/>
        public string net472 => net472_Constant;

        /// <summary>
        /// <para><value>net48</value></para>
        /// </summary>
        public const string net48_Constant = "net48";

        /// <inheritdoc cref="net48_Constant"/>
        public string net48 => net48_Constant;

        /// <summary>
        /// <para><value>net481</value></para>
        /// </summary>
        public const string net481_Constant = "net481";

        /// <inheritdoc cref="net481_Constant"/>
        public string net481 => net481_Constant;

        /// <summary>
        /// <para><value>net5.0</value></para>
        /// </summary>
        public const string net5_0_Constant = "net5.0";

        /// <inheritdoc cref="net5_0_Constant"/>
        public string net5_0 => net5_0_Constant;

        /// <summary>
        /// <para><value>net5.0-windows</value></para>
        /// </summary>
        public const string net5_0_windows_Constant = "net5.0-windows";

        /// <inheritdoc cref="net5_0_windows_Constant"/>
        public string net5_0_windows => net5_0_windows_Constant;

        /// <summary>
        /// <para><value>net6.0</value></para>
        /// </summary>
        public const string net6_0_Constant = "net6.0";

        /// <inheritdoc cref="net6_0_Constant"/>
        public string net6_0 => net6_0_Constant;

        /// <summary>
        /// <para><value>net6.0-android</value></para>
        /// </summary>
        public const string net6_0_android_Constant = "net6.0-android";

        /// <inheritdoc cref="net6_0_android_Constant"/>
        public string net6_0_android => net6_0_android_Constant;

        /// <summary>
        /// <para><value>net6.0-android31.0</value></para>
        /// </summary>
        public const string net6_0_android_31_0_Constant = "net6.0-android31.0";

        /// <inheritdoc cref="net6_0_android_31_0_Constant"/>
        public string net6_0_android_31_0 => net6_0_android_31_0_Constant;

        /// <summary>
        /// <para><value>net6.0-ios</value></para>
        /// </summary>
        public const string net6_0_ios_Constant = "net6.0-ios";

        /// <inheritdoc cref="net6_0_ios_Constant"/>
        public string net6_0_ios => net6_0_ios_Constant;

        /// <summary>
        /// <para><value>net6.0-ios15.0</value></para>
        /// </summary>
        public const string net6_0_ios_15_0_Constant = "net6.0-ios15.0";

        /// <inheritdoc cref="net6_0_ios_15_0_Constant"/>
        public string net6_0_ios_15_0 => net6_0_ios_15_0_Constant;

        /// <summary>
        /// <para><value>net6.0-maccatalyst</value></para>
        /// </summary>
        public const string net6_0_maccatalyst_Constant = "net6.0-maccatalyst";

        /// <inheritdoc cref="net6_0_maccatalyst_Constant"/>
        public string net6_0_maccatalyst => net6_0_maccatalyst_Constant;

        /// <summary>
        /// <para><value>net6.0-maccatalyst15.0</value></para>
        /// </summary>
        public const string net6_0_maccatalyst_15_0_Constant = "net6.0-maccatalyst15.0";

        /// <inheritdoc cref="net6_0_maccatalyst_15_0_Constant"/>
        public string net6_0_maccatalyst_15_0 => net6_0_maccatalyst_15_0_Constant;

        /// <summary>
        /// <para><value>net6.0-macos</value></para>
        /// </summary>
        public const string net6_0_macos_Constant = "net6.0-macos";

        /// <inheritdoc cref="net6_0_macos_Constant"/>
        public string net6_0_macos => net6_0_macos_Constant;

        /// <summary>
        /// <para><value>net6.0-macos12.0</value></para>
        /// </summary>
        public const string net6_0_macos_12_0_Constant = "net6.0-macos12.0";

        /// <inheritdoc cref="net6_0_macos_12_0_Constant"/>
        public string net6_0_macos_12_0 => net6_0_macos_12_0_Constant;

        /// <summary>
        /// <para><value>net6.0-tvos</value></para>
        /// </summary>
        public const string net6_0_tvos_Constant = "net6.0-tvos";

        /// <inheritdoc cref="net6_0_tvos_Constant"/>
        public string net6_0_tvos => net6_0_tvos_Constant;

        /// <summary>
        /// <para><value>net6.0-tvos15.1</value></para>
        /// </summary>
        public const string net6_0_tvos_15_1_Constant = "net6.0-tvos15.1";

        /// <inheritdoc cref="net6_0_tvos_15_1_Constant"/>
        public string net6_0_tvos_15_1 => net6_0_tvos_15_1_Constant;

        /// <summary>
        /// <para><value>net6.0-windows</value></para>
        /// </summary>
        public const string net6_0_windows_Constant = "net6.0-windows";

        /// <inheritdoc cref="net6_0_windows_Constant"/>
        public string net6_0_windows => net6_0_windows_Constant;

        /// <summary>
        /// <para><value>net6.0-windows7.0</value></para>
        /// </summary>
        public const string net6_0_windows_7_0_Constant = "net6.0-windows7.0";

        /// <inheritdoc cref="net6_0_windows_7_0_Constant"/>
        public string net6_0_windows_7_0 => net6_0_windows_7_0_Constant;

        /// <summary>
        /// <para><value>net7.0</value></para>
        /// </summary>
        public const string net7_0_Constant = "net7.0";

        /// <inheritdoc cref="net7_0_Constant"/>
        public string net7_0 => net7_0_Constant;

        /// <summary>
        /// <para><value>net7.0-android</value></para>
        /// </summary>
        public const string net7_0_android_Constant = "net7.0-android";

        /// <inheritdoc cref="net7_0_android_Constant"/>
        public string net7_0_android => net7_0_android_Constant;

        /// <summary>
        /// <para><value>net7.0-android33.0</value></para>
        /// </summary>
        public const string net7_0_android_33_0_Constant = "net7.0-android33.0";

        /// <inheritdoc cref="net7_0_android_33_0_Constant"/>
        public string net7_0_android_33_0 => net7_0_android_33_0_Constant;

        /// <summary>
        /// <para><value>net7.0-ios</value></para>
        /// </summary>
        public const string net7_0_ios_Constant = "net7.0-ios";

        /// <inheritdoc cref="net7_0_ios_Constant"/>
        public string net7_0_ios => net7_0_ios_Constant;

        /// <summary>
        /// <para><value>net7.0-ios16.1</value></para>
        /// </summary>
        public const string net7_0_ios_16_1_Constant = "net7.0-ios16.1";

        /// <inheritdoc cref="net7_0_ios_16_1_Constant"/>
        public string net7_0_ios_16_1 => net7_0_ios_16_1_Constant;

        /// <summary>
        /// <para><value>net7.0-maccatalyst</value></para>
        /// </summary>
        public const string net7_0_maccatalyst_Constant = "net7.0-maccatalyst";

        /// <inheritdoc cref="net7_0_maccatalyst_Constant"/>
        public string net7_0_maccatalyst => net7_0_maccatalyst_Constant;

        /// <summary>
        /// <para><value>net7.0-maccatalyst16.1</value></para>
        /// </summary>
        public const string net7_0_maccatalyst_16_1_Constant = "net7.0-maccatalyst16.1";

        /// <inheritdoc cref="net7_0_maccatalyst_16_1_Constant"/>
        public string net7_0_maccatalyst_16_1 => net7_0_maccatalyst_16_1_Constant;

        /// <summary>
        /// <para><value>net7.0-macos</value></para>
        /// </summary>
        public const string net7_0_macos_Constant = "net7.0-macos";

        /// <inheritdoc cref="net7_0_macos_Constant"/>
        public string net7_0_macos => net7_0_macos_Constant;

        /// <summary>
        /// <para><value>net7.0-macos13.0</value></para>
        /// </summary>
        public const string net7_0_macos_13_0_Constant = "net7.0-macos13.0";

        /// <inheritdoc cref="net7_0_macos_13_0_Constant"/>
        public string net7_0_macos_13_0 => net7_0_macos_13_0_Constant;

        /// <summary>
        /// <para><value>net7.0-tizen</value></para>
        /// </summary>
        public const string net7_0_tizen_Constant = "net7.0-tizen";

        /// <inheritdoc cref="net7_0_tizen_Constant"/>
        public string net7_0_tizen => net7_0_tizen_Constant;

        /// <summary>
        /// <para><value>net7.0-tizen7.0</value></para>
        /// </summary>
        public const string net7_0_tizen_7_0_Constant = "net7.0-tizen7.0";

        /// <inheritdoc cref="net7_0_tizen_7_0_Constant"/>
        public string net7_0_tizen_7_0 => net7_0_tizen_7_0_Constant;

        /// <summary>
        /// <para><value>net7.0-tvos</value></para>
        /// </summary>
        public const string net7_0_tvos_Constant = "net7.0-tvos";

        /// <inheritdoc cref="net7_0_tvos_Constant"/>
        public string net7_0_tvos => net7_0_tvos_Constant;

        /// <summary>
        /// <para><value>net7.0-tvos16.1</value></para>
        /// </summary>
        public const string net7_0_tvos_16_1_Constant = "net7.0-tvos16.1";

        /// <inheritdoc cref="net7_0_tvos_16_1_Constant"/>
        public string net7_0_tvos_16_1 => net7_0_tvos_16_1_Constant;

        /// <summary>
        /// <para><value>net7.0-windows</value></para>
        /// </summary>
        public const string net7_0_windows_Constant = "net7.0-windows";

        /// <inheritdoc cref="net7_0_windows_Constant"/>
        public string net7_0_windows => net7_0_windows_Constant;

        /// <summary>
        /// <para><value>net7.0-windows7.0</value></para>
        /// </summary>
        public const string net7_0_windows_7_0_Constant = "net7.0-windows7.0";

        /// <inheritdoc cref="net7_0_windows_7_0_Constant"/>
        public string net7_0_windows_7_0 => net7_0_windows_7_0_Constant;

        /// <summary>
        /// <para><value>net8.0</value></para>
        /// </summary>
        public const string net8_0_Constant = "net8.0";

        /// <inheritdoc cref="net8_0_Constant"/>
        public string net8_0 => net8_0_Constant;

        /// <summary>
        /// <para><value>net8.0-android</value></para>
        /// </summary>
        public const string net8_0_android_Constant = "net8.0-android";

        /// <inheritdoc cref="net8_0_android_Constant"/>
        public string net8_0_android => net8_0_android_Constant;

        /// <summary>
        /// <para><value>net8.0-android34.0</value></para>
        /// </summary>
        public const string net8_0_android_34_0_Constant = "net8.0-android34.0";

        /// <inheritdoc cref="net8_0_android_34_0_Constant"/>
        public string net8_0_android_34_0 => net8_0_android_34_0_Constant;

        /// <summary>
        /// <para><value>net8.0-browser</value></para>
        /// </summary>
        public const string net8_0_browser_Constant = "net8.0-browser";

        /// <inheritdoc cref="net8_0_browser_Constant"/>
        public string net8_0_browser => net8_0_browser_Constant;

        /// <summary>
        /// <para><value>net8.0-ios</value></para>
        /// </summary>
        public const string net8_0_ios_Constant = "net8.0-ios";

        /// <inheritdoc cref="net8_0_ios_Constant"/>
        public string net8_0_ios => net8_0_ios_Constant;

        /// <summary>
        /// <para><value>net8.0-ios17.2</value></para>
        /// </summary>
        public const string net8_0_ios_17_2_Constant = "net8.0-ios17.2";

        /// <inheritdoc cref="net8_0_ios_17_2_Constant"/>
        public string net8_0_ios_17_2 => net8_0_ios_17_2_Constant;

        /// <summary>
        /// <para><value>net8.0-maccatalyst</value></para>
        /// </summary>
        public const string net8_0_maccatalyst_Constant = "net8.0-maccatalyst";

        /// <inheritdoc cref="net8_0_maccatalyst_Constant"/>
        public string net8_0_maccatalyst => net8_0_maccatalyst_Constant;

        /// <summary>
        /// <para><value>net8.0-maccatalyst17.2</value></para>
        /// </summary>
        public const string net8_0_maccatalyst_17_2_Constant = "net8.0-maccatalyst17.2";

        /// <inheritdoc cref="net8_0_maccatalyst_17_2_Constant"/>
        public string net8_0_maccatalyst_17_2 => net8_0_maccatalyst_17_2_Constant;

        /// <summary>
        /// <para><value>net8.0-macos</value></para>
        /// </summary>
        public const string net8_0_macos_Constant = "net8.0-macos";

        /// <inheritdoc cref="net8_0_macos_Constant"/>
        public string net8_0_macos => net8_0_macos_Constant;

        /// <summary>
        /// <para><value>net8.0-macos14.2</value></para>
        /// </summary>
        public const string net8_0_macos_14_2_Constant = "net8.0-macos14.2";

        /// <inheritdoc cref="net8_0_macos_14_2_Constant"/>
        public string net8_0_macos_14_2 => net8_0_macos_14_2_Constant;

        /// <summary>
        /// <para><value>net8.0-tizen</value></para>
        /// </summary>
        public const string net8_0_tizen_Constant = "net8.0-tizen";

        /// <inheritdoc cref="net8_0_tizen_Constant"/>
        public string net8_0_tizen => net8_0_tizen_Constant;

        /// <summary>
        /// <para><value>net8.0-tizen8.0</value></para>
        /// </summary>
        public const string net8_0_tizen_8_0_Constant = "net8.0-tizen8.0";

        /// <inheritdoc cref="net8_0_tizen_8_0_Constant"/>
        public string net8_0_tizen_8_0 => net8_0_tizen_8_0_Constant;

        /// <summary>
        /// <para><value>net8.0-tvos</value></para>
        /// </summary>
        public const string net8_0_tvos_Constant = "net8.0-tvos";

        /// <inheritdoc cref="net8_0_tvos_Constant"/>
        public string net8_0_tvos => net8_0_tvos_Constant;

        /// <summary>
        /// <para><value>net8.0-tvos17.1</value></para>
        /// </summary>
        public const string net8_0_tvos_17_1_Constant = "net8.0-tvos17.1";

        /// <inheritdoc cref="net8_0_tvos_17_1_Constant"/>
        public string net8_0_tvos_17_1 => net8_0_tvos_17_1_Constant;

        /// <summary>
        /// <para><value>net8.0-windows</value></para>
        /// </summary>
        public const string net8_0_windows_Constant = "net8.0-windows";

        /// <inheritdoc cref="net8_0_windows_Constant"/>
        public string net8_0_windows => net8_0_windows_Constant;

        /// <summary>
        /// <para><value>net8.0-windows7.0</value></para>
        /// </summary>
        public const string net8_0_windows_7_0_Constant = "net8.0-windows7.0";

        /// <inheritdoc cref="net8_0_windows_7_0_Constant"/>
        public string net8_0_windows_7_0 => net8_0_windows_7_0_Constant;

        /// <summary>
        /// <para><value>netcore</value></para>
        /// </summary>
        public const string netcore_Constant = "netcore";

        /// <inheritdoc cref="netcore_Constant"/>
        public string netcore => netcore_Constant;

        /// <summary>
        /// <para><value>netcore45</value></para>
        /// </summary>
        public const string netcore45_Constant = "netcore45";

        /// <inheritdoc cref="netcore45_Constant"/>
        public string netcore45 => netcore45_Constant;

        /// <summary>
        /// <para><value>netcore451</value></para>
        /// </summary>
        public const string netcore451_Constant = "netcore451";

        /// <inheritdoc cref="netcore451_Constant"/>
        public string netcore451 => netcore451_Constant;

        /// <summary>
        /// <para><value>netcore50</value></para>
        /// </summary>
        public const string netcore50_Constant = "netcore50";

        /// <inheritdoc cref="netcore50_Constant"/>
        public string netcore50 => netcore50_Constant;


        /// <summary>
        /// <para><value>netcoreapp1.0</value></para>
        /// </summary>
        public const string netcoreapp1_0_Constant = "netcoreapp1.0";

        /// <inheritdoc cref="netcoreapp1_0_Constant"/>
        public string netcoreapp1_0 => netcoreapp1_0_Constant;

        /// <summary>
        /// <para><value>netcoreapp1.1</value></para>
        /// </summary>
        public const string netcoreapp1_1_Constant = "netcoreapp1.1";

        /// <inheritdoc cref="netcoreapp1_1_Constant"/>
        public string netcoreapp1_1 => netcoreapp1_1_Constant;

        /// <summary>
        /// <para><value>netcoreapp2.0</value></para>
        /// </summary>
        public const string netcoreapp2_0_Constant = "netcoreapp2.0";

        /// <inheritdoc cref="netcoreapp2_0_Constant"/>
        public string netcoreapp2_0 => netcoreapp2_0_Constant;

        /// <summary>
        /// <para><value>netcoreapp2.1</value></para>
        /// </summary>
        public const string netcoreapp2_1_Constant = "netcoreapp2.1";

        /// <inheritdoc cref="netcoreapp2_1_Constant"/>
        public string netcoreapp2_1 => netcoreapp2_1_Constant;

        /// <summary>
        /// <para><value>netcoreapp2.2</value></para>
        /// </summary>
        public const string netcoreapp2_2_Constant = "netcoreapp2.2";

        /// <inheritdoc cref="netcoreapp2_2_Constant"/>
        public string netcoreapp2_2 => netcoreapp2_2_Constant;

        /// <summary>
        /// <para><value>netcoreapp3.0</value></para>
        /// </summary>
        public const string netcoreapp3_0_Constant = "netcoreapp3.0";

        /// <inheritdoc cref="netcoreapp3_0_Constant"/>
        public string netcoreapp3_0 => netcoreapp3_0_Constant;

        /// <summary>
        /// <para><value>netcoreapp3.1</value></para>
        /// </summary>
        public const string netcoreapp3_1_Constant = "netcoreapp3.1";

        /// <inheritdoc cref="netcoreapp3_1_Constant"/>
        public string netcoreapp3_1 => netcoreapp3_1_Constant;

        /// <summary>
        /// <para><value>netmf</value></para>
        /// </summary>
        public const string netmf_Constant = "netmf";

        /// <inheritdoc cref="netmf_Constant"/>
        public string netmf => netmf_Constant;

        /// <summary>
        /// <para><value>netstandard1.0</value></para>
        /// </summary>
        public const string netstandard1_0_Constant = "netstandard1.0";

        /// <inheritdoc cref="netstandard1_0_Constant"/>
        public string netstandard1_0 => netstandard1_0_Constant;

        /// <summary>
        /// <para><value>netstandard1.1</value></para>
        /// </summary>
        public const string netstandard1_1_Constant = "netstandard1.1";

        /// <inheritdoc cref="netstandard1_1_Constant"/>
        public string netstandard1_1 => netstandard1_1_Constant;

        /// <summary>
        /// <para><value>netstandard1.2</value></para>
        /// </summary>
        public const string netstandard1_2_Constant = "netstandard1.2";

        /// <inheritdoc cref="netstandard1_2_Constant"/>
        public string netstandard1_2 => netstandard1_2_Constant;

        /// <summary>
        /// <para><value>netstandard1.3</value></para>
        /// </summary>
        public const string netstandard1_3_Constant = "netstandard1.3";

        /// <inheritdoc cref="netstandard1_3_Constant"/>
        public string netstandard1_3 => netstandard1_3_Constant;

        /// <summary>
        /// <para><value>netstandard1.4</value></para>
        /// </summary>
        public const string netstandard1_4_Constant = "netstandard1.4";

        /// <inheritdoc cref="netstandard1_4_Constant"/>
        public string netstandard1_4 => netstandard1_4_Constant;

        /// <summary>
        /// <para><value>netstandard1.5</value></para>
        /// </summary>
        public const string netstandard1_5_Constant = "netstandard1.5";

        /// <inheritdoc cref="netstandard1_5_Constant"/>
        public string netstandard1_5 => netstandard1_5_Constant;

        /// <summary>
        /// <para><value>netstandard1.6</value></para>
        /// </summary>
        public const string netstandard1_6_Constant = "netstandard1.6";

        /// <inheritdoc cref="netstandard1_6_Constant"/>
        public string netstandard1_6 => netstandard1_6_Constant;

        /// <summary>
        /// <para><value>netstandard2.0</value></para>
        /// </summary>
        public const string netstandard2_0_Constant = "netstandard2.0";

        /// <inheritdoc cref="netstandard2_0_Constant"/>
        public string netstandard2_0 => netstandard2_0_Constant;

        /// <summary>
        /// <para><value>netstandard2.1</value></para>
        /// </summary>
        public const string netstandard2_1_Constant = "netstandard2.1";

        /// <inheritdoc cref="netstandard2_1_Constant"/>
        public string netstandard2_1 => netstandard2_1_Constant;

        /// <summary>
        /// Silverlight
        /// <para><value>sl4</value></para>
        /// </summary>
        public const string sl4_Constant = "sl4";

        /// <inheritdoc cref="sl4_Constant"/>
        public string sl4 => sl4_Constant;

        /// <summary>
        /// Silverlight
        /// <para><value>sl5</value></para>
        /// </summary>
        public const string sl5_Constant = "sl5";

        /// <inheritdoc cref="sl5_Constant"/>
        public string sl5 => sl5_Constant;

        /// <summary>
        /// <para><value>uap</value></para>
        /// </summary>
        public const string uap_Constant = "uap";

        /// <inheritdoc cref="uap_Constant"/>
        public string uap => uap_Constant;

        /// <summary>
        /// <para><value>uap10.0</value></para>
        /// </summary>
        public const string uap10_0_Constant = "uap10.0";

        /// <inheritdoc cref="uap10_0_Constant"/>
        public string uap10_0 => uap10_0_Constant;

        /// <summary>
        /// <para><value>win</value></para>
        /// </summary>
        public const string win_Constant = "win";

        /// <inheritdoc cref="win_Constant"/>
        public string win => win_Constant;

        /// <summary>
        /// <para><value>win8</value></para>
        /// </summary>
        public const string win8_Constant = "win8";

        /// <inheritdoc cref="win8_Constant"/>
        public string win8 => win8_Constant;

        /// <summary>
        /// <para><value>win81</value></para>
        /// </summary>
        public const string win81_Constant = "win81";

        /// <inheritdoc cref="win81_Constant"/>
        public string win81 => win81_Constant;

        /// <summary>
        /// <para><value>win10</value></para>
        /// </summary>
        public const string win10_Constant = "win10";

        /// <inheritdoc cref="win10_Constant"/>
        public string win10 => win10_Constant;

        /// <summary>
        /// <para><value>winrt</value></para>
        /// </summary>
        public const string winrt_Constant = "winrt";

        /// <inheritdoc cref="winrt_Constant"/>
        public string winrt => winrt_Constant;

        /// <summary>
        /// <para><value>wp</value></para>
        /// </summary>
        public const string wp_Constant = "wp";

        /// <inheritdoc cref="wp_Constant"/>
        public string wp => wp_Constant;

        /// <summary>
        /// <para><value>wp7</value></para>
        /// </summary>
        public const string wp7_Constant = "wp7";

        /// <inheritdoc cref="wp7_Constant"/>
        public string wp7 => wp7_Constant;

        /// <summary>
        /// <para><value>wp75</value></para>
        /// </summary>
        public const string wp75_Constant = "wp75";

        /// <inheritdoc cref="wp75_Constant"/>
        public string wp75 => wp75_Constant;

        /// <summary>
        /// <para><value>wp8</value></para>
        /// </summary>
        public const string wp8_Constant = "wp8";

        /// <inheritdoc cref="wp8_Constant"/>
        public string wp8 => wp8_Constant;

        /// <summary>
        /// <para><value>wp81</value></para>
        /// </summary>
        public const string wp81_Constant = "wp81";

        /// <inheritdoc cref="wp81_Constant"/>
        public string wp81 => wp81_Constant;

        /// <summary>
        /// <para><value>wpa81</value></para>
        /// </summary>
        public const string wpa81_Constant = "wpa81";

        /// <inheritdoc cref="wpa81_Constant"/>
        public string wpa81 => wpa81_Constant;

#pragma warning restore IDE1006 // Naming Styles
    }
}

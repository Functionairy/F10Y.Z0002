using System;

using F10Y.T0003;


namespace F10Y.Z0002.Raw
{
    [ValuesMarker]
    public partial interface ITargetFrameworkMonikerSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static ITargetFrameworkMonikers _TargetFrameworkMonikers => TargetFrameworkMonikers.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// All target framework monikers.
        /// </summary>
        public string[] N_0001 => new[]
        {
            _TargetFrameworkMonikers.aspnet50,
            _TargetFrameworkMonikers.aspnetcore50,
            _TargetFrameworkMonikers.dnx,
            _TargetFrameworkMonikers.dnx45,
            _TargetFrameworkMonikers.dnx451,
            _TargetFrameworkMonikers.dnx452,
            _TargetFrameworkMonikers.dnxcore50,
            _TargetFrameworkMonikers.dotnet,
            _TargetFrameworkMonikers.dotnet50,
            _TargetFrameworkMonikers.dotnet51,
            _TargetFrameworkMonikers.dotnet52,
            _TargetFrameworkMonikers.dotnet53,
            _TargetFrameworkMonikers.dotnet54,
            _TargetFrameworkMonikers.dotnet55,
            _TargetFrameworkMonikers.dotnet56,
            _TargetFrameworkMonikers.net11,
            _TargetFrameworkMonikers.net20,
            _TargetFrameworkMonikers.net35,
            _TargetFrameworkMonikers.net40,
            _TargetFrameworkMonikers.net403,
            _TargetFrameworkMonikers.net45,
            _TargetFrameworkMonikers.net451,
            _TargetFrameworkMonikers.net452,
            _TargetFrameworkMonikers.net46,
            _TargetFrameworkMonikers.net461,
            _TargetFrameworkMonikers.net462,
            _TargetFrameworkMonikers.net47,
            _TargetFrameworkMonikers.net471,
            _TargetFrameworkMonikers.net472,
            _TargetFrameworkMonikers.net48,
            _TargetFrameworkMonikers.net481,
            _TargetFrameworkMonikers.net5_0,
            _TargetFrameworkMonikers.net5_0_windows,
            _TargetFrameworkMonikers.net6_0,
            _TargetFrameworkMonikers.net6_0_android,
            _TargetFrameworkMonikers.net6_0_android_31_0,
            _TargetFrameworkMonikers.net6_0_ios,
            _TargetFrameworkMonikers.net6_0_ios_15_0,
            _TargetFrameworkMonikers.net6_0_maccatalyst,
            _TargetFrameworkMonikers.net6_0_maccatalyst_15_0,
            _TargetFrameworkMonikers.net6_0_macos,
            _TargetFrameworkMonikers.net6_0_macos_12_0,
            _TargetFrameworkMonikers.net6_0_tvos,
            _TargetFrameworkMonikers.net6_0_tvos_15_1,
            _TargetFrameworkMonikers.net6_0_windows,
            _TargetFrameworkMonikers.net6_0_windows_7_0,
            _TargetFrameworkMonikers.net7_0,
            _TargetFrameworkMonikers.net7_0_android,
            _TargetFrameworkMonikers.net7_0_android_33_0,
            _TargetFrameworkMonikers.net7_0_ios,
            _TargetFrameworkMonikers.net7_0_ios_16_1,
            _TargetFrameworkMonikers.net7_0_maccatalyst,
            _TargetFrameworkMonikers.net7_0_maccatalyst_16_1,
            _TargetFrameworkMonikers.net7_0_macos,
            _TargetFrameworkMonikers.net7_0_macos_13_0,
            _TargetFrameworkMonikers.net7_0_tizen,
            _TargetFrameworkMonikers.net7_0_tizen_7_0,
            _TargetFrameworkMonikers.net7_0_tvos,
            _TargetFrameworkMonikers.net7_0_tvos_16_1,
            _TargetFrameworkMonikers.net7_0_windows,
            _TargetFrameworkMonikers.net7_0_windows_7_0,
            _TargetFrameworkMonikers.net8_0,
            _TargetFrameworkMonikers.net8_0_android,
            _TargetFrameworkMonikers.net8_0_android_34_0,
            _TargetFrameworkMonikers.net8_0_browser,
            _TargetFrameworkMonikers.net8_0_ios,
            _TargetFrameworkMonikers.net8_0_ios_17_2,
            _TargetFrameworkMonikers.net8_0_maccatalyst,
            _TargetFrameworkMonikers.net8_0_maccatalyst_17_2,
            _TargetFrameworkMonikers.net8_0_macos,
            _TargetFrameworkMonikers.net8_0_macos_14_2,
            _TargetFrameworkMonikers.net8_0_tizen,
            _TargetFrameworkMonikers.net8_0_tizen_8_0,
            _TargetFrameworkMonikers.net8_0_tvos,
            _TargetFrameworkMonikers.net8_0_tvos_17_1,
            _TargetFrameworkMonikers.net8_0_windows,
            _TargetFrameworkMonikers.net8_0_windows_7_0,
            _TargetFrameworkMonikers.netcore,
            _TargetFrameworkMonikers.netcore45,
            _TargetFrameworkMonikers.netcore451,
            _TargetFrameworkMonikers.netcore50,
            _TargetFrameworkMonikers.netcoreapp1_0,
            _TargetFrameworkMonikers.netcoreapp1_1,
            _TargetFrameworkMonikers.netcoreapp2_0,
            _TargetFrameworkMonikers.netcoreapp2_1,
            _TargetFrameworkMonikers.netcoreapp2_2,
            _TargetFrameworkMonikers.netcoreapp3_0,
            _TargetFrameworkMonikers.netcoreapp3_1,
            _TargetFrameworkMonikers.netstandard1_0,
            _TargetFrameworkMonikers.netstandard1_1,
            _TargetFrameworkMonikers.netstandard1_2,
            _TargetFrameworkMonikers.netstandard1_3,
            _TargetFrameworkMonikers.netstandard1_4,
            _TargetFrameworkMonikers.netstandard1_5,
            _TargetFrameworkMonikers.netstandard1_6,
            _TargetFrameworkMonikers.netstandard2_0,
            _TargetFrameworkMonikers.netstandard2_1,
            _TargetFrameworkMonikers.sl4,
            _TargetFrameworkMonikers.sl5,
            _TargetFrameworkMonikers.uap,
            _TargetFrameworkMonikers.uap10_0,
            _TargetFrameworkMonikers.win,
            _TargetFrameworkMonikers.win10,
            _TargetFrameworkMonikers.win8,
            _TargetFrameworkMonikers.win81,
            _TargetFrameworkMonikers.winrt,
            _TargetFrameworkMonikers.wp,
            _TargetFrameworkMonikers.wp7,
            _TargetFrameworkMonikers.wp75,
            _TargetFrameworkMonikers.wp8,
            _TargetFrameworkMonikers.wp81,
            _TargetFrameworkMonikers.wpa81,
        };

        /// <summary>
        /// Deprecated target framework monikers.
        /// From: <see href="https://learn.microsoft.com/en-us/dotnet/standard/frameworks#deprecated-target-frameworks"/>
        /// </summary>
        public string[] N_0002 => new[]
        {
            _TargetFrameworkMonikers.aspnet50,
            _TargetFrameworkMonikers.aspnetcore50,
            _TargetFrameworkMonikers.dnxcore50,
            _TargetFrameworkMonikers.dnx,
            _TargetFrameworkMonikers.dnx45,
            _TargetFrameworkMonikers.dnx451,
            _TargetFrameworkMonikers.dnx452,
            _TargetFrameworkMonikers.dotnet,
            _TargetFrameworkMonikers.dotnet50,
            _TargetFrameworkMonikers.dotnet51,
            _TargetFrameworkMonikers.dotnet52,
            _TargetFrameworkMonikers.dotnet53,
            _TargetFrameworkMonikers.dotnet54,
            _TargetFrameworkMonikers.dotnet55,
            _TargetFrameworkMonikers.dotnet56,
            _TargetFrameworkMonikers.netcore50,
            _TargetFrameworkMonikers.win,
            _TargetFrameworkMonikers.win8,
            _TargetFrameworkMonikers.win81,
            _TargetFrameworkMonikers.win10,
            _TargetFrameworkMonikers.winrt
        };

        /// <summary>
        /// .NET 5+ and .NET Core
        /// From: <see href="https://learn.microsoft.com/en-us/dotnet/standard/frameworks#supported-target-frameworks"/>
        /// </summary>
        public string[] N_0003 => new[]
        {
            _TargetFrameworkMonikers.netcoreapp1_0,
            _TargetFrameworkMonikers.netcoreapp1_1,
            _TargetFrameworkMonikers.netcoreapp2_0,
            _TargetFrameworkMonikers.netcoreapp2_1,
            _TargetFrameworkMonikers.netcoreapp2_2,
            _TargetFrameworkMonikers.netcoreapp3_0,
            _TargetFrameworkMonikers.netcoreapp3_1,
            _TargetFrameworkMonikers.net5_0,
            _TargetFrameworkMonikers.net6_0,
            _TargetFrameworkMonikers.net7_0,
            _TargetFrameworkMonikers.net8_0
        };

        /// <summary>
        /// .NET Standard
        /// From: <see href="https://learn.microsoft.com/en-us/dotnet/standard/frameworks#supported-target-frameworks"/>
        /// </summary>
        public string[] N_0004 => new[]
        {
            _TargetFrameworkMonikers.netstandard1_0,
            _TargetFrameworkMonikers.netstandard1_1,
            _TargetFrameworkMonikers.netstandard1_2,
            _TargetFrameworkMonikers.netstandard1_3,
            _TargetFrameworkMonikers.netstandard1_4,
            _TargetFrameworkMonikers.netstandard1_5,
            _TargetFrameworkMonikers.netstandard1_6,
            _TargetFrameworkMonikers.netstandard2_0,
            _TargetFrameworkMonikers.netstandard2_1
        };

        /// <summary>
        /// .NET Framework
        /// From: <see href="https://learn.microsoft.com/en-us/dotnet/standard/frameworks#supported-target-frameworks"/>
        /// </summary>
        public string[] N_0005 => new[]
        {
            _TargetFrameworkMonikers.net11,
            _TargetFrameworkMonikers.net20,
            _TargetFrameworkMonikers.net35,
            _TargetFrameworkMonikers.net40,
            _TargetFrameworkMonikers.net403,
            _TargetFrameworkMonikers.net45,
            _TargetFrameworkMonikers.net451,
            _TargetFrameworkMonikers.net452,
            _TargetFrameworkMonikers.net46,
            _TargetFrameworkMonikers.net461,
            _TargetFrameworkMonikers.net462,
            _TargetFrameworkMonikers.net47,
            _TargetFrameworkMonikers.net471,
            _TargetFrameworkMonikers.net472,
            _TargetFrameworkMonikers.net48,
            _TargetFrameworkMonikers.net481
        };

        /// <summary>
        /// Windows Store
        /// From: <see href="https://learn.microsoft.com/en-us/dotnet/standard/frameworks#supported-target-frameworks"/>
        /// </summary>
        public string[] N_0006 => new[]
        {
            _TargetFrameworkMonikers.netcore,
            _TargetFrameworkMonikers.netcore45,
            _TargetFrameworkMonikers.netcore451,
            _TargetFrameworkMonikers.win,
            _TargetFrameworkMonikers.win8,
            _TargetFrameworkMonikers.win81
        };

        /// <summary>
        /// .NET Micro Framework
        /// From: <see href="https://learn.microsoft.com/en-us/dotnet/standard/frameworks#supported-target-frameworks"/>
        /// </summary>
        public string[] N_0007 => new[]
        {
            _TargetFrameworkMonikers.netmf
        };

        /// <summary>
        /// Silverlight
        /// From: <see href="https://learn.microsoft.com/en-us/dotnet/standard/frameworks#supported-target-frameworks"/>
        /// </summary>
        public string[] N_0008 => new[]
        {
            _TargetFrameworkMonikers.sl4,
            _TargetFrameworkMonikers.sl5,
        };

        /// <summary>
        /// Windows Phone
        /// From: <see href="https://learn.microsoft.com/en-us/dotnet/standard/frameworks#supported-target-frameworks"/>
        /// </summary>
        public string[] N_0009 => new[]
        {
            _TargetFrameworkMonikers.wp,
            _TargetFrameworkMonikers.wp7,
            _TargetFrameworkMonikers.wp75,
            _TargetFrameworkMonikers.wp8,
            _TargetFrameworkMonikers.wp81,
            _TargetFrameworkMonikers.wpa81,
        };

        /// <summary>
        /// Universal Windows Platform
        /// From: <see href="https://learn.microsoft.com/en-us/dotnet/standard/frameworks#supported-target-frameworks"/>
        /// </summary>
        public string[] N_0010 => new[]
        {
            _TargetFrameworkMonikers.uap,
            _TargetFrameworkMonikers.uap10_0,
            _TargetFrameworkMonikers.win10,
            _TargetFrameworkMonikers.netcore50
        };

        /// <summary>
        /// Operating system-specific
        /// From: <see href="https://learn.microsoft.com/en-us/dotnet/standard/frameworks#supported-target-frameworks"/>
        /// </summary>
        public string[] N_0011 => new[]
        {
            _TargetFrameworkMonikers.net5_0_windows,
            _TargetFrameworkMonikers.net6_0_android,
            _TargetFrameworkMonikers.net6_0_ios,
            _TargetFrameworkMonikers.net6_0_maccatalyst,
            _TargetFrameworkMonikers.net6_0_macos,
            _TargetFrameworkMonikers.net6_0_tvos,
            _TargetFrameworkMonikers.net6_0_windows,
            _TargetFrameworkMonikers.net7_0_android,
            _TargetFrameworkMonikers.net7_0_ios,
            _TargetFrameworkMonikers.net7_0_maccatalyst,
            _TargetFrameworkMonikers.net7_0_macos,
            _TargetFrameworkMonikers.net7_0_tizen,
            _TargetFrameworkMonikers.net7_0_tvos,
            _TargetFrameworkMonikers.net7_0_windows,
            _TargetFrameworkMonikers.net8_0_android,
            _TargetFrameworkMonikers.net8_0_browser,
            _TargetFrameworkMonikers.net8_0_ios,
            _TargetFrameworkMonikers.net8_0_maccatalyst,
            _TargetFrameworkMonikers.net8_0_macos,
            _TargetFrameworkMonikers.net8_0_tizen,
            _TargetFrameworkMonikers.net8_0_tvos,
            _TargetFrameworkMonikers.net8_0_windows,
        };

        /// <summary>
        /// Default target platform versions for operating system-specific target framework monikers.
        /// From: <see href="https://learn.microsoft.com/en-us/dotnet/standard/frameworks#supported-target-frameworks"/>
        /// </summary>
        public string[] N_0012 => new[]
        {
            _TargetFrameworkMonikers.net6_0_android_31_0,
            _TargetFrameworkMonikers.net6_0_ios_15_0,
            _TargetFrameworkMonikers.net6_0_maccatalyst_15_0,
            _TargetFrameworkMonikers.net6_0_macos_12_0,
            _TargetFrameworkMonikers.net6_0_tvos_15_1,
            _TargetFrameworkMonikers.net6_0_windows_7_0,
            _TargetFrameworkMonikers.net7_0_android_33_0,
            _TargetFrameworkMonikers.net7_0_ios_16_1,
            _TargetFrameworkMonikers.net7_0_maccatalyst_16_1,
            _TargetFrameworkMonikers.net7_0_macos_13_0,
            _TargetFrameworkMonikers.net7_0_tizen_7_0,
            _TargetFrameworkMonikers.net7_0_tvos_16_1,
            _TargetFrameworkMonikers.net7_0_windows_7_0,
            _TargetFrameworkMonikers.net8_0_android_34_0,
            _TargetFrameworkMonikers.net8_0_ios_17_2,
            _TargetFrameworkMonikers.net8_0_maccatalyst_17_2,
            _TargetFrameworkMonikers.net8_0_macos_14_2,
            _TargetFrameworkMonikers.net8_0_tizen_8_0,
            _TargetFrameworkMonikers.net8_0_tvos_17_1,
            _TargetFrameworkMonikers.net8_0_windows_7_0,
        };
    }
}

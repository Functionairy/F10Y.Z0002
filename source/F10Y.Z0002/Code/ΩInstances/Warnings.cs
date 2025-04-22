using System;


namespace F10Y.Z0002
{
    public class Warnings : IWarnings
    {
        #region Infrastructure

        public static IWarnings Instance { get; } = new Warnings();


        private Warnings()
        {
        }

        #endregion
    }
}

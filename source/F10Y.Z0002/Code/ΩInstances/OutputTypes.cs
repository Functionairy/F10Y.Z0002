using System;


namespace F10Y.Z0002
{
    public class OutputTypes : IOutputTypes
    {
        #region Infrastructure

        public static IOutputTypes Instance { get; } = new OutputTypes();


        private OutputTypes()
        {
        }

        #endregion
    }
}

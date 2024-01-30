using System;


namespace D8S.E0011
{
    public class ObjectOperator : IObjectOperator
    {
        #region Infrastructure

        public static IObjectOperator Instance { get; } = new ObjectOperator();


        private ObjectOperator()
        {
        }

        #endregion
    }
}

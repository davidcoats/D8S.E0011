using System;


namespace D8S.E0011
{
    public class PathOperator : IPathOperator
    {
        #region Infrastructure

        public static IPathOperator Instance { get; } = new PathOperator();


        private PathOperator()
        {
        }

        #endregion
    }
}

using System;


namespace D8S.E0011
{
    public static class Instances
    {
        public static R5T.L0066.IArrayOperator ArrayOperator => R5T.L0066.ArrayOperator.Instance;
        public static R5T.L0066.IDirectorySeparators DirectorySeparators => R5T.L0066.DirectorySeparators.Instance;
        public static R5T.L0066.IEnumerableOperator EnumerableOperator => R5T.L0066.EnumerableOperator.Instance;
        public static IObjectOperator ObjectOperator => E0011.ObjectOperator.Instance;
        public static IStringOperator StringOperator => E0011.StringOperator.Instance;
    }
}
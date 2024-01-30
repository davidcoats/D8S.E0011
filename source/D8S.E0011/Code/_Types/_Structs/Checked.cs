using System;


namespace D8S.E0011
{
    public struct Checked<TCheck>
    {
    }


    public static class CheckedExtensions
    {
        public static Checked<TAncestorCheck> As<TAncestorCheck, TCheck>(this Checked<TCheck> _)
            where TCheck : TAncestorCheck
        {
            Checked<TAncestorCheck> output;
            return output;
        }
    }
}

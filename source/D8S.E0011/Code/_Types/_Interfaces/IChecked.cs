using System;


namespace D8S.E0011
{
    // Covariant ("out") type parameter to allow IChecked<TDerivedCheck>, TDerivedCheck : TCheck to be used wherever an IChecked<TCheck> is needed.
    [Obsolete("See R5T.L0091.T000")]
    public interface IChecked<out TCheck>
    {
    }
}

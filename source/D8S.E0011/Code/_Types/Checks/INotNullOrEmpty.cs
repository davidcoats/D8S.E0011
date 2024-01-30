using System;


namespace D8S.E0011
{
    /// <summary>
    /// Check that a collection is not null or empty.
    /// </summary>
    [Obsolete("See R5T.L0092.T001")]
    public interface INotNullOrEmpty : ICheck,
        INotEmpty,
        INotNull
    {
    }
}

using System;

using R5T.T0132;


namespace D8S.E0011
{
    [Obsolete("See R5T.L0092"), FunctionalityMarker]
    public partial interface IObjectOperator : IFunctionalityMarker
    {
        public string To_String(
            object @object,
            Checked<INotNull> @checked)
        {
            var output = @object.ToString();
            return output;
        }

        public string To_String2(
            object @object,
            IChecked<INotNull> @checked)
        {
            var output = @object.ToString();
            return output;
        }
    }
}

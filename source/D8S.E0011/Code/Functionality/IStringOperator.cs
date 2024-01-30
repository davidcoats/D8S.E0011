using System;

using R5T.T0132;


namespace D8S.E0011
{
    [Obsolete("See R5T.L0092"), FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker,
        R5T.L0066.IStringOperator
    {
        public char Get_FirstCharacter(
            string @string,
            Checked<INotNullOrEmpty> @checked)
        {
            var output = Instances.EnumerableOperator.Get_First(@string);
            return output;
        }

        public char Get_FirstCharacter(
            string @string,
            IChecked<INotNullOrEmpty> @checked)
        {
            var output = Instances.EnumerableOperator.Get_First(@string);
            return output;
        }

        public char Get_FirstCharacter(
            string @string,
            out Checked<INotNullOrEmpty> @checked)
        {
            this.Verify_NotNullOrEmpty(
                @string,
                out @checked);

            var output = this.Get_FirstCharacter(
                @string,
                @checked);

            return output;
        }

        public char Get_FirstCharacter2(
            string @string,
            out IChecked<INotNullOrEmpty> @checked)
        {
            this.Verify_NotNullOrEmpty2(
                @string,
                out @checked);

            var output = this.Get_FirstCharacter(
                @string,
                @checked);

            return output;
        }

        public void Verify_NotNullOrEmpty(
            string @string,
            out Checked<INotNullOrEmpty> @checked)
        {
            var isNullOrEmpty = this.Is_NullOrEmpty(@string);
            if(isNullOrEmpty)
            {
                throw new Exception($"String was null or empty.");
            }
        }

        public void Verify_NotNullOrEmpty2(
            string @string,
            out IChecked<INotNullOrEmpty> @checked)
        {
            var isNullOrEmpty = this.Is_NullOrEmpty(@string);
            if (isNullOrEmpty)
            {
                throw new Exception($"String was null or empty.");
            }

            @checked = new CheckedImplementation<INotNullOrEmpty>();
        }
    }
}

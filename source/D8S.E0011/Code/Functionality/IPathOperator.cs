using System;

using R5T.T0132;


namespace D8S.E0011
{
    [Obsolete("See R5T.L0092"), FunctionalityMarker]
    public partial interface IPathOperator : IFunctionalityMarker
    {
        public bool Is_RootIndicated(
            string path,
            Checked<INotNullOrEmpty> @checked)
        {
            // Now get the first character.
            var firstCharacter = Instances.StringOperator.Get_FirstCharacter(
                path,
                @checked);

            var directorySeparators = Instances.DirectorySeparators.Both;

            // If the first character is a directory separator, then the path is root-indicated.
            var output = Instances.ArrayOperator.Contains(
                directorySeparators,
                firstCharacter);

            return output;
        }
    }
}

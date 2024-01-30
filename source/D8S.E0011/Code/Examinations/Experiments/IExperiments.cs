using System;

using R5T.T0141;


namespace D8S.E0011
{
    [ExperimentsMarker]
    public partial interface IExperiments : IExperimentsMarker
    {
        public void DoesCheckInterfaceInherit()
        {
            var @string = "ABC";

            //_ = Instances.StringOperator.Get_FirstCharacter(
            //    @string,
            //    out var @checked);

            //var result = Instances.ObjectOperator.To_String(
            //    @string,
            //    @checked.As<INotNull, INotNullOrEmpty>());

            _ = Instances.StringOperator.Get_FirstCharacter2(
                @string,
                out var @checked);

            var result = Instances.ObjectOperator.To_String2(
                @string,
                @checked);

            Console.WriteLine(result);
        }

        public void Try_GetFirstCharacter()
        {
            var @string = "ABC";

            var firstCharacter = Instances.StringOperator.Get_FirstCharacter(
                @string,
                out _);

            //Checked<INotNullOrEmpty> checkedNotNullOrEmpty;

            //var firstCharacter = Instances.StringOperator.Get_FirstCharacter(
            //    @string,
            //    checkedNotNullOrEmpty);

            Console.WriteLine($"'{firstCharacter}': the first character of \"{@string}\".");
        }
    }
}

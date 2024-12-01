using System.Numerics;
using System.Text.RegularExpressions;

namespace Rocketseat_Fundamentos_C_Sharp.Exercicios;
internal class CarPlate
{
    internal required string Plate { get; set; }

    internal bool CheckPlate()
    {
        string formualRegex = @"^[a-zA-Z]{3}\d{4}$";

        return Regex.IsMatch(Plate, formualRegex);
    }
}

using System;
using System.Text.RegularExpressions;

class NumeroCuenta
{
    private string entidad;
    private string sucursal;
    private string dCEntSuc;
    private string dCNumero;
    private string cuenta;

    public NumeroCuenta(string numero)
    {
        bool cuentaValida = formatoCorrecto(numero);

        if (cuentaValida)
            cuentaValida = dcCorrecto(dCEntSuc, entidad + sucursal, new int[] { 4, 8, 5, 10, 9, 7, 3, 6 });
        if (cuentaValida)
            cuentaValida = dcCorrecto(dCNumero, cuenta, new int[] { 1, 2, 4, 8, 5, 10, 9, 7, 3, 6 });
        if (!cuentaValida)
            throw new NumeroCuentaIncorrectoException($"Número de cuenta {numero} incorrecto.");
    }

    static private bool dcCorrecto(string dc, string digitos, int[] ponderaciones)
    {
        int valor = 0;

        for (int i = 0; i < digitos.Length; ++i)
            valor += (int)char.GetNumericValue(digitos, i) * ponderaciones[i];

        int dcAux = 11 - valor % 11;

        dcAux = (dcAux == 10) ? 1 : dcAux;
        dcAux = (dcAux == 11) ? 0 : dcAux;

        if (dcAux == Convert.ToInt32(dc))
            return true;
        else
            return false;
    }

    private bool formatoCorrecto(string numero)
    {
        Regex regex = new Regex(@"(?<Entidad>\d{4})[\s-_](?<Sucursal>\d{4})[\s-_](?<DCEntSuc>\d)(?<DCNumero>\d)[\s-_](?<Numero>\d{10})");
        Match match = regex.Match(numero);
        if (match.Success)
        {
            entidad = match.Groups["Entidad"].Value;
            sucursal = match.Groups["Sucursal"].Value;
            dCEntSuc = match.Groups["DCEntSuc"].Value;
            dCNumero = match.Groups["DCNumero"].Value;
            cuenta = match.Groups["Numero"].Value;
        }

        return match.Success;
    }

    public override string ToString()
    {
        return $"{entidad}-{sucursal}-{dCEntSuc}{dCNumero}-{cuenta}";
    }
}
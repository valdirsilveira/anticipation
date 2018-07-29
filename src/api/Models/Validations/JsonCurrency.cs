using System;
using System.ComponentModel.DataAnnotations;

public class JsonCurrency : RangeAttribute
{
    private new const decimal Minimum = 0;
    private new const decimal Maximum = (decimal) 999999.99;

    public JsonCurrency() : base(typeof(decimal), Minimum.ToString(), Maximum.ToString())
    {
        ErrorMessage = $"Amount between {Minimum} and {Maximum}.";
    }
}
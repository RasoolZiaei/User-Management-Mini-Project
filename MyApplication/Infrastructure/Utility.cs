using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Infrastructure;

public static class Utility : Object
{
    static Utility()
    {
        
    }

    public static string FixText(string? text)
    {
        if (string.IsNullOrWhiteSpace(value: text))
        {
            return string.Empty;
        }

        text =
            text.Trim();


        if (text.Length == 0)
        {
            return string.Empty;
        }

        while (text.Contains(value: "  "))
        {
            text =
                text.Replace
                (oldValue: "  ", newValue: " ");
        }

        return text;
    }
}

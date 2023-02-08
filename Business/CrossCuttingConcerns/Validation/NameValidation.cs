using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CrossCuttingConcerns.Validation
{
    public static class NameValidation
    {
        public static bool InvalidName(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsDigit(name[i]) || char.IsSymbol(name[i]))
                    return false;
            }
            return true;
        }
    }
}

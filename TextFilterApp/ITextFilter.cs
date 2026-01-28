using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilterApp
{
    public interface ITextFilter
    {
        string Apply(string input);
    }
}

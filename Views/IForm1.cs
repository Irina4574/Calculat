using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1.Views
{
    internal interface IForm1
    {
        event Action<float, float> OnAddition;
        event Action<float, float> OnSubstraction;
        event Action<float, float> OnMultiplication;
        event Action<float, float> OnDivision;
        

        void ShowResult(float result);

    }
}

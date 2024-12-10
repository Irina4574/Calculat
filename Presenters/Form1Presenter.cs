using Calculator1.Models;
using Calculator1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1.Presenters
{
    internal class Form1Presenter
    {
        private readonly Logics logics = new Logics();

        private readonly IForm1 _view;

        public Form1Presenter(IForm1 view)
        {
            _view = view;
            _view.OnAddition += Addition;
            _view.OnSubstraction += Substraction;
            _view.OnMultiplication += Multiplication;
            _view.OnDivision += Division;

        }



        private void Addition(float x, float y)
        {
            float result = logics.Addition(x, y);
            _view.ShowResult(result);
        }

        private void Substraction(float x, float y)
        {
            float result = logics.Substraction(x, y);
            _view.ShowResult(result);
        }

        private void Multiplication(float x, float y)
        {
            float result = logics.Multiplication(x, y);
            _view.ShowResult(result);
        }

        private void Division(float x, float y)
        {
            float result = logics.Division(x, y);
            _view.ShowResult(result);
        }

    }
}

using Calculator1.Views;

namespace Calculator1
{
    public partial class Form1 : Form, IForm1
    {
        public Form1()
        {
            InitializeComponent();

            result.Text = "0";

        }

        public event Action<float, float> OnAddition;
        public event Action<float, float> OnSubstraction;
        public event Action<float, float> OnMultiplication;
        public event Action<float, float> OnDivision;
        

        private void Addition(object sender, EventArgs e)
        {
            OnAddition?.Invoke(float.Parse(input1.Text), float.Parse(input2.Text));
        }

        private void Substraction(object sender, EventArgs e)
        {
            OnSubstraction?.Invoke(float.Parse(input1.Text), float.Parse(input2.Text));
        }

        private void Multiplication(object sender, EventArgs e)
        {
            OnMultiplication?.Invoke(float.Parse(input1.Text), float.Parse(input2.Text));
        }

        private void Division(object sender, EventArgs e)
        {
            OnDivision?.Invoke(float.Parse(input1.Text), float.Parse(input2.Text));
        }

        public void ShowResult(float resultOperation)
        {
            result.Text=resultOperation.ToString();
        }

    }

}

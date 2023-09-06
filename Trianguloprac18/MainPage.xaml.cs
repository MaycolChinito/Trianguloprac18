namespace Trianguloprac18
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }

        

        private void Button_Clicked(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(ladoA.Text);
            double B = Convert.ToDouble(ladoB.Text);
            double C = Convert.ToDouble(ladoC.Text);

            double Peri = (A + B + C) / 2;
            double area = Peri * ((Peri - A) * (Peri - B) * (Peri - C));
            double raiz = Math.Sqrt(area);
            string r = Convert.ToString(raiz);

            arearespuesta.Text = "El resultado es : " + r;
        }
    }
}
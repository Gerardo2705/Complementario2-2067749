namespace Complementario2_2067749
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(n1.Text) && !string.IsNullOrEmpty(n2.Text))
            {
                int nu1,nu2, resultado;

                nu1 = Convert.ToInt32(n1.Text);
                nu2 = Convert.ToInt32(n2.Text);
                resultado = (nu1 + nu2) ^ 2 / 2;
                ResultLabel.Text = resultado.ToString();

            }
            else
            {
                DisplayAlert("ERROR", "La regaste chelito, volvelo a hacer", "Okis");
            }
        }
    }

}

namespace CadastroClientesMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Registrar o HttpClient para consumo da API
            DependencyService.Register<HttpClient>();

            MainPage = new MainPage();
        }
    }
}

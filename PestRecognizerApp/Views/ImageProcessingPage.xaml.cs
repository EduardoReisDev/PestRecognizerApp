using PestRecognizerApp.Model;
using PestRecognizerApp.ViewModel;

namespace PestRecognizerApp.Views
{
    public partial class ImageProcessingPage : ContentPage
    {
        private readonly ImageProcessingViewModel _viewModel;

        public ImageProcessingPage(bool useCamera)
        {
            InitializeComponent();

            _viewModel = new ImageProcessingViewModel();
            BindingContext = _viewModel;

            _viewModel.GoResultPage += GoResultPage;
            _viewModel.ErrorPrediction += ErrorPredictionAction;
            _viewModel.ErrorImage += ErrorImageAction;

            Initialize(useCamera);
        }

        private void ErrorImageAction(object sender, EventArgs e)
        {
            DisplayAlert("Atenção",
                "Não conseguimos identificar a imagem.",
                "Tentar novamente");

            Navigation.PopAsync();
        }

        private void ErrorPredictionAction(object sender, EventArgs e)
        {
            DisplayAlert("Atenção",
                "Houve um erro a fazer a predição da imagem.",
                "Tentar novamente");

            Navigation.PopAsync();
        }

        private async void Initialize(bool useCamera)
        {
            await _viewModel.ProcessPhoto(useCamera);
        }

        private void GoResultPage(object sender, PredictionResult result)
        {
            Navigation.PushAsync(new ResultPage(result));
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            _viewModel.GoResultPage -= GoResultPage;
        }
    }
}

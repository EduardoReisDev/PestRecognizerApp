using PestRecognizerApp.Model;

namespace PestRecognizerApp.Views;

public partial class ResultPage : ContentPage
{
	public ResultPage(PredictionResult predictionResult)
	{
		InitializeComponent();

		BuildResultPage(predictionResult);
	}

    private void BuildResultPage(PredictionResult predictionResult)
    {
        ResultImage.Source = ImageSource.FromFile(predictionResult.IsHealthy ? "ic_healthy.png" : "ic_not_healthy.png");
        ResultText.Text = predictionResult.IsHealthy ? "Planta saudável!" : "Planta não saudável!";
        ResultProbability.Text = $"{predictionResult.Probability} de probabilidade";
    }

    private void RescanButton_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new HomePage());
    }
}

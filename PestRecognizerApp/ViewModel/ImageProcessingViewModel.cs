using PestRecognizerApp.Model;
using PestRecognizerApp.Services;
using PestRecognizerApp.Utils;

namespace PestRecognizerApp.ViewModel
{
	public class ImageProcessingViewModel : BaseViewModel
    {
        public EventHandler<PredictionResult> GoResultPage;
        public EventHandler ErrorPrediction;
        public EventHandler ErrorImage;

        public string ProcessStep
        {
            get => _processStep;
            set => SetProperty(ref _processStep, value);
        }
        
        private string _processStep;

        public ImageProcessingViewModel() { }

        public async Task ProcessPhoto(bool useCamera)
        {
            ProcessStep = "Aguardando imagem...";

            var photo = useCamera
              ? await MediaPicker.Default.CapturePhotoAsync()
              : await MediaPicker.Default.PickPhotoAsync();

            if (photo != null)
            {
                ProcessStep = "Compactando imagem...";

                var resizedPhoto = await ResizePhoto.FromStream(photo);

                ProcessStep = "Processando imagem...";

                var result = await CustomVisionServices.ClassifyImage(new MemoryStream(resizedPhoto));

                if (!string.IsNullOrEmpty(result.TagName))
                {
                    PredictionResult predictionResult = new()
                    {
                        Probability = result.Probability.ToString("P1"),
                        ResultTag = result.TagName,
                        IsHealthy = result.TagName.Equals("healthy"),
                    };

                    GoResultPage?.Invoke(this, predictionResult);
                }
                else {
                    ErrorPrediction?.Invoke(this, EventArgs.Empty);
                }
            }
            else
            {
                ErrorImage?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}

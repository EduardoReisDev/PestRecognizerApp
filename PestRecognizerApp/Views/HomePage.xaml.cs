namespace PestRecognizerApp.Views;

public partial class HomePage : ContentPage
{
    private bool isBottomSheetOpen = false;
    private CameraOrGalleryBottomSheet bottomSheet;

    public HomePage()
	{
		InitializeComponent();
	}

    private void ShowCameraOrGalleryBottomSheet_Clicked(object sender, EventArgs e)
    {
        if (!isBottomSheetOpen)
        {
            isBottomSheetOpen = true;

            bottomSheet = new CameraOrGalleryBottomSheet
            {
                HasHandle = true
            };

            bottomSheet.SelectCamera += BottomSheet_SelectCamera;
            bottomSheet.SelectGallery += BottomSheet_SelectGallery;

            bottomSheet.ShowAsync(Window);
        }
    }

    private void BottomSheet_SelectCamera(object sender, EventArgs e)
    {
        NavigateToImageProcessingPage(true);
    }

    private void BottomSheet_SelectGallery(object sender, EventArgs e)
    {
        NavigateToImageProcessingPage(false);
    }

    private void NavigateToImageProcessingPage(bool useCamera)
    {
        bottomSheet.DismissAsync();
        isBottomSheetOpen = false;

        Navigation.PushAsync(new ImageProcessingPage(useCamera));
    }
}

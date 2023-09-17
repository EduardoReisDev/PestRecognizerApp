using The49.Maui.BottomSheet;

namespace PestRecognizerApp.Views;

public partial class CameraOrGalleryBottomSheet : BottomSheet
{
    public EventHandler SelectCamera;
    public EventHandler SelectGallery;

	public CameraOrGalleryBottomSheet()
	{
		InitializeComponent();
	}

    private void CameraButton_Clicked(object sender, EventArgs e)
    {
        SelectCamera?.Invoke(this, EventArgs.Empty);
    }

    private void GalleryButton_Clicked(object sender, EventArgs e)
    {
        SelectGallery?.Invoke(this, EventArgs.Empty);
    }
}

using Microsoft.Maui.Graphics.Platform;

namespace PestRecognizerApp.Utils
{
	public class ResizePhoto
	{
        private const int _imageMaxSizeBytes = 4194304;
        private const int _imageMaxResolution = 1024;

        public static async Task<byte[]> FromStream(FileResult photo)
        {
            byte[] result = null;

            using (var stream = await photo.OpenReadAsync())
            {
                if (stream.Length > _imageMaxSizeBytes)
                {
                    var image = PlatformImage.FromStream(stream);
                    if (image != null)
                    {
                        var newImage = image.Downsize(_imageMaxResolution, true);
                        result = newImage.AsBytes();
                    }
                }
                else
                {
                    using var binaryReader = new BinaryReader(stream);
                    result = binaryReader.ReadBytes((int)stream.Length);
                }
            }

            return result;
        }
    }
}


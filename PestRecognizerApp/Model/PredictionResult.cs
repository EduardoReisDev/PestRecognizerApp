using System;
namespace PestRecognizerApp.Model
{
	public class PredictionResult
	{
		public bool IsHealthy { get; set; }
		public string ResultTag { get; set; }
		public string Probability { get; set; }
    }
}

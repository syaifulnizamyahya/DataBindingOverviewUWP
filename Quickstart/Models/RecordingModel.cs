using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Quickstart.Models
{
	// for binding
	//[Bindable]
	public class RecordingModel
	//public ref class RecordingModel sealed
	{
		public string ArtistName { get; set; }
		public string CompositionName { get; set; }
		public DateTime ReleaseDateTime { get; set; }

		public RecordingModel()
		{
			ArtistName = "Wolf";
			CompositionName = "Andante";
			ReleaseDateTime = new DateTime(1761, 1, 1);
		}

		public string OneLineSummary
		{
			get
			{
				return $"{CompositionName} by {ArtistName}, released: "
					+ ReleaseDateTime.ToString("d");
			}
		}
	}
}

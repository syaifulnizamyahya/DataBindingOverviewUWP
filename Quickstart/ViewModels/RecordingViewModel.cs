using Quickstart.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quickstart.ViewModels
{
	public class RecordingViewModel
	{

		private RecordingModel _DefaultRecording = new RecordingModel();
		public RecordingViewModel()
		{
			Recordings.Add(new RecordingModel()
			{
				ArtistName = "Bach",
				CompositionName = "B Minor",
				ReleaseDateTime = new DateTime(1748, 7, 8)
			});

			Recordings.Add(new RecordingModel()
			{
				ArtistName = "Abu",
				CompositionName = "X Minor",
				ReleaseDateTime = new DateTime(1788, 7, 8)
			});

			Recordings.Add(new RecordingModel()
			{
				ArtistName = "Ali",
				CompositionName = "D Minor",
				ReleaseDateTime = new DateTime(1755, 7, 8)
			});
		}

		public RecordingModel DefaultRecording
		{
			get { return _DefaultRecording; }
		}

		public ObservableCollection<RecordingModel> Recordings { get; } = new ObservableCollection<RecordingModel>();
	}
}

using Quickstart.ViewModels;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Quickstart.Views
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class RecordingView : Page
	{

		// for xbind
		public RecordingViewModel ViewModel { get; set; } = new RecordingViewModel();

		public RecordingView()
		{
			this.InitializeComponent();

			//for binding : datacontext in cs
			//DataContext = new RecordingViewModel();

		}
	}
}

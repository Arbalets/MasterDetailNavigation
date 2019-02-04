using Prism.Commands;
using Prism.Navigation;

namespace MasterDetailNavigation.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            NavigateToChildCommand = new DelegateCommand(async () => await NavigationService.NavigateAsync("ChildPage"));
        }

        public DelegateCommand NavigateToChildCommand { get; }

        private string _status;
        public string Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }

        private bool _isAlreadyLoaded;

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            if (_isAlreadyLoaded)
            {
                Status = "Page Already Loaded!";
            }
            else
            {
                Status = "A New Page!";
                _isAlreadyLoaded = true;
            }
        }
    }
}

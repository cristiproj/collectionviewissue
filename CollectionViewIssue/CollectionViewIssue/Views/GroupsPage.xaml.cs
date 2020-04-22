using CollectionViewIssue.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewIssue.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GroupsPage : ContentPage
    {
        public GroupsPage()
        {
            InitializeComponent();
            var viewModel = new GroupsViewModel();
            BindingContext = viewModel;
        }
    }
}
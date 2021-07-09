using bam.xamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace bam.xamarin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
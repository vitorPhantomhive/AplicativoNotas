using Notas.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Notas.Views
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
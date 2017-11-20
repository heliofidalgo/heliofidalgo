
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_MasterDetailPage.Model;

namespace XF_MasterDetailPage.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContaDetalhesPage : ContentPage
    {
        public ContaDetalhesPage(Conta conta)
        {
            InitializeComponent();
            BindingContext = conta;
        }

    }
}
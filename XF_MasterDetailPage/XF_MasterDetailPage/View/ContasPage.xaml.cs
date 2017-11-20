
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_MasterDetailPage.Model;
using XF_MasterDetailPage.ViewModel;


namespace XF_MasterDetailPage.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContasPage : ContentPage
    {
        private ObservableCollection<Conta> _contas;
        public ContasPage()
        {
            InitializeComponent();
            _contas = ContaService.GetContas();
            lvContas.ItemsSource = _contas;
        }

        private async void lvContas_ItemSeleted(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var conta = e.SelectedItem as Conta;
            await Navigation.PushAsync(new ContaDetalhesPage(conta));
            lvContas.SelectedItem = null;
        }
    }
}
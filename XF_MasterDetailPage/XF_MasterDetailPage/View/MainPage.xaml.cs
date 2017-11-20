using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_MasterDetailPage.Model;
using XF_MasterDetailPage.ViewModel;

namespace XF_MasterDetailPage.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        //private ObservableCollection<Conta> _contas;
        private ObservableCollection<MasterPageItem> _menuLista;

        public MainPage()
        {
            InitializeComponent();
            _menuLista = ItemService.GetMenuItens();
            NavigationDrawerList.ItemsSource = _menuLista;
            //_contas = ContaService.GetContas();
            //lvContas.ItemsSource = _contas;
            Detail = new NavigationPage((Page) Activator.CreateInstance(typeof(HomePage)));
        }

        private void lvContas_ItemSeleted(object sender, SelectedItemChangedEventArgs e)
        {
           // var conta = e.SelectedItem as Conta;
           // await Navigation.PushAsync(new ContaDetalhesPage(conta));
           // Detail = new ContaDetalhesPage(conta);
           // exibe a pagina de detalhes
           //IsPresented = false;
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem) e.SelectedItem;
            //obtem o tipo de objeto
            Type pagina = item.TargetType;

            //abre a pagina corresponndente ao item selecionado
            //Cria uma instância do tipo especificado usado construtor que melhor se adequa ao parametro informado

            Detail = new NavigationPage((Page)Activator.CreateInstance(pagina));
            IsPresented = false;
        }
    }
}
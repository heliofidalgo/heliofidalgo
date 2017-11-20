using System.Collections.ObjectModel;
using XF_MasterDetailPage.Model;
using XF_MasterDetailPage.View;

namespace XF_MasterDetailPage.ViewModel
{
    public class ItemService
    {
        private static ObservableCollection<MasterPageItem> menuLista { get; set; }

        public static ObservableCollection<MasterPageItem> GetMenuItens()
        {
            menuLista = new ObservableCollection<MasterPageItem>();
            //Criando as paginas para navegacao
            //Definimos o titulo para o item
            //O icone 
            var pagina1 = new MasterPageItem() { Title = "Home", Icon = "Home32.png", TargetType = typeof(HomePage) };
            var pagina2 = new MasterPageItem() { Title = "Contas", Icon = "Account32.png", TargetType = typeof(ContasPage) };
            var pagina3 = new MasterPageItem() { Title = "Lançamento", Icon = "CheckBox32.png", TargetType = typeof(LancamentosPage) };
            var pagina4 = new MasterPageItem() { Title = "Relatório", Icon = "BarChart32.png", TargetType = typeof(RelatoriosPage) };
            // Adicionando intens no menu lista
            menuLista.Add(pagina1);
            menuLista.Add(pagina2);
            menuLista.Add(pagina3);
            menuLista.Add(pagina4);
            //retorna lista dos itens
            return menuLista;
        }
    }
}

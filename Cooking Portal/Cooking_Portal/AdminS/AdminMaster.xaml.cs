using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cooking_Portal.Admin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminMaster : ContentPage
    {
        public ListView ListView;

        public AdminMaster()
        {
            InitializeComponent();

            BindingContext = new AdminMasterViewModel();
            ListView = MenuItemsListView;
        }

        class AdminMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<AdminMenuItem> MenuItems { get; set; }

            public AdminMasterViewModel()
            {
                MenuItems = new ObservableCollection<AdminMenuItem>(new[]
                {
                    new AdminMenuItem { Id = 0, Title = "Page 1" },
                    new AdminMenuItem { Id = 1, Title = "Page 2" },
                    new AdminMenuItem { Id = 2, Title = "Page 3" },
                    new AdminMenuItem { Id = 3, Title = "Page 4" },
                    new AdminMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}
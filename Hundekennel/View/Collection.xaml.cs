using Hundekennel.Model;
using Hundekennel.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hundekennel.View
{
    /// <summary>
    /// Interaction logic for Collection.xaml
    /// </summary>
    public partial class Collection : UserControl
    {
       private CollectionViewModel viewModel = new(new DogRepository());
        public Collection()
        {
            InitializeComponent();
            viewModel = (CollectionViewModel?)DataContext; 

        }
    }
}

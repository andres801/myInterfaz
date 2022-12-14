using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace interfaz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdministerProducts : TabbedPage
    {
        public AdministerProducts()
        {
            InitializeComponent();
        }
    }
}
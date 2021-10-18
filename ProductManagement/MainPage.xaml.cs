using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ProductManagement.Model;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProductManagement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icons> Icons;
        
        private ObservableCollection<Product> Products;
        public MainPage()
        {
            this.InitializeComponent();
            Icons = new List<Icons>();
            Icons.Add(new Icons { IconPath = "Assets/StoreLogo.png" });
            Icons.Add(new Icons { IconPath = "Assets/product1.png" });
            Icons.Add(new Icons { IconPath = "Assets/product2.png" });
            Icons.Add(new Icons { IconPath = "Assets/product3.png" });

            
            Products = new ObservableCollection<Product>();

        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            string avatar = ((Icons)AvatarComboBox.SelectedValue).IconPath;
            Products.Add(new Product { ProductName = ProductTextBox.Text, Description = DescriptionTextBox.Text, AvatarPath = avatar });
            ProductTextBox.Text = "";
            DescriptionTextBox.Text = "";
            AvatarComboBox.SelectedIndex = -1;

            ProductTextBox.Focus(FocusState.Programmatic);
        }
    }
}

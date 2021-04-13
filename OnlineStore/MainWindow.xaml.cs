using OnlineStore.Models;
using System;
using System.Collections.Generic;
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

namespace OnlineStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> Products { get; set; } = new List<Product>
        {
            new Product
            {
                Name = "Defender Reborn GK-165DL",
                Description = $@"Rainbow backlight
Backlight of symbols and keys
Double injection technology
Symbols will not be weared down as the keys are molded of two plastic colours: black for the key body and white / transparent for the sybols.
Hot keys for quick access to office, multimedia and internet applications
High durability
Locking of WIN key when playing a game
Adjustable 3-level brightness of the backlight
Anti-Ghost keys
Backlight speed control FN + cursor right/left keys
9 modes of dynamic backlight
Wrist rest with magnetic mounts is included
Sonorous sound / switch click",
                Price="60 AZN",
                ImagePath = "defenderReborn.png"
            },
        };
        public MainWindow()
        {
            InitializeComponent();
            ProductListLb.ItemsSource = Products;
        }
    }
}

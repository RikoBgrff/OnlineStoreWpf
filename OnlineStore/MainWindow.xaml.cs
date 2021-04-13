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
            new Product
            {
                Name = "iPhone 12 Pro Max 256 GB",
                Description = $@"The phone is powered by the new Apple A14 Bionic processor. The smartphone comes with a 6.7 inches 
Super Retina XDR OLED capacitive touchscreen, 2778 x 1284 pixels resolution and HDR display, True Tone and Wide color (P3) gamut.
Additionally, the screen of the device is protected by a unique ceramic shield.  Along with this, the screen features 1200 nits max brightness
(advertised), Dolby Vision, HDR10+, Wide color gamut, True-tone, and 120Hz refresh rate.
The rear camera consists of a 12 MP (wide) + 12 MP (telephoto) 5x optical zoom + 12 MP (ultrawide) and also a LiDAR scanner for night mode.
The front camera has a 12 MP (wide) + SL 3D (depth/biometrics sensor) camera sensor. The phone’s sensors include Lidar, 
Face ID, accelerometer, gyro, proximity, compass, barometer + Siri natural language commands, and dictation.
The smartphone is fueled by a non-removable 
Li-Ion battery + Fast charging 20W+ USB Power Delivery 2.0 + 7W Qi wireless charging and 15W MagSafe Wireless Charging. 
The phone runs on iOS 14 operating system.
The Apple iPhone 12 Pro Max comes in different colors like Graphite, Silver, Gold, Pacific Blue. 
It features 2.0, proprietary reversible connector.",
                Price="3369.99 AZN",
                ImagePath = "iPhone12ProMax.png"
            },
            new Product
            {
                Name = "Mitsubishi Lancer Evolution 8",
                Description = $@"Mitsubishi introduced the Lancer Evolution IX in Japan on March 3,
2005 and exhibited the car at 
the Geneva Motor Show for the European market the same day.
The North American markets saw the model exhibited 
at the New York International Auto Show the following month.
The 2.0 L (1,997 cc) 
4G63 Inline-four engine has
MIVEC technology (variable valve timing), 
and a revised turbocharger 
design boosting official power output at the crankshaft to 291 PS (214 kW; 287 hp) and torque to 392 N⋅m (289 lb⋅ft).
",
                Price="40.000 AZN",
                ImagePath = "mEvo8.png"
            },
            new Product
            {
                Name = "HP Pavilion Gaming 17-cd1016ur",
                Description = $@"Intel® Core™ i5-10300H
16 GB DDR4-2933 SDRAM (2 x 8 GB)
NVIDIA® GeForce® GTX 1660 Ti
256 GB PCIe® NVMe™ M.2 SSD
1 TB 7200 rpm SATA",
                Price="2700 AZN",
                ImagePath = "hpPavilion.png"
            },
        };
        public MainWindow()
        {
            InitializeComponent();
            ProductListLb.ItemsSource = Products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}

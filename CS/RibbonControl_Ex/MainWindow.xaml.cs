// Developer Express Code Central Example:
// How to bind a property inside the BarStaticItem.ContentTemplate to a ViewModel property
// 
// Assign the ViewModel instance to the RibbonControl.DataContext property. While
// binding a property in the BarStaticItem.ContentTemplate, use the RibbonControl
// name as the ElementName. The binding path should be the same as when you address
// the RibbonControl properties.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2567

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Editors.Settings;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Threading;
using DevExpress.Xpf.Ribbon;

namespace RibbonControl_Ex {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXRibbonWindow {
        
        public MainWindow() {
            InitializeComponent();
           
            vm =new ViewModel();
            vm.SliderValue = 30;
           /// RibbonControl1.DataContext = vm;
            barManager.DataContext = vm;
        }

        ViewModel vm;
 

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            vm.SliderValue = 70;
        }

    }

    public class ViewModel : DependencyObject
    {


        public int SliderValue
        {
            get { return (int)GetValue(SliderValueProperty); }
            set { SetValue(SliderValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SliderValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SliderValueProperty =
            DependencyProperty.Register("SliderValue", typeof(int), typeof(ViewModel), new UIPropertyMetadata(50));

        
    }

    public class RecentItem {
        public int Number { get; set; }
        public string FileName { get; set; }
    }

    public class ButtonWithImageContent {
        public string ImageSource { get; set; }
        public object Content { get; set; }
    }

    public class FontSizes {
        public double[] Items {
            get {
                return new double[] { 
            3.0, 4.0, 5.0, 6.0, 6.5, 7.0, 7.5, 8.0, 8.5, 9.0, 9.5, 
            10.0, 10.5, 11.0, 11.5, 12.0, 12.5, 13.0, 13.5, 14.0, 15.0,
            16.0, 17.0, 18.0, 19.0, 20.0, 22.0, 24.0, 26.0, 28.0, 30.0,
            32.0, 34.0, 36.0, 38.0, 40.0, 44.0, 48.0, 52.0, 56.0, 60.0, 64.0, 68.0, 72.0, 76.0,
            80.0, 88.0, 96.0, 104.0, 112.0, 120.0, 128.0, 136.0, 144.0
            };
            }
        }
    }

    public class DecimatedFontFamilies : FontFamilies {
        const int DecimationFactor = 5;

        public override ObservableCollection<FontFamily> Items {
            get {
                ObservableCollection<FontFamily> res = new ObservableCollection<FontFamily>();
                for (int i = 0; i < ItemsCore.Count; i++) {
                    if (i % DecimationFactor == 0)
                        res.Add(ItemsCore[i]);
                }
                return res;
            }
        }
    }

    public class FontFamilies {
        static ObservableCollection<FontFamily> items;
        protected static ObservableCollection<FontFamily> ItemsCore {
            get {
                if (items == null) {
                    items = new ObservableCollection<FontFamily>();
                    foreach (FontFamily fam in Fonts.SystemFontFamilies) {
                        if (!IsValidFamily(fam)) continue;
                        items.Add(fam);
                    }
                }
                return items;
            }
        }
        public static bool IsValidFamily(FontFamily fam) {
            foreach (Typeface f in fam.GetTypefaces()) {
                GlyphTypeface g = null;
                try {
                    if (f.TryGetGlyphTypeface(out g))
                        if (g.Symbol) return false;
                }
                catch (Exception) {
                    return false;
                }
            }
            return true;
        }
        public virtual ObservableCollection<FontFamily> Items {
            get {
                ObservableCollection<FontFamily> res = new ObservableCollection<FontFamily>();
                foreach (FontFamily fm in ItemsCore) {
                    res.Add(fm);
                }
                return res;
            }
        }
    }
}

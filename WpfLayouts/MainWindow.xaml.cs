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

namespace WpfLayouts
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();
       
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Button buttonBackward = new Button();
            buttonBackward.Content = new Image().Source = new BitmapImage(new Uri("backward.png", UriKind.Relative));
            StackPanel.Children.Add(buttonBackward);

            Button buttonForward = new Button();
            buttonForward.Content = new Image().Source = new BitmapImage(new Uri("forward.png", UriKind.Relative));
            StackPanel.Children.Add(buttonForward);

            Button buttonOpen = new Button();
            buttonOpen.Content = new Image().Source = new BitmapImage(new Uri("open.png", UriKind.Relative));
            StackPanel.Children.Add(buttonOpen);

            Button buttonSave = new Button();
            buttonSave.Content = new Image().Source = new BitmapImage(new Uri("save.png", UriKind.Relative));
            StackPanel.Children.Add(buttonSave);

            Button buttonSaveAll = new Button();
            buttonSaveAll.Content = new Image().Source = new BitmapImage(new Uri("save_all.png", UriKind.Relative));
            StackPanel.Children.Add(buttonSaveAll);
        }
    }
}
 
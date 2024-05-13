using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
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
using static System.Net.WebRequestMethods;

namespace CourseWorkUserApp
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      var window = Window.GetWindow(this);
      window.KeyDown += F1Event;
    }

    private void F1Event(object sender, KeyEventArgs e)
    {
      if (e.Key == Key.F1)
      {
        //System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.FileName = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
        startInfo.UseShellExecute = true;
        Process.Start(startInfo);
      }
    }
  }
}

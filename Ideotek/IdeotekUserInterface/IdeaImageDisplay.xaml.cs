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

namespace IdeotekUserInterface
{
    /// <summary>
    /// Interaction logic for IdeaImageDisplay.xaml
    /// </summary>
    public partial class IdeaImageDisplay : UserControl
    {
        public IdeaImageDisplay()
        {
            InitializeComponent();
            StylusDown += this.OnStylusDown;
        }

        void OnStylusDown(object sender, StylusDownEventArgs args)
        {
            Console.WriteLine("StylusDown");
        }
    }
}

using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace IdeotekUserInterface
{
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

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace IdeotekUserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Row> Rows { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;

            Rows = new ObservableCollection<Row>();
            Rows.Add(new Row
            {
                Text = "Bonjour"
            });
        }

        public class Row
        {
            public string Text { get; set; }
        }
    }
}

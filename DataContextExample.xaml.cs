﻿using System;
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
using System.Windows.Shapes;

namespace WpfAdvanceControl
{
    /// <summary>
    /// Interaction logic for DataContextExample.xaml
    /// </summary>
    public partial class DataContextExample : Window
    {
        public DataContextExample()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}

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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Client.ViewModels;
using Client.Models;

namespace Client
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ClientModel clientModel = new ClientModel();
            FilesViewModel filesViewModel = new FilesViewModel(clientModel);
            ClientViewModel clientViewModel = new ClientViewModel(filesViewModel);
            listbox_files.DataContext = filesViewModel;
            DataContext = clientViewModel;   
        }
    }
}

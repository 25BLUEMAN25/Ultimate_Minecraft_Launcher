﻿using Ultimate_Minecraft_Launcher.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace Ultimate_Minecraft_Launcher.Views.Pages
{
    public partial class DataPage : INavigableView<DataViewModel>
    {
        public DataViewModel ViewModel { get; }

        public DataPage(DataViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}

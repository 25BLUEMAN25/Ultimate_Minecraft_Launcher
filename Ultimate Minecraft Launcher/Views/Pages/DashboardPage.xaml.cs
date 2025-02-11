﻿using Ultimate_Minecraft_Launcher.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace Ultimate_Minecraft_Launcher.Views.Pages
{
    public partial class DashboardPage : INavigableView<DashboardViewModel>
    {
        public DashboardViewModel ViewModel { get; }

        public DashboardPage(DashboardViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}

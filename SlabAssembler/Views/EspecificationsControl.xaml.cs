﻿using System.Windows.Controls;
using Urbbox.SlabAssembler.Core;
using Urbbox.SlabAssembler.Repositories;
using Urbbox.SlabAssembler.ViewModels;

namespace Urbbox.SlabAssembler.Views
{
    /// <summary>
    /// Interaction logic for EspecificationsControl.xaml
    /// </summary>
    public partial class EspecificationsControl : UserControl
    {
        public EspecificationsViewModel ViewModel { get; protected set; }

        public EspecificationsControl(ConfigurationsRepository manager, SlabBuilder builder)
        {
            ViewModel = new EspecificationsViewModel(manager, builder);
            //builder.Especifications.PartsEspecifications = ViewModel;
            DataContext = ViewModel;
            InitializeComponent();
        }

    }
}

﻿#pragma checksum "D:\DotNet\Gama\RadiologyTracking\RadiologyTracking\Views\Energies.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6EEE178C92B38BC79F330EF359091D6F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RadiologyTracking.Controls;
using RadiologyTracking.CustomControls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace RadiologyTracking.Views {
    
    
    public partial class Energies : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.DomainDataSource energyDomainDataSource;
        
        internal RadiologyTracking.Controls.BusyIndicator busyIndicator;
        
        internal RadiologyTracking.CustomControls.CustomGrid energyDataGrid;
        
        internal System.Windows.Controls.DataGridTextColumn nameColumn;
        
        internal System.Windows.Controls.Button btnSave;
        
        internal System.Windows.Controls.Button btnCancel;
        
        internal System.Windows.Controls.Button btnAdd;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/RadiologyTracking;component/Views/Energies.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.energyDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("energyDomainDataSource")));
            this.busyIndicator = ((RadiologyTracking.Controls.BusyIndicator)(this.FindName("busyIndicator")));
            this.energyDataGrid = ((RadiologyTracking.CustomControls.CustomGrid)(this.FindName("energyDataGrid")));
            this.nameColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("nameColumn")));
            this.btnSave = ((System.Windows.Controls.Button)(this.FindName("btnSave")));
            this.btnCancel = ((System.Windows.Controls.Button)(this.FindName("btnCancel")));
            this.btnAdd = ((System.Windows.Controls.Button)(this.FindName("btnAdd")));
        }
    }
}


﻿#pragma checksum "D:\DotNet\Gama\RadiologyTracking\RadiologyTracking\Views\Copy of FixedPatternPerformance.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4FBABDD8B13110FA0A346A65B965BE23"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BindableDataGrid;
using RadiologyTracking.Controls;
using RadiologyTracking.Views;
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
    
    
    public partial class FixedPatternPerformance : RadiologyTracking.Views.BaseCRUDView {
        
        internal System.Windows.Controls.Label headerLabel;
        
        internal System.Windows.Controls.StackPanel panel;
        
        internal System.Windows.Controls.TextBox txtFPNo;
        
        internal System.Windows.Controls.Button btnFetch;
        
        internal RadiologyTracking.Controls.BusyIndicator busyIndicator;
        
        internal BindableDataGrid.BindableDataGrid reportGrid;
        
        internal System.Windows.Controls.Button btnExport;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/RadiologyTracking;component/Views/Copy%20of%20FixedPatternPerformance.xaml", System.UriKind.Relative));
            this.headerLabel = ((System.Windows.Controls.Label)(this.FindName("headerLabel")));
            this.panel = ((System.Windows.Controls.StackPanel)(this.FindName("panel")));
            this.txtFPNo = ((System.Windows.Controls.TextBox)(this.FindName("txtFPNo")));
            this.btnFetch = ((System.Windows.Controls.Button)(this.FindName("btnFetch")));
            this.busyIndicator = ((RadiologyTracking.Controls.BusyIndicator)(this.FindName("busyIndicator")));
            this.reportGrid = ((BindableDataGrid.BindableDataGrid)(this.FindName("reportGrid")));
            this.btnExport = ((System.Windows.Controls.Button)(this.FindName("btnExport")));
        }
    }
}


﻿#pragma checksum "C:\Documents and Settings\eqa40593\Gama\RadiographyTracking\RadiographyTracking\Views\FilmTransactions.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "44453383CA4E92580FFDE99F038FA8C0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RadiographyTracking.Controls;
using RadiographyTracking.Views;
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
using Vagsons.Controls;


namespace RadiographyTracking.Views {
    
    
    public partial class FilmTransactions : RadiographyTracking.Views.BaseCRUDView {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Label headerLabel;
        
        internal System.Windows.Controls.DomainDataSource filmTransactionsDomainDataSource;
        
        internal RadiographyTracking.Controls.BusyIndicator busyIndicator;
        
        internal System.Windows.Controls.DatePicker fromDatePicker;
        
        internal System.Windows.Controls.DatePicker toDatePicker;
        
        internal Vagsons.Controls.CustomGrid filmTransactionsDataGrid;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/RadiographyTracking;component/Views/FilmTransactions.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.headerLabel = ((System.Windows.Controls.Label)(this.FindName("headerLabel")));
            this.filmTransactionsDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("filmTransactionsDomainDataSource")));
            this.busyIndicator = ((RadiographyTracking.Controls.BusyIndicator)(this.FindName("busyIndicator")));
            this.fromDatePicker = ((System.Windows.Controls.DatePicker)(this.FindName("fromDatePicker")));
            this.toDatePicker = ((System.Windows.Controls.DatePicker)(this.FindName("toDatePicker")));
            this.filmTransactionsDataGrid = ((Vagsons.Controls.CustomGrid)(this.FindName("filmTransactionsDataGrid")));
            this.btnSave = ((System.Windows.Controls.Button)(this.FindName("btnSave")));
            this.btnCancel = ((System.Windows.Controls.Button)(this.FindName("btnCancel")));
            this.btnAdd = ((System.Windows.Controls.Button)(this.FindName("btnAdd")));
        }
    }
}


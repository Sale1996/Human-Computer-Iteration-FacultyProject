﻿#pragma checksum "..\..\..\..\NewItems\ZaManifestaciju\AddTip.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DF2D0EE6C37A73E3462C539B78A778F005CF40F8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FestivaliAS.ViewModels;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace FestivaliAS.NewItems.ZaManifestaciju {
    
    
    /// <summary>
    /// AddTip
    /// </summary>
    public partial class AddTip : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\NewItems\ZaManifestaciju\AddTip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tipGrid;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\NewItems\ZaManifestaciju\AddTip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox FilterTipova;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\NewItems\ZaManifestaciju\AddTip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FindTip;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\NewItems\ZaManifestaciju\AddTip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PonistiTip;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\NewItems\ZaManifestaciju\AddTip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\NewItems\ZaManifestaciju\AddTip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNovi;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\NewItems\ZaManifestaciju\AddTip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Izadji;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FestivaliAS;component/newitems/zamanifestaciju/addtip.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\NewItems\ZaManifestaciju\AddTip.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\..\NewItems\ZaManifestaciju\AddTip.xaml"
            ((FestivaliAS.NewItems.ZaManifestaciju.AddTip)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.zatvaranje);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 15 "..\..\..\..\NewItems\ZaManifestaciju\AddTip.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Help_Executed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tipGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.FilterTipova = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 5:
            this.FindTip = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.PonistiTip = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.Add = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\..\NewItems\ZaManifestaciju\AddTip.xaml"
            this.Add.Click += new System.Windows.RoutedEventHandler(this.Ubaci_Dugme_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.AddNovi = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.Izadji = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\..\NewItems\ZaManifestaciju\AddTip.xaml"
            this.Izadji.Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


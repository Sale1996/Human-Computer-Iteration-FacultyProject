﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69AB19A37B4081C166F46108DBBCA8DF2B56339D"
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


namespace FestivaliAS {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 96 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image _DodajManifestaciju;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image _DodajTip;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image _DodajEtiketu;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image _ManifestacijaTabela;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image _TipTabela;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image _EtiketaTabela;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image _Save;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Map;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image NsMap;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu contextMenu;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listView;
        
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
            System.Uri resourceLocater = new System.Uri("/FestivaliAS;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 8 "..\..\MainWindow.xaml"
            ((FestivaliAS.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.zatvaranje);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 14 "..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Help_Executed);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 28 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.NewManifestacijaClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 33 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.NewTipClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 38 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.NewEtiketaClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 45 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Save);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 52 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Exit_Application);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 60 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.NewTableManifestacijaClick);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 66 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.NewTableTip);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 71 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.NewTableEtiketa);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 79 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Help_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 80 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.pritisnutDemoMod);
            
            #line default
            #line hidden
            return;
            case 13:
            this._DodajManifestaciju = ((System.Windows.Controls.Image)(target));
            
            #line 97 "..\..\MainWindow.xaml"
            this._DodajManifestaciju.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.NewManifestacijaClick);
            
            #line default
            #line hidden
            return;
            case 14:
            this._DodajTip = ((System.Windows.Controls.Image)(target));
            
            #line 99 "..\..\MainWindow.xaml"
            this._DodajTip.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.NewTipClick);
            
            #line default
            #line hidden
            return;
            case 15:
            this._DodajEtiketu = ((System.Windows.Controls.Image)(target));
            
            #line 101 "..\..\MainWindow.xaml"
            this._DodajEtiketu.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.NewEtiketaClick);
            
            #line default
            #line hidden
            return;
            case 16:
            this._ManifestacijaTabela = ((System.Windows.Controls.Image)(target));
            
            #line 104 "..\..\MainWindow.xaml"
            this._ManifestacijaTabela.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.NewTableManifestacijaClick);
            
            #line default
            #line hidden
            return;
            case 17:
            this._TipTabela = ((System.Windows.Controls.Image)(target));
            
            #line 106 "..\..\MainWindow.xaml"
            this._TipTabela.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.NewTableTip);
            
            #line default
            #line hidden
            return;
            case 18:
            this._EtiketaTabela = ((System.Windows.Controls.Image)(target));
            
            #line 108 "..\..\MainWindow.xaml"
            this._EtiketaTabela.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.NewTableEtiketa);
            
            #line default
            #line hidden
            return;
            case 19:
            this._Save = ((System.Windows.Controls.Image)(target));
            
            #line 112 "..\..\MainWindow.xaml"
            this._Save.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Save);
            
            #line default
            #line hidden
            return;
            case 20:
            this.Map = ((System.Windows.Controls.Canvas)(target));
            
            #line 123 "..\..\MainWindow.xaml"
            this.Map.AddHandler(System.Windows.Input.Mouse.PreviewMouseDownEvent, new System.Windows.Input.MouseButtonEventHandler(this.Map_PreviewMouseLeftButtonDown));
            
            #line default
            #line hidden
            
            #line 123 "..\..\MainWindow.xaml"
            this.Map.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Map_MouseRightButtonDown);
            
            #line default
            #line hidden
            
            #line 123 "..\..\MainWindow.xaml"
            this.Map.MouseMove += new System.Windows.Input.MouseEventHandler(this.Map_MouseMove);
            
            #line default
            #line hidden
            
            #line 123 "..\..\MainWindow.xaml"
            this.Map.DragEnter += new System.Windows.DragEventHandler(this.Map_DragEnter);
            
            #line default
            #line hidden
            
            #line 123 "..\..\MainWindow.xaml"
            this.Map.Drop += new System.Windows.DragEventHandler(this.Map_Drop);
            
            #line default
            #line hidden
            return;
            case 21:
            this.NsMap = ((System.Windows.Controls.Image)(target));
            return;
            case 22:
            this.contextMenu = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 23:
            
            #line 134 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateManifestation_Click);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 137 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveManifestationIcon_Click);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 140 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteManifestation_Click);
            
            #line default
            #line hidden
            return;
            case 26:
            this.listView = ((System.Windows.Controls.ListView)(target));
            
            #line 155 "..\..\MainWindow.xaml"
            this.listView.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ListView_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 155 "..\..\MainWindow.xaml"
            this.listView.MouseMove += new System.Windows.Input.MouseEventHandler(this.ListView_MouseMove);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


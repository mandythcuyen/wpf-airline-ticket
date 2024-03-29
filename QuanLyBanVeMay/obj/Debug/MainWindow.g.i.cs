﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4CCABCD2D1284F30AF4FE4F292D69B46173DE1B2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using QuanLyBanVeMay;
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


namespace QuanLyBanVeMay {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Minimize;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Fechar;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem Home;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem Ticket;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem Calender;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem Customer;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem AirCompany;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem RPMonth;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem RPYear;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem ChangeRules;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainScreen;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyBanVeMay;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            
            #line 21 "..\..\MainWindow.xaml"
            ((QuanLyBanVeMay.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.WindowLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 22 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Button_Minimize = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\MainWindow.xaml"
            this.Button_Minimize.Click += new System.Windows.RoutedEventHandler(this.Button_Minimize_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Button_Fechar = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\MainWindow.xaml"
            this.Button_Fechar.Click += new System.Windows.RoutedEventHandler(this.Button_Fechar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Home = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 89 "..\..\MainWindow.xaml"
            this.Home.Selected += new System.Windows.RoutedEventHandler(this.Home_Selected);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Ticket = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 90 "..\..\MainWindow.xaml"
            this.Ticket.Selected += new System.Windows.RoutedEventHandler(this.Ticket_Selected);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Calender = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 91 "..\..\MainWindow.xaml"
            this.Calender.Selected += new System.Windows.RoutedEventHandler(this.Calender_Selected);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Customer = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 93 "..\..\MainWindow.xaml"
            this.Customer.Selected += new System.Windows.RoutedEventHandler(this.Customer_Selected);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AirCompany = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 94 "..\..\MainWindow.xaml"
            this.AirCompany.Selected += new System.Windows.RoutedEventHandler(this.AirCompany_Selected);
            
            #line default
            #line hidden
            return;
            case 10:
            this.RPMonth = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 97 "..\..\MainWindow.xaml"
            this.RPMonth.Selected += new System.Windows.RoutedEventHandler(this.RPMonth_Selected);
            
            #line default
            #line hidden
            return;
            case 11:
            this.RPYear = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 98 "..\..\MainWindow.xaml"
            this.RPYear.Selected += new System.Windows.RoutedEventHandler(this.RPYear_Selected);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ChangeRules = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 100 "..\..\MainWindow.xaml"
            this.ChangeRules.Selected += new System.Windows.RoutedEventHandler(this.ChangeRules_Selected);
            
            #line default
            #line hidden
            return;
            case 13:
            this.MainScreen = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


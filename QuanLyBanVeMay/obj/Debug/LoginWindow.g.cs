﻿#pragma checksum "..\..\LoginWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83114D49676F9268D1D0312BE026ACF74EC0F5AD"
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
    /// LoginWindow
    /// </summary>
    public partial class LoginWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonMinimize;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonFechar;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxUserName;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox TextBoxPassword;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid_Notify_Failed;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBoxStaySignedIn;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonForgotPassword;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSignIn;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSignInWithFacebook;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSignInWithTwitter;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSignInWithGoogle;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyBanVeMay;component/loginwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LoginWindow.xaml"
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
            
            #line 23 "..\..\LoginWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonMinimize = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\LoginWindow.xaml"
            this.ButtonMinimize.Click += new System.Windows.RoutedEventHandler(this.ButtonMinimize_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonFechar = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\LoginWindow.xaml"
            this.ButtonFechar.Click += new System.Windows.RoutedEventHandler(this.ButtonFechar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TextBoxUserName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TextBoxPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.Grid_Notify_Failed = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.CheckBoxStaySignedIn = ((System.Windows.Controls.CheckBox)(target));
            
            #line 103 "..\..\LoginWindow.xaml"
            this.CheckBoxStaySignedIn.Checked += new System.Windows.RoutedEventHandler(this.CheckBoxStaySignedIn_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ButtonForgotPassword = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\LoginWindow.xaml"
            this.ButtonForgotPassword.Click += new System.Windows.RoutedEventHandler(this.ButtonForgotPassword_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ButtonSignIn = ((System.Windows.Controls.Button)(target));
            
            #line 115 "..\..\LoginWindow.xaml"
            this.ButtonSignIn.Click += new System.Windows.RoutedEventHandler(this.ButtonSignIn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ButtonSignInWithFacebook = ((System.Windows.Controls.Button)(target));
            
            #line 126 "..\..\LoginWindow.xaml"
            this.ButtonSignInWithFacebook.Click += new System.Windows.RoutedEventHandler(this.ButtonSignInWithFacebook_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ButtonSignInWithTwitter = ((System.Windows.Controls.Button)(target));
            
            #line 135 "..\..\LoginWindow.xaml"
            this.ButtonSignInWithTwitter.Click += new System.Windows.RoutedEventHandler(this.ButtonSignInWithTwitter_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ButtonSignInWithGoogle = ((System.Windows.Controls.Button)(target));
            
            #line 144 "..\..\LoginWindow.xaml"
            this.ButtonSignInWithGoogle.Click += new System.Windows.RoutedEventHandler(this.ButtonSignInWithGoogle_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\..\..\assets\screens\SubmitOrders.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9A9739EDD8388D1D9D4BC65B2F9FB53B01045191"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DiplomacyOrders.assets.screens;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace DiplomacyOrders.assets.screens {
    
    
    /// <summary>
    /// SubmitOrders
    /// </summary>
    public partial class SubmitOrders : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\assets\screens\SubmitOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OrdersTXT;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\assets\screens\SubmitOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SubmitBTN;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\assets\screens\SubmitOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CountryTXT;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\assets\screens\SubmitOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border EventDisplay;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DiplomacyOrders;V0.1.0;component/assets/screens/submitorders.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\assets\screens\SubmitOrders.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.OrdersTXT = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\..\..\assets\screens\SubmitOrders.xaml"
            this.OrdersTXT.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.OrdersTXT_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SubmitBTN = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\..\assets\screens\SubmitOrders.xaml"
            this.SubmitBTN.Click += new System.Windows.RoutedEventHandler(this.SubmitBTN_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CountryTXT = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.EventDisplay = ((System.Windows.Controls.Border)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


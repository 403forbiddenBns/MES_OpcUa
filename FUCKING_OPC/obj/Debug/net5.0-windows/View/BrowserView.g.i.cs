﻿#pragma checksum "..\..\..\..\View\BrowserView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3862110801CD0CE4FD81B817D8277AC33602AEDA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace MES_OpcUa.View {
    
    
    /// <summary>
    /// BrowserView
    /// </summary>
    public partial class BrowserView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 3 "..\..\..\..\View\BrowserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MES_OpcUa.View.BrowserView window;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\View\BrowserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel WindowPanel;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\View\BrowserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExit;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\View\BrowserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu MenuNavigation;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\View\BrowserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Footer;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\View\BrowserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border LeftPanel;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\View\BrowserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView BrowserTree;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\View\BrowserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border RightPanel;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\View\BrowserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox formatText;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MES_OpcUa;component/view/browserview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\BrowserView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.window = ((MES_OpcUa.View.BrowserView)(target));
            return;
            case 2:
            this.WindowPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 3:
            this.btnExit = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.MenuNavigation = ((System.Windows.Controls.Menu)(target));
            return;
            case 5:
            this.Footer = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.LeftPanel = ((System.Windows.Controls.Border)(target));
            return;
            case 7:
            this.BrowserTree = ((System.Windows.Controls.TreeView)(target));
            return;
            case 8:
            this.RightPanel = ((System.Windows.Controls.Border)(target));
            return;
            case 9:
            this.formatText = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


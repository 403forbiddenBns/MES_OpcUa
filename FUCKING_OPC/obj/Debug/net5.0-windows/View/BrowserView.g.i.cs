// Updated by XamlIntelliSenseFileGenerator 25.05.2022 9:32:35
#pragma checksum "..\..\..\..\View\BrowserView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36EF7948CB44023B5B5DEE8DFFED37648EE97570"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MES_OpcUa.ViewModel;
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


namespace MES_OpcUa.View
{


    /// <summary>
    /// BrowserView
    /// </summary>
    public partial class BrowserView : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 17 "..\..\..\..\View\BrowserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel WindowPanel;

#line default
#line hidden


#line 22 "..\..\..\..\View\BrowserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExit;

#line default
#line hidden


#line 31 "..\..\..\..\View\BrowserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu MenuNavigation;

#line default
#line hidden


#line 43 "..\..\..\..\View\BrowserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Footer;

#line default
#line hidden


#line 57 "..\..\..\..\View\BrowserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border LeftPanel;

#line default
#line hidden


#line 61 "..\..\..\..\View\BrowserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView MainElementTree;

#line default
#line hidden


#line 65 "..\..\..\..\View\BrowserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border RightPanel;

#line default
#line hidden


#line 75 "..\..\..\..\View\BrowserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox formatText;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
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
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
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
                    this.MainElementTree = ((System.Windows.Controls.TreeView)(target));
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

        internal System.Windows.Window window;
    }
}


﻿#pragma checksum "..\..\..\vragen\OpstellenWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F8596FA0D646241CE8CD58FFDB471B85"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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


namespace ProjectChallenge {
    
    
    /// <summary>
    /// OpstellenWindow
    /// </summary>
    public partial class OpstellenWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\vragen\OpstellenWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox opgaveTextBox;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\vragen\OpstellenWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label opgaveLabel;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\vragen\OpstellenWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label antwoordLabel;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\vragen\OpstellenWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox antwoordTextBox;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\vragen\OpstellenWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button volgendeButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\vragen\OpstellenWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button opslaanButton;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjectChallenge;component/vragen/opstellenwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\vragen\OpstellenWindow.xaml"
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
            this.opgaveTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.opgaveLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.antwoordLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.antwoordTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.volgendeButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\vragen\OpstellenWindow.xaml"
            this.volgendeButton.Click += new System.Windows.RoutedEventHandler(this.volgendeButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.opslaanButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\vragen\OpstellenWindow.xaml"
            this.opslaanButton.Click += new System.Windows.RoutedEventHandler(this.opslaanButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


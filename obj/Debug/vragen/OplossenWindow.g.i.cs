﻿#pragma checksum "..\..\..\vragen\OplossenWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "487E68C804EC510EA6E3DCAD546B2C35"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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
    /// OplossenWindow
    /// </summary>
    public partial class OplossenWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\vragen\OplossenWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock opgaveTextBlock;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\..\vragen\OplossenWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox invulTextBox;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\vragen\OplossenWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button volgendeButton;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\vragen\OplossenWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button klaarButton;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\vragen\OplossenWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button vorigeButton;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\vragen\OplossenWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox invulListBox;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjectChallenge;component/vragen/oplossenwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\vragen\OplossenWindow.xaml"
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
            this.opgaveTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.invulTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.volgendeButton = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\..\vragen\OplossenWindow.xaml"
            this.volgendeButton.Click += new System.Windows.RoutedEventHandler(this.volgendeButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.klaarButton = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\..\vragen\OplossenWindow.xaml"
            this.klaarButton.Click += new System.Windows.RoutedEventHandler(this.klaarButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.vorigeButton = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\vragen\OplossenWindow.xaml"
            this.vorigeButton.Click += new System.Windows.RoutedEventHandler(this.vorigeButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.invulListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


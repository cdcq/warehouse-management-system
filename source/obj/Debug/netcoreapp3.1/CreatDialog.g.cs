﻿#pragma checksum "..\..\..\CreatDialog.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B0360EC8F726B586578B869DF44503E742D2A8D2"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
using warehouse_management_system;


namespace warehouse_management_system {
    
    
    /// <summary>
    /// CreatDialog
    /// </summary>
    public partial class CreatDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\CreatDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\CreatDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox countBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\CreatDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox worthBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\CreatDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox propertyBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\CreatDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button okButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\CreatDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button canceButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/warehouse-management-system;component/creatdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CreatDialog.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.nameBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\CreatDialog.xaml"
            this.nameBox.GotFocus += new System.Windows.RoutedEventHandler(this.nameBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.countBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\CreatDialog.xaml"
            this.countBox.GotFocus += new System.Windows.RoutedEventHandler(this.countBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.worthBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\..\CreatDialog.xaml"
            this.worthBox.GotFocus += new System.Windows.RoutedEventHandler(this.worthBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.propertyBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\..\CreatDialog.xaml"
            this.propertyBox.GotFocus += new System.Windows.RoutedEventHandler(this.propertyBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.okButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\CreatDialog.xaml"
            this.okButton.Click += new System.Windows.RoutedEventHandler(this.okButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.canceButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


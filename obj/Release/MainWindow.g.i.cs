﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DE69E1C53875CCB1CA06A8BC06745B6E18BBAF3E3CD57D61FF85E734C098E95A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ElevenRestoreFolders;
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


namespace ElevenRestoreFolders {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ElevenRestoreFolders.MainWindow frmMain;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkObjectsTD;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkDesktop;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkDocuments;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkDownloads;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkPictures;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkMusic;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkVideos;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTodos;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNinguno;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAbout;
        
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
            System.Uri resourceLocater = new System.Uri("/ElevenRestoreFolders;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            this.frmMain = ((ElevenRestoreFolders.MainWindow)(target));
            
            #line 8 "..\..\MainWindow.xaml"
            this.frmMain.Loaded += new System.Windows.RoutedEventHandler(this.frmMain_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.chkObjectsTD = ((System.Windows.Controls.CheckBox)(target));
            
            #line 123 "..\..\MainWindow.xaml"
            this.chkObjectsTD.Checked += new System.Windows.RoutedEventHandler(this.CheckBoxChanged);
            
            #line default
            #line hidden
            
            #line 123 "..\..\MainWindow.xaml"
            this.chkObjectsTD.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBoxChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.chkDesktop = ((System.Windows.Controls.CheckBox)(target));
            
            #line 130 "..\..\MainWindow.xaml"
            this.chkDesktop.Checked += new System.Windows.RoutedEventHandler(this.CheckBoxChanged);
            
            #line default
            #line hidden
            
            #line 130 "..\..\MainWindow.xaml"
            this.chkDesktop.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBoxChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.chkDocuments = ((System.Windows.Controls.CheckBox)(target));
            
            #line 137 "..\..\MainWindow.xaml"
            this.chkDocuments.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBoxChanged);
            
            #line default
            #line hidden
            
            #line 137 "..\..\MainWindow.xaml"
            this.chkDocuments.Checked += new System.Windows.RoutedEventHandler(this.CheckBoxChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.chkDownloads = ((System.Windows.Controls.CheckBox)(target));
            
            #line 144 "..\..\MainWindow.xaml"
            this.chkDownloads.Checked += new System.Windows.RoutedEventHandler(this.CheckBoxChanged);
            
            #line default
            #line hidden
            
            #line 144 "..\..\MainWindow.xaml"
            this.chkDownloads.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBoxChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.chkPictures = ((System.Windows.Controls.CheckBox)(target));
            
            #line 151 "..\..\MainWindow.xaml"
            this.chkPictures.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBoxChanged);
            
            #line default
            #line hidden
            
            #line 151 "..\..\MainWindow.xaml"
            this.chkPictures.Checked += new System.Windows.RoutedEventHandler(this.CheckBoxChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.chkMusic = ((System.Windows.Controls.CheckBox)(target));
            
            #line 158 "..\..\MainWindow.xaml"
            this.chkMusic.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBoxChanged);
            
            #line default
            #line hidden
            
            #line 158 "..\..\MainWindow.xaml"
            this.chkMusic.Checked += new System.Windows.RoutedEventHandler(this.CheckBoxChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.chkVideos = ((System.Windows.Controls.CheckBox)(target));
            
            #line 165 "..\..\MainWindow.xaml"
            this.chkVideos.Checked += new System.Windows.RoutedEventHandler(this.CheckBoxChanged);
            
            #line default
            #line hidden
            
            #line 165 "..\..\MainWindow.xaml"
            this.chkVideos.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBoxChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnTodos = ((System.Windows.Controls.Button)(target));
            
            #line 173 "..\..\MainWindow.xaml"
            this.btnTodos.Click += new System.Windows.RoutedEventHandler(this.buttonMarkUnmark_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnNinguno = ((System.Windows.Controls.Button)(target));
            
            #line 179 "..\..\MainWindow.xaml"
            this.btnNinguno.Click += new System.Windows.RoutedEventHandler(this.buttonMarkUnmark_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnAbout = ((System.Windows.Controls.Button)(target));
            
            #line 187 "..\..\MainWindow.xaml"
            this.btnAbout.Click += new System.Windows.RoutedEventHandler(this.btnAbout_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


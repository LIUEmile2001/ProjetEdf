﻿#pragma checksum "..\..\FNTGestionEdf.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "22C53D8EFACE732B8A0C81AC6DC84A425EB89487631B22C43A83238B72E9B2F5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using WPFEdf;


namespace WPFEdf {
    
    
    /// <summary>
    /// FNTGestionEdf
    /// </summary>
    public partial class FNTGestionEdf : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\FNTGestionEdf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstControleurs;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\FNTGestionEdf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstClients;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\FNTGestionEdf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNomControleur;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\FNTGestionEdf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrenomControleur;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\FNTGestionEdf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button insContro;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\FNTGestionEdf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNomClient;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\FNTGestionEdf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrenomClient;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\FNTGestionEdf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button insClient;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFEdf;component/fntgestionedf.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FNTGestionEdf.xaml"
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
            
            #line 8 "..\..\FNTGestionEdf.xaml"
            ((WPFEdf.FNTGestionEdf)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lstControleurs = ((System.Windows.Controls.ListBox)(target));
            
            #line 29 "..\..\FNTGestionEdf.xaml"
            this.lstControleurs.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lstControleurs_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lstClients = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.txtNomControleur = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtPrenomControleur = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.insContro = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\FNTGestionEdf.xaml"
            this.insContro.Click += new System.Windows.RoutedEventHandler(this.insContro_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtNomClient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtPrenomClient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.insClient = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\FNTGestionEdf.xaml"
            this.insClient.Click += new System.Windows.RoutedEventHandler(this.insClient_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

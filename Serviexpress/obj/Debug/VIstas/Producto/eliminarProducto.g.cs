﻿#pragma checksum "..\..\..\..\Vistas\Producto\eliminarProducto.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3040892FACA9FD0873EDEDF2200B5C96452F899F56CB0975249E395A3A221606"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro;
using MahApps.Metro.Accessibility;
using MahApps.Metro.Actions;
using MahApps.Metro.Automation.Peers;
using MahApps.Metro.Behaviors;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Converters;
using MahApps.Metro.Markup;
using MahApps.Metro.Theming;
using MahApps.Metro.ValueBoxes;
using Serviexpress.Vistas.Producto;
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


namespace Serviexpress.Vistas.Producto {
    
    
    /// <summary>
    /// eliminarProducto
    /// </summary>
    public partial class eliminarProducto : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\Vistas\Producto\eliminarProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblEliminarProducto;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Vistas\Producto\eliminarProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTextoEliminar;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Vistas\Producto\eliminarProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblEliminarID;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Vistas\Producto\eliminarProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbEliminarIDProducto;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Vistas\Producto\eliminarProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminar;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Vistas\Producto\eliminarProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalir;
        
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
            System.Uri resourceLocater = new System.Uri("/Serviexpress;component/vistas/producto/eliminarproducto.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Vistas\Producto\eliminarProducto.xaml"
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
            this.lblEliminarProducto = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.lblTextoEliminar = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblEliminarID = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.cmbEliminarIDProducto = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.btnEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\Vistas\Producto\eliminarProducto.xaml"
            this.btnEliminar.Click += new System.Windows.RoutedEventHandler(this.btnEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnSalir = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\Vistas\Producto\eliminarProducto.xaml"
            this.btnSalir.Click += new System.Windows.RoutedEventHandler(this.btnSalir_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


   M S B A M L   `   `   `  ����G  CServiexpress, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:Serviexpress.Vistas.RecepcionProducto%Serviexpress.Vistas.RecepcionProducto  5   	   D    >Serviexpress.Vistas.RecepcionProducto.agregarRecepcionProducto   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   ?local3clr-namespace:Serviexpress.Vistas.RecepcionProducto  5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ agregarRecepcionProducto��5
   	   $��422.812��6*   $��535.625��6;   .��5      � .+�5   
   �� -   5         ��Name$! lblAgregarRecepcionProducto��5      $(��"Agregar de Recepción de Productos��65   $
��Left=�6a   $��	33,31,0,0q�6|   $	��Top=�6�   $	��493��6�   $��55��6�   $��30(�6�   $��Italic$�6�   $��SemiBold"�6�   �� 5   
   -   5        $ lblFecha��5      $��Fecha��6"   $
��Left=�62   $��102,131,0,0q�6M   $	��Top=�6b   $��99��6z   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpFecha��5      $
��Left=�6&   $��256,131,0,0q�6A   $	��Top=�6V   $��26��6n   $	��127��6z   �� 5   
   -   5         ��Name$ txtAgregarValidador��5      $
��Left=�6/   $��23��6J   $��256,176,0,0q�6V    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��127��6�   �� 5   
   -   5        $ txtAgregarDescripcion��5      $
��Left=�61   $��26��6L   $��256,218,0,0q�6X   $
 Wrap=�6m   $	��Top=�6�   $	��127��6�   �� 5   
   -   5        $ lblValidador��5      $��	Validador��6&   $
��Left=�6:   $��102,176,0,0q�6U   $	��Top=�6j   $��99��6�   $��23��6�   �� 5   
   -   5        $ lblDescripcion��5      $��Descripción��6(   $
��Left=�6>   $��102,218,0,0q�6Y   $	��Top=�6n   $��99��6�   $��26��6�   �� 5   
   -   5        $ lblIDOrdenCompra��5      $��ID Orden de Compra��6*   $
��Left=�6G   $��102,260,0,0q�6b   $	��Top=�6w   $	��124��6�   $��26��6�   �� 5   
   -	   5         ��Name$" btnAgregarRecepcionProductos��5      $��Agregar��67   $
��Left=�6I   $��374,316,0,0q�6d   $	��Top=�6y   $��75��6�   $��30��6�   6�   �� 5   
   -
   5        $ btnSalir��5      $��Salir��6#   $
��Left=�63   $��273,316,0,0q�6N   $	��Top=�6c   $��75��6{   $��30��6�   6�   �� 5   
   -   5         ��Name$ cmbIDOrdenCompra��5      $
��Left=�6-   $��256,260,0,0q�6H   $	��Top=�6]   $	��127��6u   $��26��6�   5      5      
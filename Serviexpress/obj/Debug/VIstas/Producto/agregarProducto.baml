   M S B A M L   `   `   `  ����G  CServiexpress, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Serviexpress.Vistas.ProductoServiexpress.Vistas.Producto  5   	   2    ,Serviexpress.Vistas.Producto.agregarProducto   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   6local*clr-namespace:Serviexpress.Vistas.Producto  5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ agregarProducto��5
   	   $��417.136��6!   $��420.538��62   .��5      � .+�5   
   �� -   5         ��Name$ lblAgregaProducto��5      $��Agregar un Producto��6+   $
��Left=�6I   $��	40,24,0,0q�6d   $	��Top=�6w   $	��355��6�   $��63��6�   $��36(�6�   $��Italic$�6�   $��SemiBold"�6�   �� 5   
   -   5        $ lblStock��5      $��Stock��6"   $
��Left=�62   $��
40,143,0,0q�6M   $	��Top=�6a   $	��111��6y   �� 5   
   -   5         ��Name$ txtProductoStock��5      $
��Left=�6,   $��23��6G   $��156,146,0,0q�6S    �� TextWrapping$
 Wrap=�6h   $	��Top=�6|   $	��120��6�   �� 5   
   -   5        $! lblFechaVencimientoProducto��5      $��Fecha Vencimiento��65   $
��Left=�6Q   $��
40,174,0,0q�6l   $	��Top=�6�   $	��111��6�   �� 5   
   -   5        $ lblProductoDescripcion��5      $��Descripción��60   $
��Left=�6F   $��
40,202,0,0q�6a   $	��Top=�6u   $	��111��6�   �� 5   
   -   5        $ txtProductoDescripcion��5      $
��Left=�62   $��23��6M   $��156,202,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ lblProductoTipo��5      $��Tipo Producto��6)   $
��Left=�6A   $��
40,231,0,0q�6\   $	��Top=�6p   $	��111��6�   �� 5   
   -   5        $ txtTipoProducto��5      $
��Left=�6+   $��23��6F   $��156,230,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   -	   5         ��Name$ btnAgregarProducto��5      $��Agregar��6-   $
��Left=�6?   $��259,287,0,0q�6Z   $	��Top=�6o   $��75��6�   $��30��6�   ��6�   2  ,MahApps.Metro.Markup.StaticResourceExtension  **(MahApps.Styles.Button.MetroSquare.Accent+6�   �� 5   
   -
   5        $ btnSalir��5      $��Salir��6#   $
��Left=�63   $��170,287,0,0q�6N   $	��Top=�6c   $��75��6{   $��30��6�   ��6�     **(MahApps.Styles.Button.MetroSquare.Accent+6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpFechaVencimiento��5      $
��Left=�61   $��156,174,0,0q�6L   $	��Top=�6a   $	��120��6y   5      5      
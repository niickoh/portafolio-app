   M S B A M L   `   `   `  ����G  CServiexpress, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Serviexpress.Vistas.ProductoServiexpress.Vistas.Producto  5   	   .    (Serviexpress.Vistas.Producto.AdmProducto   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   6local*clr-namespace:Serviexpress.Vistas.Producto  5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ AdmProducto��5
   	   $	��436��6   $	��665��6*   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgAdmProductos��5      $
��Left=�6+   $	��237��6F   $��
79,158,0,0q�6S   $	��Top=�6g   $	��460��6   �� 5   
   -   5         ��Name$ lblAdmProducto��5      $"��Administración de Productos��6(   $
��Left=�6N   $��	79,34,0,0q�6i   $	��Top=�6|   $	��473��6�   $��55��6�   $��36(�6�   $��Italic$�6�   $��SemiBold"�6�   �� 5   
   -   5         ��Name$ txtBuscarProducto��5      $
��Left=�6-   $��30��6H   $��
79,123,0,0q�6T    �� TextWrapping$
 Wrap=�6h   $	��Top=�6|   $	��460��6�   �� 5   
   -   5         ��Name$ btnBuscarProducto��5      $��Buscar��6,   $
��Left=�6=   $��571,123,0,0q�6X   $	��Top=�6m   $��75��6�   $��30��6�   ��6�   2  ,MahApps.Metro.Markup.StaticResourceExtension  **(MahApps.Styles.Button.MetroSquare.Accent+6�   !  MahApps.Metro.Controls.Tile  5   
   -   5        $
��Left=�5      $��	10,10,0,0q�6.   $	��Top=�6A   $��30��6Y   $��30��6e   
�������
�������.��5      �� $��25��6   $��25��6    $0��*/Serviexpress;component/Imagenes/atras.png��6+   5      �� 5   
   -   5        $ btnAgregarProducto��5      $��Agregar��6-   $
��Left=�6?   $��572,158,0,0q�6Z   $	��Top=�6o   $��75��6�   $��30��6�   ��6�     **(MahApps.Styles.Button.MetroSquare.Accent+6�   �� 5   
   -   5        $ btnEditarProducto��5      $��Editar��6,   $
��Left=�6=   $��572,193,0,0q�6X   $	��Top=�6m   $��75��6�   $��30��6�   ��6�     **(MahApps.Styles.Button.MetroSquare.Accent+6�   �� 5   
   -   5        $ btnEliminarProducto��5      $��Eliminar��6.   $
��Left=�6A   $��571,228,0,0q�6\   $	��Top=�6q   $��75��6�   $��30��6�   ��6�     **(MahApps.Styles.Button.MetroSquare.Accent+6�   5      5      
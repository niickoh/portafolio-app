   M S B A M L   `   `   `  ����G  CServiexpress, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Serviexpress.Vistas.ProductoServiexpress.Vistas.Producto  5   	   4    .Serviexpress.Vistas.Producto.modificarProducto   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   6local*clr-namespace:Serviexpress.Vistas.Producto  5   	     � Title$  modificarProducto��5	   	   $��389.691��6#   $��442.783��64   .��5
      � .+�5   
   �� -   5         ��Name$ EDITAR_producto_��5      $
��Left=�6.   $��
124,25,0,0q�6I   $
��Wrap=�6]   $��EDITAR PRODUCTO ��6q   $	��Top=�6�   $��20(�6�   $
��Bold"�6�    J� RenderTransformOrigin$ 0.462,0.643&�6�   � 5   
   $��
10,49,0,10q�6   .+�5      �� -   5         ��Name$ txtEditTipoProducto��5      $
��Left=�63   $��23��6N   $��195,181,0,0q�6Z    �� TextWrapping$
 Wrap=�6o   $	��Top=�6�   $	��120��6�   �� 5      -   5        $ txtEditDescripcion��5      $
��Left=�62   $��23��6M   $��195,117,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��120��6�   �� 5      -   5        $ txtEditStock��5      $
��Left=�6,   $��23��6G   $��
195,90,0,0q�6S   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5      -   5         ��Name$ btnConfirmar��5      $��
CONFIRMAR ��6+   $
��Left=�6@   $��257,233,0,0q�6[   $	��Top=�6p   $	��127��6�   $��Century Gothic)�6�   $��16(�6�   $
��Bold"�6�   $��40��6�   ��6�   2  ,MahApps.Metro.Markup.StaticResourceExtension  **(MahApps.Styles.Button.MetroSquare.Accent+(  "System.Windows.Controls.DatePicker  5      -   5          Name$ dpEditFechaVencimiento��5      $
��Left=�69   $��195,149,0,0q�6T   $	��Top=�6i   $	��120��6�   �� 5      -   5         ��Name$ lblTipoProducto��5      $��TIPO PRODUCTO��6-   $
��Left=�6E   $��
15,177,0,0q�6`   $	��Top=�6t   $��Century Gothic)�6�   $��14(�6�   $
��Bold"�6�   $	��175��6�   $��Right=�6�   �� 5      -   5        $ lblStock��5      $��STOCK��6&   $
��Left=�66   $��	15,90,0,0q�6Q   $	��Top=�6d   $��Century Gothic)�6|   $��14(�6�   $
��Bold"�6�   $	��175��6�   $��Right=�6�   �� 5      -	   5        $ lblDescripcion��5      $��DESCRIPCIÓN��6,   $
��Left=�6B   $��
15,117,0,0q�6]   $	��Top=�6q   $��Century Gothic)�6�   $��14(�6�   $
��Bold"�6�   $��Right=�6�   $	��175��6�   �� 5      -
   5        $ lblFechaVencimiento��5      $��FECHA DE VENCIMIENTO��61   $
��Left=�6P   $��
15,149,0,0q�6k   $	��Top=�6   $��Century Gothic)�6�   $��14(�6�   $
��Bold"�6�   $ 
0.49,0.987&�6�   $��Right=�6�   �� 5      -   5        $ 	lblEditID��5      $��ID��6'   $
��Left=�64   $��	15,58,0,0q�6O   $	��Top=�6b   $��Century Gothic)�6z   $��14(�6�   $
��Bold"�6�   $	��175��6�   $��Right=�6�   �� 5      -   5        $ 	txtEditID��5      $
��Left=�6)   $��23��6D   $��
195,58,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5      -   5        $ btnSalir��5      $��SALIR��6'   $
��Left=�67   $��141,233,0,0q�6R   $	��Top=�6g   $	��111��6   $��Century Gothic)�6�   $��16(�6�   $
��Bold"�6�   $��40��6�   ��6�     **(MahApps.Styles.Button.MetroSquare.Accent+5      5      5      
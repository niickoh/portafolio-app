   M S B A M L   `   `   `  ����G  CServiexpress, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Serviexpress.Vistas.Administrador!Serviexpress.Vistas.Administrador  5   	   6    0Serviexpress.Vistas.Administrador.Administracion   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   ;local/clr-namespace:Serviexpress.Vistas.Administrador  5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ Administracion��5
   	   $��448.975��6    $	��637��61   .��5      � .+�5   
   !  MahApps.Metro.Controls.Tile  -   5          Name$ 
tlUsuarios��5      $�� ��6'   $
��Left=�62   $��	77,80,0,0q�6M   $	��Top=�6`   $��75��6x   $��75��6�   ���	#FFF56B39   Title$ Usuarios��6�      TitleFontSize$ 14Q�6�      HorizontalTitleAlignment$ Center=�6�      VerticalTitleAlignment$ Center=�6�   $��Italic$�6  6    5   
   -   5        $ tlTipoUsuarios��5      $�� ��6+   $
��Left=�66   $��
77,160,0,0q�6Q   $	��Top=�6e   $��75��6}   $��75��6�   ���	#FFF56B39$ Tipo Usuarios��6�   $ 14Q�6�   $ Center=�6�   $ Center=�6�   $��Italic$�6  6)    5   
   -   5        $ 
tlProducto��5      $�� ��6'   $
��Left=�62   $��
77,240,0,0q�6M   $	��Top=�6a   $��75��6y   $��75��6�   ���	#FFF56B39$ 	Productos��6�   $ 13Q�6�   $ Center=�6�   $ Center=�6�   $��Italic$�6  6!    5   
   -   5        $ lblOrdenCompra��5      $�� ��6+   $
��Left=�66   $��
157,80,0,0q�6Q   $	��Top=�6e   $��75��6}   $��75��6�   ���	#FFF56B39$ Orden de Compra��6�   $ 14Q�6�   $ Center=�6�   $ Center=�6�   $��Italic$�65    5   
   -   5        $ tlRecepcion��5      $�� ��6(   $
��Left=�63   $��157,160,0,0q�6N   $	��Top=�6c   $��75��6{   $��75��6�   ���	#FFF56B39$ Recepcion de Productos��6�   $ Center=�6�   $��Italic$�6�   $ 14Q�6    5   
   -   5        $ tlTipoProducto��5      $�� ��6+   $
��Left=�66   $��157,240,0,0q�6Q   $	��Top=�6f   $��75��6~   $��75��6�   ���	#FFF56B39$ Tipo de Productos��6�   $ 13Q�6�   $��Italic$�6�   $ Center=�6	  $ Center=�6+    5   
   -   5        $ 
tlClientes��5      $�� ��6'   $
��Left=�62   $��
237,80,0,0q�6M   $	��Top=�6a   $��75��6y   $��75��6�   ���	#FFF56B39$ Clientes��6�   $ Center=�6�   $ Center=�6�   $��Italic$�6�     5   
   -   5        $ tlTipoServicio��5      $�� ��6+   $
��Left=�66   $��237,160,0,0q�6Q   $	��Top=�6f   $��75��6~   $��75��6�   ���	#FFF56B39$ Tipo de Servicio��6�   $ 14Q�6�   $��Italic$�6�   $ Center=�6  $ Center=�6(    5   
   -	   5        $ tlServicios��5      $�� ��6(   $
��Left=�63   $��237,240,0,0q�6N   $	��Top=�6c   $��75��6{   $��75��6�   ���	#FFF56B39$ 	Servicios��6�   $ 14Q�6�   $ Center=�6�   $ Center=�6
  $��Italic$�6*    5   
   -
   5        $ tlProveedor��5      $�� ��6(   $
��Left=�63   $��
317,80,0,0q�6N   $	��Top=�6b   $��75��6z   $��75��6�   ���	#FFF56B39$ 	Proveedor��6�   $ 13Q�6�   $ Center=�6�   $ Center=�6�   $��Italic$�6  6"    5   
   -   5        $ tlBoleta��5      $�� ��6%   $
��Left=�60   $��317,160,0,0q�6K   $	��Top=�6`   $��75��6x   $��75��6�   ���	#FFF56B39$ Boleta��6�   $ Center=�6�   $ Center=�6�   $ 14Q�6�   $��Italic$�6
    5   
   -   5        $ 	tlFactura��5      $�� ��6&   $
��Left=�61   $��317,240,0,0q�6L   $	��Top=�6a   $��75��6y   $��75��6�   ���	#FFF56B39$ Factura��6�   $ Center=�6�   $ Center=�6�   $ 18Q�6�   $��Italic$�6    5   
   -   5        $ 	tlReserva��5      $�� ��6&   $
��Left=�61   $��
397,80,0,0q�6L   $	��Top=�6`   $��75��6x   $��75��6�   ���	#FFF56B39$ Reserva��6�   $ Center=�6�   $ Center=�6�   $ 14Q�6  $��Italic$�6#    5   
   -   5        $ 
tlMecanico��5      $�� ��6'   $
��Left=�62   $��397,160,0,0q�6M   $	��Top=�6b   $��75��6z   $��75��6�   ���	#FFF56B39$ 	Mecánico��6�   $ Center=�6�   $ Center=�6�   $ 14Q�6�   $��Italic$�6    5   
   -   5        $ tlTipoRubro��5      $�� ��6(   $
��Left=�63   $��397,240,0,0q�6N   $	��Top=�6c   $��75��6{   $��75��6�   ���	#FFF56B39$ 
Tipo Rubro��6�   $��Italic$�6�   $ 14Q�6�   $ Center=�6�   $ Center=�6    5   
   -   5        $ tlDetallePedidoPro��5      $�� ��6/   $
��Left=�6:   $��
477,80,0,0q�6U   $	��Top=�6i   $��75��6�   $��75��6�   ���	#FFF56B39$ Detalle Pedido Producto��6�   $ Center=�6�   $ Center=�6�   $ 14Q�62  $��Italic$�6E    5   
   -   5        $ tlDetalleProductoServicio��5      $�� ��66   $��477,160,0,0q�6A   $	��Top=�6V   $��75��6n   $
��Left=�6z   $��75��6�   ���	#FFF56B39$ Center=�6�   $ Center=�6�   $ Detalle Producto Servicio��6�   $ 14Q�6  6.  �� 5   
   $��Administracion��6   $
��Left=�6)   $��	77,10,0,0q�6D   $	��Top=�6W   $	��485��6o   $��55��6{   $��Center=�6�   $��36(�6�     5   
   -   5        $
��Left=�5      $��	26,23,0,0q�6.   $	��Top=�6A   $��30��6Y   $��30��6e   
�������
�������.��5       �� $��25��6   $��25��6    $0��*/Serviexpress;component/Imagenes/atras.png��6+   5!      5#      5$      
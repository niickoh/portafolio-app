   M S B A M L   `   `   `  ����G  CServiexpress, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Serviexpress.Vistas.OrdenDeCompra!Serviexpress.Vistas.OrdenDeCompra  5   	   >    8Serviexpress.Vistas.OrdenDeCompra.modificarOrdenDeCompra   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   ;local/clr-namespace:Serviexpress.Vistas.OrdenDeCompra  5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ modificarOrdenDeCompra��5
   	   $	��487��6(   $	��456��65   .��5      � .+�5   
   �� -   5         ��Name$ lblEditarOrdenCompra��5      $��Editar Ordenes de Compra��6.   $
��Left=�6Q   $��	59,34,0,0q�6l   $	��Top=�6   $	��378��6�   $��55��6�   $��30(�6�   $��Italic$�6�   $��SemiBold"�6�   �� 5   
   -   5        $ lblEditarIDUsuario��5      $��
ID Usuario��6,   $
��Left=�6A   $��
86,156,0,0q�6\   $	��Top=�6p   $	��100��6�   $��Right=�6�   �� 5   
   -   5        $ lblEditarIDProveedor��5      $��ID Proveedor��6.   $
��Left=�6E   $��
86,196,0,0q�6`   $	��Top=�6t   $	��100��6�   $��Right=�6�   �� 5   
   -   5        $ lblEditarFechaSolicitud��5      $��Fecha Solicitud��61   $
��Left=�6K   $��
86,236,0,0q�6f   $	��Top=�6z   $	��100��6�   $��Right=�6�   �� 5   
   -   5        $ lblEditarDescripcion��5      $��Descripción��6.   $
��Left=�6D   $��
86,276,0,0q�6_   $	��Top=�6s   $	��100��6�   $��Right=�6�   �� 5   
   -   5         ��Name$ cmbEditarIDUsuario��5      $
��Left=�6/   $��225,156,0,0q�6J   $	��Top=�6_   $	��127��6w   $��26��6�   �� 5   
   -   5        $ cmbEditarIDProveedor��5      $
��Left=�61   $��225,196,0,0q�6L   $	��Top=�6a   $	��127��6y   $��26��6�   �� 5   
   -   5         ��Name$ txtEditarDescripcion��5      $
��Left=�60   $��26��6K   $��225,276,0,0q�6W    �� TextWrapping$
 Wrap=�6l   $	��Top=�6�   $	��127��6�   (  "System.Windows.Controls.DatePicker  5   
   -	   5          Name$ dpEditarFechaSolicitud��5      $
��Left=�65   $��225,236,0,0q�6P   $	��Top=�6e   $��26��6}   $	��127��6�   �� 5   
   -
   5        $ lblEditarTotal��5      $��Total��6(   $
��Left=�68   $��
86,317,0,0q�6S   $	��Top=�6g   $	��100��6   $��Right=�6�   �� 5   
   -   5        $ txtEditarTotal��5      $
��Left=�6*   $��26��6E   $��225,317,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��127��6�   �� 5   
   -   5         ��Name$ btnEditarOrdenCompra��5      $��Editar��6/   $
��Left=�6@   $��318,370,0,0q�6[   $	��Top=�6p   $��75��6�   $��31��6�   6�   �� 5   
   -   5        $ btnSalir��5      $��Salir��6#   $
��Left=�63   $��225,370,0,0q�6N   $	��Top=�6c   $��75��6{   $��31��6�   6�   �� 5   
   -   5        $ lblIDOrdenCompra��5      $��ID Orden de Compra��6*   $
��Left=�6G   $��
59,116,0,0q�6b   $	��Top=�6v   $	��127��6�   $��Right=�6�   �� 5   
   -   5        $ txtEditarIDOrdenCompra��5      $
��Left=�62   $��26��6M   $��225,116,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��127��6�   5      5      
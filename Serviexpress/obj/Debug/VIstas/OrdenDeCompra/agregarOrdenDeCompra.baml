   M S B A M L   `   `   `  ����G  CServiexpress, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Serviexpress.Vistas.OrdenDeCompra!Serviexpress.Vistas.OrdenDeCompra  5   	   <    6Serviexpress.Vistas.OrdenDeCompra.agregarOrdenDeCompra   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   ;local/clr-namespace:Serviexpress.Vistas.OrdenDeCompra  5   	     � Title$  agregarOrdenDeCompra��5	   	   $	��450��6&   $	��478��63   .��5
      � .+�5   
   �� -   5         ��Name$ lblAgregarOrdenDeCompra��5      $��Agregar Ordenes de Compra��61   $
��Left=�6U   $��	59,34,0,0q�6p   $	��Top=�6�   $	��399��6�   $��55��6�   $��30(�6�   $��Italic$�6�   $��SemiBold"�6�   �� 5   
   -   5        $ lblIDUsuario��5      $��
ID Usuario��6&   $
��Left=�6;   $��
70,131,0,0q�6V   $	��Top=�6j   $	��100��6�   $��Right=�6�   �� 5   
   -   5        $ lblIDProveedor��5      $��ID Proveedor��6(   $
��Left=�6?   $��
70,171,0,0q�6Z   $	��Top=�6n   $	��100��6�   $��Right=�6�   �� 5   
   -   5        $ lblFechaSolicitud��5      $��Fecha Solicitud��6+   $
��Left=�6E   $��
70,211,0,0q�6`   $	��Top=�6t   $	��100��6�   $��Right=�6�   �� 5   
   -   5        $ lblDescripcion��5      $��Descripción��6(   $
��Left=�6>   $��
70,251,0,0q�6Y   $	��Top=�6m   $	��100��6�   $��Right=�6�   �� 5   
   -   5         ��Name$ cmbIDUsuario��5      $
��Left=�6)   $��209,131,0,0q�6D   $	��Top=�6Y   $	��127��6q   $��26��6}   �� 5   
   -   5        $ cmbIDProveedor��5      $
��Left=�6+   $��209,171,0,0q�6F   $	��Top=�6[   $	��127��6s   $��26��6   �� 5   
   -   5         ��Name$ txtDescripcion��5      $
��Left=�6*   $��26��6E   $��209,251,0,0q�6Q    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��127��6�   (  "System.Windows.Controls.DatePicker  5   
   -	   5          Name$ dpFechaSolicitud��5      $
��Left=�6/   $��209,211,0,0q�6J   $	��Top=�6_   $��26��6w   $	��127��6�   �� 5   
   -
   5        $ lblTotal��5      $��Total��6"   $
��Left=�62   $��
70,292,0,0q�6M   $	��Top=�6a   $	��100��6y   $��Right=�6�   �� 5   
   -   5        $ txtTotal��5      $
��Left=�6$   $��26��6?   $��209,292,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��127��6�   �� 5   
   -   5         ��Name$ btnAgregarOrdenCompra��5      $��Agregar��60   $
��Left=�6B   $��321,340,0,0q�6]   $	��Top=�6r   $��75��6�   $��31��6�   6�   �� 5   
   -   5        $ btnSalir��5      $��Salir��6#   $
��Left=�63   $��228,340,0,0q�6N   $	��Top=�6c   $��75��6{   $��31��6�   6�   5      5      
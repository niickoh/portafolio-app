   M S B A M L   `   `   `  ����G  CServiexpress, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Serviexpress.Vistas.ServiciosServiexpress.Vistas.Servicios  5   	   4    .Serviexpress.Vistas.Servicios.agregarServicios   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   7local+clr-namespace:Serviexpress.Vistas.Servicios  5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ agregarServicios��5
   	   $��416.458��6"   $��356.979��63   .��5      � .+�5   
   �� -   5         ��Name$ lblAgregarServicios��5      $��Agregar Servicios��6-   $
��Left=�6I   $��	54,36,0,0q�6d   $	��Top=�6w   $	��250��6�   $��30(�6�   $��Italic$�6�   $��SemiBold"�6�   �� 5   
   -   5        $ lblFechaServicios��5      $��Fecha ��6+   $
��Left=�6<   $��
54,124,0,0q�6W   $	��Top=�6k   $	��101��6�   �� 5   
   -   5        $ lblIDReservaHora��5      $��
ID Reserva��6*   $
��Left=�6?   $��
54,214,0,0q�6Z   $	��Top=�6n   $	��101��6�   �� 5   
   -   5        $ lblValidado��5      $��	Validado?��6%   $
��Left=�69   $��
54,170,0,0q�6T   $	��Top=�6h   $	��101��6�   �� 5   
   -   5        $ lblComentario��5      $��
Comentario��6'   $
��Left=�6<   $��
54,258,0,0q�6W   $	��Top=�6k   $	��101��6�   �� 5   
   -   5         ��Name$ txtIDReserva��5      $
��Left=�6(   $��26��6C   $��160,214,0,0q�6O    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   -   5        $ txtComentario��5      $
��Left=�6)   $��26��6D   $��160,258,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   -   5         ��Name$ btnAgregarServicios��5      $��Agregar��6.   $
��Left=�6@   $��229,304,0,0q�6[   $	��Top=�6p   $��75��6�   $��28��6�   6�   �� 5   
   -	   5        $ btnSalir��5      $��Salir��6#   $
��Left=�63   $��132,304,0,0q�6N   $	��Top=�6c   $��74��6{   $��28��6�   6�   (  "System.Windows.Controls.DatePicker  5   
   -
   5          Name$ dpFecha��5      $
��Left=�6&   $��155,124,0,0q�6A   $	��Top=�6V   $��26��6n   $	��125��6z   �� 5   
   -   5        $ txtValidado��5      $
��Left=�6'   $��26��6B   $��160,170,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   5      5      
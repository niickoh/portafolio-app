   M S B A M L   `   `   `  ����G  CServiexpress, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Serviexpress.Vistas.ServiciosServiexpress.Vistas.Servicios  5   	   6    0Serviexpress.Vistas.Servicios.modificarServicios   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   7local+clr-namespace:Serviexpress.Vistas.Servicios  5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ modificarServicios��5
   	   $��416.458��6$   $��356.979��65   .��5      � .+�5   
   �� -   5         ��Name$ lblModServicios��5      $��Editar Servicios��6)   $
��Left=�6D   $��	43,10,0,0q�6_   $	��Top=�6r   $	��250��6�   $��30(�6�   $��Italic$�6�   $��SemiBold"�6�   $��Center=�6�   �� 5   
   -   5        $ lblModFechaServicios��5      $��Fecha ��6.   $
��Left=�6?   $��
67,139,0,0q�6Z   $	��Top=�6n   $	��101��6�   �� 5   
   -   5        $ lblModIDReservaHora��5      $��
ID Reserva��6-   $
��Left=�6B   $��
67,229,0,0q�6]   $	��Top=�6q   $	��101��6�   �� 5   
   -   5        $ lblModValidado��5      $��	Validado?��6(   $
��Left=�6<   $��
67,185,0,0q�6W   $	��Top=�6k   $	��101��6�   �� 5   
   -   5        $ lblModComentario��5      $��
Comentario��6*   $
��Left=�6?   $��
67,273,0,0q�6Z   $	��Top=�6n   $	��101��6�   �� 5   
   -   5         ��Name$ txtModIDReserva��5      $
��Left=�6+   $��26��6F   $��173,229,0,0q�6R    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   -   5        $ txtModComentario��5      $
��Left=�6,   $��26��6G   $��173,273,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   �� 5   
   -   5         ��Name$ btnModEditarServicios��5      $��Editar��60   $
��Left=�6A   $��240,320,0,0q�6\   $	��Top=�6q   $��75��6�   $��28��6�   6�   �� 5   
   -	   5        $ btnModSalir��5      $��Salir��6&   $
��Left=�66   $��143,320,0,0q�6Q   $	��Top=�6f   $��74��6~   $��28��6�   6�   (  "System.Windows.Controls.DatePicker  5   
   -
   5          Name$ 
dpModFecha��5      $
��Left=�6)   $��173,139,0,0q�6D   $	��Top=�6Y   $��26��6q   $	��120��6}   �� 5   
   -   5        $ txtModValidado��5      $
��Left=�6*   $��26��6E   $��173,185,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $ lblModIDServicios��5      $��ID��6+   $
��Left=�68   $��	67,97,0,0q�6S   $	��Top=�6f   $	��101��6~   �� 5   
   -   5        $ txtModIDServicios��5      $
��Left=�6-   $��26��6H   $��
173,97,0,0q�6T   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   5      5      
   M S B A M L   `   `   `  ����G  CServiexpress, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Serviexpress.Vistas.Administrador!Serviexpress.Vistas.Administrador  5   	   9    3Serviexpress.Vistas.Administrador.modificarUsuarios   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   ;local/clr-namespace:Serviexpress.Vistas.Administrador  5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ modificarUsuarios��5
   	   $	��402��6#   $	��579��60   .��5      � .+�5   
   �� -   5         ��Name$ lblModID��5      $��ID��6"   $
��Left=�6/   $��	48,76,0,0q�6J   $	��Top=�6]   $��25��6u   $��74��6�   �� 5   
   -   5        $ 	lblModRut��5      $	��Rut��6#   $
��Left=�61   $��
48,104,0,0q�6L   $	��Top=�6`   $��74��6x   $��25��6�   �� 5   
   -   5         ��Name$ 	txtModRut��5      $
��Left=�6%   $��25��6@   $��127,104,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   -   5        $ txtModDV��5      $
��Left=�6$   $��25��6?   $��252,104,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $��28��6�   �� 5   
   -   5        $ lblModPnombre��5      $��Primer Nombre��6'   $
��Left=�6?   $��
22,134,0,0q�6Z   $	��Top=�6n   $	��100��6�   $��25��6�   �� 5   
   -   5        $ txtModPnombre��5      $
��Left=�6)   $��25��6D   $��127,134,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   -   5        $ lblModSnombre��5      $��Segundo Nombre��6'   $
��Left=�6@   $��292,129,0,0q�6[   $	��Top=�6p   $	��105��6�   $��30��6�   �� 5   
   -   5        $ txtModSnombre��5      $
��Left=�6)   $��25��6D   $��402,134,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   -	   5        $ lblModApaterno��5      $��Apellido Paterno��6(   $
��Left=�6C   $��
22,164,0,0q�6^   $	��Top=�6r   $	��100��6�   $��25��6�   �� 5   
   -
   5        $ txtModApaterno��5      $
��Left=�6*   $��25��6E   $��127,164,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $ lblModAmaterno��5      $��Apellido Materno��6(   $
��Left=�6C   $��292,159,0,0q�6^   $	��Top=�6s   $	��105��6�   $��30��6�   �� 5   
   -   5        $ txtRut_Copy3��5      $
��Left=�6(   $��25��6C   $��402,159,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   -   5        $ txtModAmaterno��5      $
��Left=�6*   $��25��6E   $��402,164,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $ lblModCorreo��5      $��Correo��6&   $
��Left=�67   $��
22,194,0,0q�6R   $	��Top=�6f   $	��100��6~   $��25��6�   �� 5   
   -   5        $ txtModCorreo��5      $
��Left=�6(   $��25��6C   $��127,194,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   -   5        $ lblModUsuario��5      $��Usuario��6'   $
��Left=�69   $��292,194,0,0q�6T   $	��Top=�6i   $	��105��6�   $��30��6�   �� 5   
   -   5        $ txtModUsuario��5      $
��Left=�6)   $��25��6D   $��402,194,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   -   5        $ 
lblModTipo��5      $��Tipo Usuario��6$   $
��Left=�6;   $��
22,254,0,0q�6V   $	��Top=�6j   $	��100��6�   $��25��6�   �� 5   
   -   5        $ lblModFecha��5      $��	Fecha Nac��6%   $
��Left=�69   $��292,224,0,0q�6T   $	��Top=�6i   $	��105��6�   $��30��6�   �� 5   
   -   5         ��Name$ btnModificar��5      $��
Actualizar��6'   $
��Left=�6<   $��440,294,0,0q�6W   $	��Top=�6l   $��82��6�   ��6�   2  ,MahApps.Metro.Markup.StaticResourceExtension  **(MahApps.Styles.Button.MetroSquare.Accent+�� 5    
   -   5         ��Name$ 
cmbModTipo��5       $
��Left=�6'   $��127,254,0,0q�6B   $	��Top=�6W   $	��120��6o   $��25��6{   (  "System.Windows.Controls.DatePicker  5!   
   -   5          Name$ dpModFechaNac��5!      $
��Left=�6,   $��402,225,0,0q�6G   $	��Top=�6\   $	��120��6t   �� 5"   
   -   5        $ txtModContrasena��5"      $
��Left=�6,   $��25��6G   $��127,224,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   �� 5#   
   -   5        $ lblModContra��5#      $��
Contrasena��6&   $
��Left=�6;   $��
22,224,0,0q�6V   $	��Top=�6j   $	��100��6�   $��25��6�   �� 5$   
   -   5        $ txtModID��5$      $
��Left=�6$   $��25��6?   $��
127,76,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5%   
   $��Editar Usuarios��6   $
��Left=�6*   $��
101,10,0,0q�6E   $	��Top=�6Y   $	��391��6q   $��Center=�6}   $��58��6�   $��36(�6�   �� 5&   
   -   5        $ btnCancelar��5&      $��Cancelar��6&   $
��Left=�69   $��345,294,0,0q�6T   $	��Top=�6i   $��75��6�   ��6�     **(MahApps.Styles.Button.MetroSquare.Accent+5(      5)      
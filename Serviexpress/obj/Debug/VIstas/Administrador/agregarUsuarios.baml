   M S B A M L   `   `   `  ����G  CServiexpress, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Serviexpress.Vistas.Administrador!Serviexpress.Vistas.Administrador  5   	   7    1Serviexpress.Vistas.Administrador.agregarUsuarios   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   ;local/clr-namespace:Serviexpress.Vistas.Administrador  5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ agregarUsuarios��5
   	   $	��403��6!   $	��627��6.   .��5      � .+�5   
   �� -   5         ��Name$ 
txtUsuario��5      $
��Left=�6&   $��23��6A   $��424,186,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   -   5        $ txtContrasena��5      $
��Left=�6)   $��23��6D   $��135,214,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   -   5        $ 	txtCorreo��5      $
��Left=�6%   $��23��6@   $��135,186,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   -   5        $ 
txtPnombre��5      $
��Left=�6&   $��25��6A   $��135,126,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   -   5        $ 
txtSnombre��5      $
��Left=�6&   $��25��6A   $��424,126,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   -   5        $ txtApaterno��5      $
��Left=�6'   $��23��6B   $��135,156,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5   
   -   5        $ txtAmaterno��5      $
��Left=�6'   $��23��6B   $��424,158,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5   
   -   5        $ txtRut��5      $
��Left=�6"   $��25��6=   $��
135,96,0,0q�6I   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   �� 5   
   -	   5        $ txtDV��5      $
��Left=�6!   $��25��6<   $��
260,96,0,0q�6H   $
 Wrap=�6\   $	��Top=�6p   $��26��6�   �� 5   
   -
   5         ��Name$ 
btnAgregar��5      $��Agregar��6%   $
��Left=�67   $��469,288,0,0q�6R   $	��Top=�6g   $��75��6   ��6�   2  ,MahApps.Metro.Markup.StaticResourceExtension  **(MahApps.Styles.Button.MetroSquare.Accent+(  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
dpFechaNac��5      $
��Left=�6)   $��424,242,0,0q�6D   $	��Top=�6Y   $��23��6q   $	��120��6}   �� 5   
   -   5         ��Name$ lblRut��5      $	��Rut��6    $
��Left=�6.   $��	22,96,0,0q�6I   $	��Top=�6\   $��25��6t   $	��108��6�   $��Right=�6�   �� 5   
   -   5        $ 
lblPNombre��5      $��Primer Nombre��6$   $
��Left=�6<   $��
19,126,0,0q�6W   $	��Top=�6k   $��25��6�   $	��111��6�   $��Right=�6�   �� 5   
   -   5        $ 
lblSNombre��5      $��Segundo Nombre��6$   $
��Left=�6=   $��299,126,0,0q�6X   $	��Top=�6m   $��25��6�   $	��120��6�   $��Right=�6�   �� 5   
   -   5        $ lblAPaterno��5      $��Apellido Paterno��6%   $
��Left=�6@   $��
19,156,0,0q�6[   $	��Top=�6o   $��25��6�   $	��111��6�   $��Right=�6�   �� 5   
   -   5        $ lblAMaterno��5      $��Apellido Materno��6%   $
��Left=�6@   $��299,156,0,0q�6[   $	��Top=�6p   $��25��6�   $	��120��6�   $��Right=�6�   �� 5   
   -   5        $ 	lblCorreo��5      $��Correo��6#   $
��Left=�64   $��
19,186,0,0q�6O   $	��Top=�6c   $	��111��6{   $��Right=�6�   �� 5   
   -   5        $ 
lblUsuario��5      $��Usuario��6$   $
��Left=�66   $��299,183,0,0q�6Q   $	��Top=�6f   $	��120��6~   $��Right=�6�   �� 5   
   -   5        $ lblContrasena��5      $��Contraseña��6'   $
��Left=�6<   $��
22,211,0,0q�6W   $	��Top=�6k   $	��108��6�   $��Right=�6�   �� 5   
   -   5        $ lblTipo��5      $��Tipo Usuario��6!   $
��Left=�68   $��
19,242,0,0q�6S   $	��Top=�6g   $	��108��6   $��Right=�6�   $��23��6�   �� 5    
   -   5        $ lblFechaNac��5       $��Fecha Nacimiento��6%   $
��Left=�6@   $��311,242,0,0q�6[   $	��Top=�6p   $	��108��6�   $��Right=�6�   $��23��6�   �� 5!   
   -   5         ��Name$ cmbTipoUsuario��5!      $
��Left=�6+   $��135,242,0,0q�6F   $	��Top=�6[   $	��120��6s   �� 5"   
   $��Creación de Usuarios��6   $
��Left=�6/   $��
135,10,0,0q�6J   $	��Top=�6^   $	��391��6v   $��Center=�6�   $��58��6�   $��36(�6�   �� 5#   
   -   5        $ btnCancelar��5#      $��Cancelar��6&   $
��Left=�69   $��370,288,0,0q�6T   $	��Top=�6i   $��75��6�   ��6�     **(MahApps.Styles.Button.MetroSquare.Accent+6�   5%      5&      
   M S B A M L   `   `   `  ����G  CHellloWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:HellloWpfAppHellloWpfApp  5   	       HellloWpfApp.LoginWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:HellloWpfApp     5   	     � Title$   Đăng nhập hệ thống��5   	   $	��165��6$   $	��275��61   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��11* �6   �� 5      $
��149* �6   .+�5   
   �� $��_User Name:��6   $
��Left=�5      $��	10,19,0,0q�6+   $	��Top=�6>   $��80��6V   $��2��6a    �� Target 5      ��  �� ElementName$ txtUserName��5   a   �� 5   
   -   5         ��Name$ txtUserName��5      $��1��6'   $
��Left=�67   $��	71,23,0,0q�6R    �� TextWrapping$
 Wrap=�6e   $��my user name��6y   $	��Top=�6�   $	��155��6�   �� 5   
   $��
_Password:��6   $
��Left=�5      $��9,59,0,0q�6+   $	��Top=�6=   $��85��6U   $��2��6`    5      �� $ txtPassword��5   `   G� 5   
   -   5         G�Name$ txtPassword��5      $��1��6+   $
��Left=�6;   $��72,0,0,0q�6V   $��Center=�6h   $	��156��6�   �� 5   
   -   5         ��Name$ btnDangNhap��5      $��1��6&   $��Đăng nhập��66   $
��Left=�6J   $��	39,99,0,0q�6e   $	��Top=�6x   $��66��6�   6�   �� 5   
   -   5        $ btnThoat��5      $��1��6#   $��Thoát��63   $
��Left=�6C   $��
130,99,0,0q�6^   $	��Top=�6r   $��65��6�   6�   5      5      
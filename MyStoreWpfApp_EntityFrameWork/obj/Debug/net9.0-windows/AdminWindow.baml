   M S B A M L   `   `   `  ����X  TMyStoreWpfApp_EntityFrameWork, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:MyStoreWpfApp_EntityFrameWorkMyStoreWpfApp_EntityFrameWork  5   	   /    )MyStoreWpfApp_EntityFrameWork.AdminWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:MyStoreWpfApp_EntityFrameWork     5   	     � Title$  AdminWindow��5   	   $	��450��6   $	��800��6*   .��5	      ]� .+�5
   
   � $	��Top=�6   $��50��6)   
��� ���.+�5      �� $+��%Hệ thống ADMIN quản trị STORE��6   $��20(�6<   5      �� 5   
   $��Bottom=�6   $��30��6-   
�������.+�5      �� $$��Designed by: Trần Thị Héo��6   5      R� 5   
   -   5         R�Name$ 
tvCategory��5   5   $
��Left=�6   $	��250��6)   
�������6\   ]� 5   
   
����� �.+�5      �� -   5         ��Name$ 	lvProduct��5      $	��Top=�6*   $	��250��6?   
���� ��$��20(�6a    �� View 5      �� 5      .P�5      �� $��Mã sản phẩm��6)    �� DisplayMemberBinding 5      �� *	ProductId+�� 5      $��Tên sản phẩm��6)    5      �� *ProductName+�� 5      $��Số lượng��6)    5      �� *UnitsInStock+�� 5       $
��Giá��6)    5!      �� *	UnitPrice+5#      5%      � 5&      
�������6(   5'      5(      5*      
   M S B A M L   `   `   `  ����C  ?WPF_LINQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPF_LINQWPF_LINQ  5   	       WPF_LINQ.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WPF_LINQ     5   	   -   5          � Title$  Thông tin nhân viên��5   	   $��20(�6%   $	��600��63   $	��800��6@    � 	Resources 5	         WPF_LINQ.BoolConverter   GioiTinh   WPF_LINQ.DateTimeConverter  NgaySinh��%:   &	        &	        5
   
   61     5   
   65   5      .��5      � .+�5   
   ��  5       �� 
TargetType 
 style1 �� Property �� Value �� BasedOn(  "System.Windows.Controls.DatePicker��%�  &	       '	� �     7  '  �     7  '�� �     7  '��     '�� �    '�� ~    �� 5      " ��6   .�5      ��  � ��$ Times New Roman)�63   �� 5       � ��$ 18(�61   �� 5       � ��$	 5,5q�6/   5      �� 5      " 	�6   8   61   �� 5      "  6   8   60   �� 5      " ��6   8   6.   �� 5      " ��6   .�5      ��  � ��$ Times New Roman)�63   �� 5       � ��$ 18(�61   �� 5       � ��$
 10,5q�6/   �� 5       � ��$	 120��6.   5      �� 5       " ��6   .�5!      ��  � ��$	 250��6.   �� 5"       � ��$ 30��6/   �� 5#       � ��$	 5,5q�6/   �� 5$       � ��$ 18(�61   5%      �� 5'      " ��6   .�5(      ��  � ��$ 18(�61   �� 5)       � ��$
 Bold"�63   �� 5*       � ��$	 100��6.   �� 5+       � ��$ 40��6/   �� 5,       � ��$ 7q�6/   5-      5.      .+�5/      ��  �� Orientation$ 
Horizontal=�6   .+�50      �� 
���   �.��51      �� .+�52      �� $ 
Horizontal=�6%   .+�53      �� $��Mã nhân viên��6(   �� 54      -   5        $��txtMaNV��54   &   ��65   ��  �� ElementName$
 data�� �� Path$ SelectedItem.MaNV�55      �� 57      $ 
Horizontal=�6%   .+�58      �� $��Họ và tên��6(   �� 59      -   5        	 ��Name$	 txtHoTen��59   &   ��68   �� $
 data��$ SelectedItem.TenNV�5:      �� 5<      $ 
Horizontal=�6%   .+�5=      �� -   5        
 ��Name$
 	textBlock��5=   (   $��Giới tính��6;   	� 5>      -   5        $��rdNam��5>   +    	� 	GroupName$ gt��68   $	��Nam��6G    d� 	IsChecked 6U   �� $
 data��$ SelectedItem.GioiTinh�	� 5?      -   5        $
��rdNu��5?   +   $ gt��68   $
��Nữ��6G    6T   �� $
 data��$ SelectedItem.GioiTinh� �� 	Converter# [  5@      �� 5B      $ 
Horizontal=�6%   .+�5C      �� $��
Ngày sinh��6(     5D      -   5        $��
dpNgaySinh��5D   )   $	��250��6;   $��30��6G      Text 6S   �� $
 data��$ SelectedItem.NgaySinh�# [  �� Mode$ TwoWay=�5E      �� 5G      $ 
Horizontal=�6%   .+�5H      �� $��
Phòng ban��6(   �� 5I      -   5        $��cboPhongBan��5I   &    �� SelectedIndex$ 0��6:   $	��250��6L   $��30��6X    �� SelectedValue 6d   �� $
 data��$ SelectedItem.MaPB�5J      �� 5L      $ 
Horizontal=�6%   .+�5M      �� $��Số điện thoại��6(   �� 5N      -	   5        $��txtSDT��5N   &   ��64   �� $
 data��$ SelectedItem.SoDT�5O      5P      5Q      �� 5S      
������$
��50,5q�64   $	��120��6B   .��5T      �� $ 
Horizontal=�6!   .+�5U      �� .+�5V      �� -
   5        $��btnThem��5V   4   $��Thêm��6%   6C   �� 5W      -   5        $��btnXoa��5W   3   $
��Xóa��6%   6A   5X      �� 5Y      .+�5Z      �� -   5        $��	btnLamMoi��5Z   7   $��
Làm mới��6%   6H   �� 5[      -   5        $��btnThoat��5[   5   $��Thoát��6%   6E   5\      5]      5_      5`      �� 5a      .+�5b      &   System.Windows.Controls.DataGrid  -   5        $
��data��5b      $��18(�6'   $	��700��65   $	��300��6A      AutoGenerateColumns .     Columns 5c      0  *System.Windows.Controls.DataGridTextColumn  5d      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã nhân viên��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$	 130 6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6O   �� *MaNV+  5e      $ Tên nhân viên��6-   $	 150 6D    6P   �� *TenNV+  5f      $ 
Ngày Sinh��6-   $	 150 6@    6L   �� *
NgaySinh+  5g      $ Giới Tính��6-   $	 130 6@    6L   �� *
GioiTinh+  5h      $ Số điện Thoại��6-   $	 150 6D    6P   �� *SoDT+  5i      $ Mã phòng ban��6-   $	 150 6C    6O   �� *MaPB+5l      5m      5n      5o      5p      
   M S B A M L   `   `   `  ����H  DLayoutExmaple, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LayoutExmapleLayoutExmaple  5   	       LayoutExmaple.Vd1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:LayoutExmaple     5   	     � Title$!  Chương trình tính toán��5   	   $	��400��6(   $	��600��65   .��5	      � $��20q�6    � ColumnDefinitions 5
   
   �� 5      $
��0.2* �6   �� 5      $
��0.5* �6   �� 5      $
��0.3* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��3��6   $��Center=�6$   $��25(�6A   $
��Bold"�6O   .��6a   Chương trình tính toán5      �� 5   
   $��1��6   $��0��6   $��15q�6-   $��Right=�69   .��6U   Số:6Z   �� 5   
   -   5         ��Name$ 	txtNumber��5      $��1��6%   $��1��62   $��15q�6B   6P   �� 5   
   $��2��6   $��0��6   $��15q�6-   $��Right=�69   .��6U   Kết quả:6_   �� 5    
   -   5        $ 	txtResult��5       $��2��6%   $��1��62   $��15q�6B   6P   �� 5"   
   -   5         ��Name$ btnBinhPhuong��5"      $��1��6(   $��2��65   $��15q�6E   .��6m   Bình phương6z   �� 5#   
   -   5        $ btnLapPhuong��5#      $��2��6'   $��2��64   $��15q�6D   .��6P   Lập phương6\   �� 5$   
   -   5        $ btnGiaiThua��5$      $��3��6&   $��2��63   $��15q�6C   .��6O   Giai thừa6Z   �� 5%   
   -   5        $ btnExit��5%      $��4��6"   $��1��6/   $��65 15 65 15q�6?   .��6T   Thoát6[   5&      5'      
   M S B A M L   `   `   `  ����I  EQuanLyBanVeMay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:QuanLyBanVeMayQuanLyBanVeMay  5   	       QuanLyBanVeMay.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:QuanLyBanVeMay     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        
�������$��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	      MaterialDesignPaper#���   5   	     MaterialDesignFont#���  5   	    � Title$ 
MainWindow��5   	   $	��600��6   $
��1050��6)    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   ���	#FF9642EA.��5      � -   5        .+�5   
   �� .+�5      � $	��Top=�6   ���	#FFBF90EE$��10��6B   � 5       $��5q�6   .+�5"      ��  �� Orientation$ 
Horizontal=�6   $��Right=�5#      $
��10 0q�5$      .+�5'      �� -   5         ��Name$ Button_Minimize��5'      $��30��5(      $��30��6(   
�������$��0q�5,      ��5)      Z� ��5*      Z� .��5.      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ WindowMinimize=�5/      50      �� 54      -   5        $ Button_Fechar��54      $��30��55      $��30��6(   
�������$��0q�59      ��56      Z� ��57      Z� .��5;        $ Power=�5<      5=      5?      5A      5C      #  MaterialDesignThemes.Wpf.Card  5F   
   $	��220��6   $	��600��6*   $
��Left=�67   ���	#FF292929.��5H      � 	 � RowDefinitions	 5I      �� 5J      $
��auto �6$   �� 5K      $
��auto �6$   �� 5L      $
��auto �6$   .+�5Q      � $
��auto��6&   $��2��5R   &   $��10q�5S   &   $
��Left=�5T   &   $	��Top=�5U   &   .+�5W      R� $	��200��6   +  %MaterialDesignThemes.Wpf.ShadowAssist
   ShadowDepth$
 Depth4=�6.   ���	#FFBF90EE.@�5Y      Q� -   5         Q�Name$
 Home��5Y   )   $��Tổng Quan��68   6K   Q� 5Z      -   5        $ Ticket��5Z   '   $��Bán Vé��68   6H   Q� 5[      -   5        $ Calender��5[   '   $��Lịch Chuyến Bay��6:   6S   Q� 5\      $��Đối Tác��6'   .@�5]      Q� -   5        $ Customer��5]   +   $��Khách Hàng��6>   6R   Q� 5^      -	   5        $ 
AirCompany��5^   +   $��	Hãng Bay��6@   6R   5_      Q� 5`      $��	Báo Cáo��6'   .@�5a      Q� -
   5        $ RPMonth��5a   +   $��Thống Kê Theo Tháng��6=   6Z   Q� 5b      -   5        $ RPYear��5b   +   $#��Thống Kê Theo Chuyến Bay��6<   6^   5c      Q� 5d      -   5        $ ChangeRules��5d   '   $��Thay Đổi Quy Định��6=   6X   5f      5h      #  MaterialDesignThemes.Wpf.Chip  5k      $
 Depth4=�6*   $��1��5l   &   $��20q�63   $��	AdminName��5m   &      IconBackground �	#FFAF76E8 ! PrimaryHueDarkForegroundBrush   IconForeground# �  5o   &   $	��140��6g   ���	#FFFAFAFA���	#FFAF76E8   Icon 5p        5q      $ Account=�62   5s      � 5u      $��0��6   ���	#FF150A1F.+�5y      �� $��FlyVietnam.com��6    
�������$��30(�6I   $��ExtraCondensed&�6W   $��	ExtraBold"�6t   $��Alina)�6�    �� TextAlignment$ Center=�6�   5z      5|      5}      � 5�   
    � ColumnDefinitions 5�      �� 5�      $	��200 �6#   �� 5�      .+�5�      � -   5         �Name$ 
MainScreen��5�      $��1��6'   $��	20 50 0 0q�67   5�      5�      5�      5�      
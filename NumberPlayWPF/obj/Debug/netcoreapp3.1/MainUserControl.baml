   M S B A M L   `   `   `  ����H  DNumberPlayWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:NumberPlayWPFNumberPlayWPF  5      #    NumberPlayWPF.MainUserControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:NumberPlayWPF     5      f bMaterialDesignThemes.MahApps, Version=0.1.7.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962ab ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962a<md1http://materialdesigninxaml.net/winfx/xaml/themes   5         MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��20(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	   .��5      � -   5        $��GridMainPanel��5      .+�5   
   � ���#082032 � ColumnDefinitions 5      �� 5      $	��250 �6#   �� 5      $��3 �6#   �� 5      $��* �6#   .+�5      � .+�5      �� $��0��6   $��10,120,10,0q�5      .+�5      �� -   5        $��StartBtn��5!      .  (MaterialDesignThemes.Wpf.TextFieldAssist   TextFieldCornerRadius$ 20��5      $��Ro'xatdan o'tish��5      $��Light"�5      $��0q�5      $��20(�5"      �� 5#      -   5        $��TimeBtn��5#      
�������$��Light"�5%         UnderlineCornerRadius$ 20��5&      ���#2C394B$��0,20,0,0q�5(      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Vaqtni kiriting:��5)      $��	10,5,10,4q�5*       �� 	MaxLength$ 3��5+       �� MinLines$ 1��5,      �� 5-      $��	10,20,0,0q�6    
�������$��Light"�5/        J� Opacity$	 0.5Q�50       $��Son oralig'in kiriting:��51       �� 52      -   5        $��StartNumber��52      
�������$��Light"�54      $ 20��55      ���#2C394B$ Boshlanish son kiriting:��57      $��	10,5,10,4q�58      $ 10��59      $ 1��5:      �� 5;      -   5        $��FinishNumber��5;      
�������$��Light"�5=      $ 20��5>      ���#2C394B$��0,20,0,0q�5@      $ Oxirgi son kiriting:��5A      $��	10,5,10,4q�5B      $ 30��5C      $ 1��5D      �� 5E      -   5        $��	MaxNumber��5E      
�������$��Light"�5G      $ 20��5H      ���#2C394B$��0,20,0,0q�5J      $&  Nechta javobdan keyin to'xtasin:��5K      $��10,5,2,4q�5L      $��15(�5M      $ 3��5N      $ 1��5O      �� 5P      $��	10,20,0,0q�6    
�������$��Light"�5R       $	 0.5Q�5S       $��15(�5T       $"��Siz qanday amallar yoradmida��5U       �� 5V      $��10,0,0,0q�6    
�������$��Light"�5X       $	 0.5Q�5Y       $��15(�5Z       $ ��misollarni ishlomoqchisiz:��5[       �� 5\      -   5        $��Kopaytirish��5f      $��Ko'paytirish:��5\      
���  ��
�������$��	10,0,10,5q�5_      $��Light"�5`      $��18(�5a      	 J� OpacityMask
	 �  ��$	 0.5Q�5c      
 �� Left$
 10��5d       �� Right$ 10��5e      5h      �� 5i      -   5        $��Bolish��5i      $��Bo'lish:��5j      
��� E��
�������$��	10,0,10,5q�5m      $��Light"�5n      $��18(�5o      
	 �����$	 0.5Q�5q      �� 5r      -	   5        $��Qoshish��5s      $��Qo'shish��5r      
��� ���
�������$��	10,0,10,5q�5v      $��Light"�5w      $��18(�5x      
	 �����$	 0.5Q�5z      �� 5{      -
   5        $��Ayrish��5|      $��Ayirish:��5{      
��� ���
�������$��
10,0,10,20q�5      $��Light"�5�      $��18(�5�      
	 �����$	 0.5Q�5�      5�      5�      � 5�      $��1��6   
���  ��5�      � 5�      -   5        $��AddUserC��5�      $��2��5�       � RowDefinitions 5�      �� 5�      $��40 �6$   �� 5�      $��* �6$   .+�5�      � $��0��6   .+�5�      �� -   5        $��InformationText��5�      $��0,10,0,0q�5�       
���  ��$��Light"�5�       $��20(�5�      $y�Hidden=�5�      $ 1Q�5�       $-��'Siz hammasini to'liq to'ldirmadingiz!!!��5�      $��Center=�5�      $��Center=�5�      5�      � 5�      -   5        $��DateGridPanel��5�      $��1��5�      .+�5�      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5�         
IsReadOnly$
 True��5�         AutoGenerateColumns$ False��5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$	 №��61      Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 5�   1   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5�   1   �� *ID+  5�      $ 	FirstName��61   $ * 5�   1    5�   1   �� *	FirstName+  5�      $ LastName��61   $ * 5�   1    5�   1   �� *
LastName+  5�      $ Username��61   $ * 5�   1    5�   1   �� *
Username+  5�      $ Question��61   $	 130 5�   1    5�   1   �� *	AllAnswer+  5�      $ Answer��61   $	 120 5�   1    5�   1   �� *Answer+  5�      $
 Time��61   $	 100 5�   1    5�   1   �� *Time+5�      5�      5�      5�      5�      5�      
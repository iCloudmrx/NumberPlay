   M S B A M L   `   `   `  ���� H  DNumberPlayWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:NumberPlayWPFNumberPlayWPF  #    NumberPlayWPF.MainUserControl   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:NumberPlayWPF     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962af bMaterialDesignThemes.MahApps, Version=0.1.7.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962a<md1http://materialdesigninxaml.net/winfx/xaml/themes      MaterialDesignBody#���   $��Regular"�$��20(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper#���    MaterialDesignFont#���  .��� -   $��GridMainPanel��.+�� ���#082032 � ColumnDefinitions �� $	��250 ��� $��3 ��� $��* �.+�� .+��� $��0��$��10,120,10,0q�.+��� -   $��StartBtn��.  (MaterialDesignThemes.Wpf.TextFieldAssist   TextFieldCornerRadius$ 20��$��Ro'xatdan o'tish��$��Light"�$��0q�$��20(��� -   $��TimeBtn��
�������$��Light"�   UnderlineCornerRadius$ 20�����#2C394B$��0,20,0,0q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Vaqtni kiriting:��$��	10,5,10,4q� �� 	MaxLength$ 3�� �� MinLines$ 1���� $��	10,20,0,0q�
�������$��Light"� J� Opacity$	 0.5Q�$��Son oralig'in kiriting:���� -   $��StartNumber��
�������$��Light"�$ 20�����#2C394B$ Boshlanish son kiriting:��$��	10,5,10,4q�$ 10��$ 1���� -   $��FinishNumber��
�������$��Light"�$ 20�����#2C394B$��0,20,0,0q�$ Oxirgi son kiriting:��$��	10,5,10,4q�$ 30��$ 1���� -   $��	MaxNumber��
�������$��Light"�$ 20�����#2C394B$��0,20,0,0q�$&  Nechta javobdan keyin to'xtasin:��$��10,5,2,4q�$��15(�$ 3��$ 1���� $��	10,20,0,0q�
�������$��Light"�$	 0.5Q�$��15(�$"��Siz qanday amallar yoradmida���� $��10,0,0,0q�
�������$��Light"�$	 0.5Q�$��15(�$ ��misollarni ishlomoqchisiz:���� -   $��Kopaytirish��$��Ko'paytirish:��
���  ��
�������$��	10,0,10,5q�$��Light"�$��18(�	 J� OpacityMask
	 �  ��$	 0.5Q�
 �� Left$
 10�� �� Right$ 10���� -   $��Bolish��$��Bo'lish:��
��� E��
�������$��	10,0,10,5q�$��Light"�$��18(�
	 �����$	 0.5Q��� -	   $��Qoshish��$��Qo'shish��
��� ���
�������$��	10,0,10,5q�$��Light"�$��18(�
	 �����$	 0.5Q��� -
   $��Ayrish��$��Ayirish:��
��� ���
�������$��
10,0,10,20q�$��Light"�$��18(�
	 �����$	 0.5Q�� $��1��
���  ��� -   $��AddUserC��$��2�� � RowDefinitions �� $��40 ��� $��* �.+�� $��0��.+��� -   $��InformationText��$��0,10,0,0q�
���  ��$��Light"�$��20(�$y�Hidden=�$ 1Q�$-��'Siz hammasini to'liq to'ldirmadingiz!!!��$��Center=�$��Center=�� -   $��DateGridPanel��$��1��.+�&   System.Windows.Controls.DataGrid  -     Name$ dataGrid��   AutoGenerateColumns$ False��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$	 №��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *ID+  $ 	FirstName��$ *  �� *	FirstName+  $ LastName��$ *  �� *
LastName+  $ Username��$ *  �� *
Username+  $ Answer��$ *  �� *Answer+
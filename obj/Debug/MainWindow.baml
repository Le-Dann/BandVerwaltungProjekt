   M S B A M L   `   `   `  ����E  AwndNewBand, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:wndNewBand
wndNewBand  5   	       wndNewBand.Main_Window   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:wndNewBand     5   	     � Title$  Main_Window��5   	   $��440.4��6   $��569.6��6,    � WindowStartupLocation$ CenterScreen=�6:   .��5	      � $��0,0,16.2,8.4q�6    � ColumnDefinitions 5
   
   �� 5      $
��300* �6   �� 5      $	��100 �6   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��BandList��5      $��0��6(   $��0��65   $��0,10,24.6,0q�6E      CanUserAddRows .  $��Right=�6q   $	��Top=�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6E   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Q   �� *Name+	 �� Mode$	 OneWay=�6y     5      $ 
Mitglieder��6%   $	 100 69    6E   �� *AnzahlMitglieder+$	 OneWay=�6y     5      $ Alben��6%   $	 100 64    6@   �� *AnzahlAlben+$	 OneWay=�6o     5      $ Rating��6%   $
 100* 65    6C   �� *Rating+$	 OneWay=�6m   5      �� 5   
   $��0��6   $��1��6"   
 �� Orientation$
 Vertical=�62   $��Bottom=�6I   .+�5      �� -   5         ��Name$ butHinzufügen��5      $��Hinzufügen��6,   $��Stretch=�6A   $��5q�6_   $	��Top=�6j   $��92��6�   $��28��6�   $��1��6�   �� 5   
   -   5        $ butSchliessen��5      $��
Schliessen��6(   $��Stretch=�6=   $��5q�6[   $	��Top=�6f   $��92��6~   $��28��6�   $��1��6�   6�   �� 5   
   -   5        $ 	butDelete��5      $��Löschen��6$   $��1��66   $��Stretch=�6F   $��5q�6d   $	��Top=�6o   $��92��6�   $��25��6�   6�   5      5      5      
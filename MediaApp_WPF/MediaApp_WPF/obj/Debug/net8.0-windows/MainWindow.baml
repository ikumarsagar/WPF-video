   M S B A M L   `   `   `  ����G  CMediaApp_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MediaApp_WPFMediaApp_WPF  5   	       MediaApp_WPF.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MediaApp_WPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��0.2* �6   �� 5      $
��0.8* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� -   5         ��Name$ 	btnUpload��5      $��Upload��6(   $
��Left=�69   $��Center=�6T   6o   5      �� 5   
   $��1��6   .+�55      &   System.Windows.Controls.DataGrid  -   5          Name$ videoDataGrid��55         AutoGenerateColumns$ False��6.   ��6J   �� *VideoModelList+   Columns 56      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Name+	 �� Mode$	 OneWay=�  5;      $ Duration��6)    6;   �� *ModifiedDate+$	 OneWay=�  5>      $
 Size��6)    67   �� *Size+$	 OneWay=�4  .System.Windows.Controls.DataGridTemplateColumn  5A      $ Download��6-   
   CellTemplate
 5B      �� 5C      .R�5D   "   �� -   5        $��Download��5D   )   6<   5E      5G      5I      5K      �� 5M   
   -   5        $ btnDownload��5M      $��Download��6&   $
��Left=�69   $��Center=�6T   $��	400,0,0,0q�6o   6�   r� 5N   
   $
��Left=�6   $	��100��62   $��
75,144,0,0q�6?   $	��Top=�6S   $	��100��6k   5O      5P      
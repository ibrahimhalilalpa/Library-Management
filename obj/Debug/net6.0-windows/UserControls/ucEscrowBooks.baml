   M S B A M L   `   `   `  ����I  ELibraryProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:LibraryProject.UserControlsLibraryProject.UserControls  5      /    )LibraryProject.UserControls.ucEscrowBooks   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:LibraryProject.UserControls     5      -   5        .��5	      �   � RowDefinitions  5
   
   �� 5      �� 5      $��80 �6   .+�5   
   �� $��0��6   ._�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dtg_EscrowBooks��5      
���   �   
IsReadOnly$
 True��6r      	RowHeight$ 30Q�6�      CanUserAddRows$ False��6�      CanUserSortColumns$
 True��6�      CanUserResizeColumns$ False��6�      CanUserResizeRows$ False��6�      HorizontalGridLinesBrush
 �����	   VerticalGridLinesBrush
	 �����
   HeadersVisibility$
 Column=�69     AutoGenerateColumns$ False��6T     DataGridStyle1#���   6p  ��60   �� ��6H   Z�    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly$
 True��5   5      Header$ ID��6G      MinWidth$ 50Q�6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6   ��  �� Path$ ID�   ElementStyle 5      �� 5       �� 
TargetType" ��6$   .�5   "   ��  �� Property � �� �� Value$
 Left=�6H   �� 5   "    � ��$ Center=�6F   �� 5   "    �@��Padding$ 5q�6<   5         	CellStyle 5      �� 5       *  $System.Windows.Controls.DataGridCell"  6$   .�5!   "   ��  � �� �#2e61af6?   �� 5"   "    � ��$ 0,0,0,0q�6D   �� 5#   "    � �� �	#FF1341876@   �� 5$   "    � ��
 �����6?    �� Triggers 5%   "   P� 5&   &    P� Property �@ 
IsSelected P� Value$
 True��6D   . �5'   *   ��  � �� �	#FF1341876G   �� 5(   *    � ��$ 0,0,0,0q�6L   �� 5)   *    � ��
 � �|�6H   �� 5*   *    � ��
 �����6G   5+   '   5-      5/        50      $
 True��51   ;   $ ReaderID��6M    �� TextAlignment$ Center=�6_   $��Expanded&�6�    6   �� $ ReaderID� 52      �� 53      " ��6$   .�54   "   ��  � ��$
 Left=�6H   �� 55   "    � ��$ Center=�6F   �� 56   "    �@��Padding$ 5,0,5,0q�6<   57      59        5:      $
 True��5;   9   $ Book ID��6K   $ Center=�6\   $��Expanded&�6}    6   �� $ BookID� 5<      �� 5=      " ��6$   .�5>   "   ��  � ��$
 Left=�6H   �� 5?   "    � ��$ Center=�6F   �� 5@   "    �@��Padding$ 5,0,5,0q�6<   5A      5C        5E      $
 True��5F   =   $ Escrow Date��6O   $ Center=�6d   $��Expanded&�6�    6   �� $ 
EscrowDate� 5G      �� 5H      " ��6$   .�5I   "   ��  � ��$
 Left=�6H   �� 5J   "    � ��$ Center=�6F   �� 5K   "    �@��Padding$ 5,0,5,0q�6<   5L      5N        5O      $
 True��5P   =   $ Return Date��6O   $ Center=�6d   $��Expanded&�6�    6   �� $ 
ReturnDate� 5Q      �� 5R      " ��6$   .�5S   "   ��  � ��$
 Left=�6H   �� 5T   "    � ��$ Center=�6F   �� 5U   "    �@��Padding$ 5,0,5,0q�6<   5V      5X        5Z      $
 True��5[   >   $ User Name Surname��6P   $ Center=�6k   $��Expanded&�6�    6   �� $ NameSurname� 5\      �� 5]      " ��6$   .�5^   "   ��  � ��$
 Left=�6H   �� 5_   "    � ��$ Center=�6F   �� 5`   "    �@��Padding$ 5,0,5,0q�6<   5a      5c      5g      5h      �� 5j   
   
�������$��1��6$   ._�5k      �� .+�5l      �� -   5         ��Name$ btn_SearchEscrowBook��5l      $��Search��6Z    �� Left$	 225��6k   
 �� Top$ 5��6}   $��30��6�   $��75��6�   ���	#FF63AF5D$
��Left=�6�   $��Center=�6�   �� 5m      $��Search Escrow Book:��6   $��30��66   $ 5��6B   ���	#FFA8D2CB$ 10��6h   6{   �� 5n      -   5         ��Name$ txt_SearchEscrowBook��5n      $��84��68   $��30��6C   $	 135��6O   $ 5��6a   $
��Left=�6p   6�   �� 5o      -   5         ��Name$ lb_EscrowCount��5o      $��Escrow count:��60   $��27��6H   $ 42��6T   ���	#FFA8D2CB$	 320��6{   $
��Left=�6�   $��Center=�6�   $
��Left=�6�   $��Center=�6�   $	��130��6  6  �� 5p      -   5        $ btn_SearchUsername��5p      $��Search��6V   $	 225��6g   $ 41��6y   $��30��6�   $��75��6�   ���	#FF63AF5D$
��Left=�6�   $��Center=�6�   �� 5q      $��Search Username:��6   $��28��63   $ 40��6?   ���	#FFA8D2CB$ 11��6f   $��Right=�6w   $��Center=�6�   $	��115��6�   6�   �� 5r      -   5        $ txt_SearchUsername��5r      $��84��66   $��28��6A   $	 135��6M   $ 41��6_   $
��Left=�6o   $	��Top=�6�   �� 5t      -   5        $ btn_DeleteEscrowBook��5t      $��Delete��67     userControlDeleteStyle#���  6k   $	 420��6�   $ 7��6�   6�   �� 5u      -	   5        $ btn_UpdateEscrowBook��5u      $��Update��67     userControlUpdateStyle#���  6k   $	 480��6�   $ 7��6�   6�   �� 5v      -
   5        $ btn_AddEscrowBook��5v      $��Add Book��64     userControlAddStyle#���  6g   $	 538��6�   $ 7��6�   $
��Left=�6�   $��Center=�6�   6�   5x      5z      5{      5|      
   M S B A M L   `   `   `  ����I  ELibraryProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:LibraryProject.UserControlsLibraryProject.UserControls  5      0    *LibraryProject.UserControls.ucExpiredBooks   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:LibraryProject.UserControls     5      -   5        .��5	      �   � RowDefinitions  5
   
   �� 5      �� 5      $��60 �6   .+�5   
   �� $��0��6   ._�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dtg_ExpiredBooks��5      
���   �   
IsReadOnly$
 True��6s      	RowHeight$ 30Q�6�      CanUserAddRows$ False��6�      CanUserSortColumns$
 True��6�      CanUserResizeColumns$ False��6�      CanUserResizeRows$ False��6�      HorizontalGridLinesBrush
 �����	   VerticalGridLinesBrush
	 �����
   HeadersVisibility$
 Column=�6:     AutoGenerateColumns$ False��6U     DataGridStyle1#���   6q  ��61   �� ��6I   Z�    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly$
 True��5   5      Header$ ID��6G      MinWidth$ 50Q�6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6   ��  �� Path$ ID�   ElementStyle 5      �� 5       �� 
TargetType" ��6$   .�5   "   ��  �� Property � �� �� Value$
 Left=�6H   �� 5   "    � ��$ Center=�6F   �� 5   "    �@��Padding$ 5q�6<   5         	CellStyle 5      �� 5      *  $System.Windows.Controls.DataGridCell"  6$   .�5    "   ��  � �� �#2e61af6?   �� 5!   "    � ��$ 0,0,0,0q�6D   �� 5"   "    � �� �	#FF1341876@   �� 5#   "    � ��
 �����6?    �� Triggers 5$   "   P� 5%   &    P� Property �@ 
IsSelected P� Value$
 True��6D   . �5&   *   ��  � �� �	#FF1341876G   �� 5'   *    � ��$ 0,0,0,0q�6L   �� 5(   *    � ��
 � �|�6H   �� 5)   *    � ��
 �����6G   5*   '   5,      5.        50      $
 True��51   ;   $ 	Reader ID��6M    �� TextAlignment$ Center=�6`   $��Expanded&�6�    6   �� $ ReaderID� 52      �� 53      " ��6$   .�54   "   ��  � ��$
 Left=�6H   �� 55   "    � ��$ Center=�6F   �� 56   "    �@��Padding$ 5,0,5,0q�6<   57      59        5:      $
 True��5;   9   $ Book ID��6K   $ Center=�6\   $��Expanded&�6}    6   �� $ BookID� 5<      �� 5=      " ��6$   .�5>   "   ��  � ��$
 Left=�6H   �� 5?   "    � ��$ Center=�6F   �� 5@   "    �@��Padding$ 5,0,5,0q�6<   5A      5C        5E      $
 True��5F   :   $ Barcode��6L   $ Center=�6]   $��Expanded&�6~    6   �� $ Barcode� 5G      �� 5H      " ��6$   .�5I   "   ��  � ��$ Center=�6H   �� 5J   "    � ��$ Center=�6F   �� 5K   "    �@��Padding$ 5,0,5,0q�6<   5L      5N        5O      $
 True��5P   ;   $ 	Book Name��6M   $ Center=�6`   $��Expanded&�6�    6   �� $ BookName� 5Q      �� 5R      " ��6$   .�5S   "   ��  � ��$
 Left=�6H   �� 5T   "    � ��$ Center=�6F   �� 5U   "    �@��Padding$ 5,0,5,0q�6<   5V      5X        5Y      $
 True��5Z   =   $ Escrow Date��6O   $ Center=�6d   $��Expanded&�6�    6   �� $ 
EscrowDate� 5[      �� 5\      " ��6$   .�5]   "   ��  � ��$
 Left=�6H   �� 5^   "    � ��$ Center=�6F   �� 5_   "    �@��Padding$ 5,0,5,0q�6<   5`      5b        5c      $
 True��5d   =   $ Return Date��6O   $ Center=�6d   $��Expanded&�6�    6   �� $ 
ReturnDate� 5e      �� 5f      " ��6$   .�5g   "   ��  � ��$
 Left=�6H   �� 5h   "    � ��$ Center=�6F   �� 5i   "    �@��Padding$ 5,0,5,0q�6<   5j      5l      5q      5r      �� 5t   
   
�������$��1��6$   ._�5u      �� .+�5v      �� -   5         ��Name$ btn_DeleteExpiredBook��5v      $��Delete��68     userControlDeleteStyle#���  6m    �� Left$	 385��6�   
 �� Top$ 8��6�   $��96��6�   $��32��6�   $
��Left=�6�   $��Center=�6�   6  �� 5w      -   5         ��Name$ lb_ExpiredCount��5w      $��Expired count:��61   $��40��6J   $ 8��6V   ���	#FFA8D2CB$ 78��6|   $
��Left=�6�   $��Center=�6�   $	��134��6�   6�   5y      5{      5|      5}      
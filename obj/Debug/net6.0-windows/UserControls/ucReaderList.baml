   M S B A M L   `   `   `  ����I  ELibraryProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:LibraryProject.UserControlsLibraryProject.UserControls  5      .    (LibraryProject.UserControls.ucReaderList   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:LibraryProject.UserControls     5      -   5        .��5	      �   � RowDefinitions  5
   
   �� 5      �� 5      $��80 �6   .+�5   
   �� $��0��6   ._�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dtg_ReaderList��5      
���   �   
IsReadOnly$
 True��6q      	RowHeight$ 30Q�6�      CanUserAddRows$ False��6�      CanUserSortColumns$
 True��6�      CanUserResizeColumns$ False��6�      CanUserResizeRows$ False��6�      HorizontalGridLinesBrush
 �����	   VerticalGridLinesBrush
	 �����
   HeadersVisibility$
 Column=�68     AutoGenerateColumns$ False��6S     DataGridStyle1#���   6o  ��6/   �� ��6G   Z�    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly$
 True��5   5      Header$ ID��6G      MinWidth$ 50Q�6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6   ��  �� Path$ ID�   ElementStyle 5      �� 5       �� 
TargetType" ��6$   .�5   "   ��  �� Property � �� �� Value$
 Left=�6H   �� 5   "    � ��$ Center=�6F   �� 5   "    �@��Padding$ 5q�6<   5         	CellStyle 5      �� 5      *  $System.Windows.Controls.DataGridCell"  6$   .�5    "   ��  � �� �#2e61af6?   �� 5!   "    � ��$ 0,0,0,0q�6D   �� 5"   "    � �� �	#FF1341876@   �� 5#   "    � ��
 �����6?    �� Triggers 5$   "   P� 5%   &    P� Property �@ 
IsSelected P� Value$
 True��6D   . �5&   *   ��  � �� �	#FF1341876G   �� 5'   *    � ��$ 0,0,0,0q�6L   �� 5(   *    � ��
 � �|�6H   �� 5)   *    � ��
 �����6G   5*   '   5,      5.        50      $
 True��51   5   $ TC��6G    �� TextAlignment$ Center=�6S   $��Expanded&�6t    6   �� $ TC� 52      �� 53      " ��6$   .�54   "   ��  � ��$ Center=�6H   �� 55   "    � ��$ Center=�6F   �� 56   "    �@��Padding$ 5,0,5,0q�6<   57      59        5:      $
 True��5;   >   $ Name Surname��6P   $ Center=�6f   $��Expanded&�6�    6   �� $ NameSurname� 5<      �� 5=      " ��6$   .�5>   "   ��  � ��$
 Left=�6H   �� 5?   "    � ��$ Center=�6F   �� 5@   "    �@��Padding$ 5,0,5,0q�6<   5A      5C        5D      $
 True��5E   @   $ Address Of User��6R   $ Center=�6k   $��Expanded&�6�    6   �� $ ReaderAddress� 5F      �� 5G      " ��6$   .�5H   "   ��  � ��$
 Left=�6H   �� 5I   "    � ��$ Center=�6F   �� 5J   "    �@��Padding$ 5,0,5,0q�6<   5K      5M        5N      $
 True��5O   8   $ Email��6J   $ Center=�6Y   $��Expanded&�6z    6   �� $ Email� 5P      �� 5Q      " ��6$   .�5R   "   ��  � ��$
 Left=�6H   �� 5S   "    � ��$ Center=�6F   �� 5T   "    �@��Padding$ 5,0,5,0q�6<   5U      5W        5X      $
 True��5Y   >   $ Phone Number��6P   $ Center=�6f   $��Expanded&�6�    6   �� $ PhoneNumber� 5Z      �� 5[      " ��6$   .�5\   "   ��  � ��$
 Left=�6H   �� 5]   "    � ��$ Center=�6F   �� 5^   "    �@��Padding$ 5,0,5,0q�6<   5_      5a        5b      $
 True��5c   ;   $ 	School No��6M   $ Center=�6`   $��Expanded&�6�    6   �� $ SchoolNo� 5d      �� 5e      " ��6$   .�5f   "   ��  � ��$
 Left=�6H   �� 5g   "    � ��$ Center=�6F   �� 5h   "    �@��Padding$ 5,0,5,0q�6<   5i      5k        5l      $
 True��5m   8   $ Class��6J   $ Center=�6Y   $��Expanded&�6z    6   �� $ Class� 5n      �� 5o      " ��6$   .�5p   "   ��  � ��$
 Left=�6H   �� 5q   "    � ��$ Center=�6F   �� 5r   "    �@��Padding$ 5,0,5,0q�6<   5s      5u      5z      5{      �� 5}   
   
�������$��1��6$   ._�5~      �� .+�5      �� -   5         ��Name$ lb_ReaderCount��5      $��Reader count:��60   $��30��6H   
 �� Top$ 19��6T   ���	#FFA8D2CB �� Left$ 32��6{   $
��Left=�6�   $��Center=�6�   $	��141��6�   $
��Left=�6�   $��Center=�6�   6  �� 5�      -   5         ��Name$ btn_DeleteUser��5�      $��Delete Reader��61     userControlDeleteStyle#���  6f   $	 491��6�   $ 19��6�   $
��Left=�6�   $��Center=�6�   $��85��6�   6�   �� 5�      -   5        $ btn_UpdateUser��5�      $��Update Reader��61     userControlUpdateStyle#���  6f   $	 586��6�   $ 18��6�   $
��Left=�6�   $��Center=�6�   $��84��6�   6�   �� 5�      -   5        $ btn_AddUser��5�      $��
Add Reader��6.     userControlAddStyle#���  6]   $	 684��6�   $ 17��6�   $
��Left=�6�   $��Center=�6�   $��80��6�   5�      5�      5�      5�      
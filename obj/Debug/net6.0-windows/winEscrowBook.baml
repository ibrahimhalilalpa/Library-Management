   M S B A M L   `   `   `  ����I  ELibraryProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:LibraryProjectLibraryProject  5   	   "    LibraryProject.winEscrowBook   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:LibraryProject     5   	     � Title$  winEscrowBook��5   	   $	��400��6   $
��1000��6,    � AllowsTransparency$
 True��69    � WindowStyle$
 None=�6S    � WindowStartupLocation$ CenterOwner=�6|    � 
ResizeMode$ NoResize=�6�   ��6f   Z� .��5	      � -   5        .+�5
   
   �� .+�5      �� $!��The Escrow Book Edit Window��6    �� Left$	 220��6:   
 �� Top$ 50��6L   $��30��6\    K� ZIndex$ 3��6h   
�������$
��Bold"�6�   $
��Left=�6�   $��Center=�6�      lbl_light_off#���   6�   $
��Left=�6
  $��Center=�6%  $	��186��6@  �� 5      $��30��6   $	��700��6$   $	 220��60   $ 50��6B   ���	#FF67324D$ 1��6c   $
��Left=�6t   $��Center=�6�   A� 5      $��54��6   $��66��6"   $
��Left=�6.   $	��Top=�6I   $	 804��6a   $	 186��6s   $ 2��6�   ��5      
� 5      .��5      �  � Color$ 	#FF44A044��6'   	 � Offset$	 0.933Q�69   5      5      �� 5      -   5        
 ��Name$
 btn_addEscrowBook��5      $��/add.book.png��6W   $	 820��6n   $	 192��6�   $��40��6�   $��40��6�   $ 3��6�   $
��Left=�6�   $	��Top=�6�   �� 5      $	��330��6   $	��700��6"   $	 220��6.   $ 50��6@   ���	#FFE0E0E0 �� CornerRadius$ 	0,0,25,25��6g   $
��Left=�6�   $	��Top=�6�   5      �� 5      $��NameSurname��6   $	 500��6*   $	 125��6<   ���	#FF483461
�������$	��100��6w   $��25��6�   �� 5      $��	Book Name��6   $	 270��6(   $	 125��6:   ���	#FF483461
�������$	��100��6u   $��25��6�   �� 5      -   5         ��Name$ cmb_EscrowBook��5      $	 375��6/   $	 125��6A   $	��100��6R   $��25��6^     ComboBoxFlatStyle#���  6j   $��Center=�6�   $	��Top=�6�   5       (  "System.Windows.Controls.DatePicker  5"      -   5          Name$ dp_EscrowDate��5"      $	 375��60   $	 275��6B   $	��100��6S   $��25��6_   $��0,0,0,1q�6k   ���	#FF134187
�������$
��Left=�6�   $	��Top=�6�   �� 5#      $��Escrow Date��6   $	 270��6*   $	 275��6<   ���	#FF483461
�������$	��100��6w   $��25��6�   $��Center=�6�   $	��Top=�6�   �� 5$      $��Return Date��6   $	 500��6*   $	 275��6<   ���	#FF483461
�������$	��100��6w   $��25��6�   $��Center=�6�   $	��Top=�6�   �� 5&      -   5        $ cmb_EscrowUserNameSurname��5&      $	 605��6:   $	 125��6L   $	��100��6]   $��25��6i   #���  6u   $��Center=�6�   $	��Top=�6�   5'        5)      -   5        $ dp_ReturnDate��5)      $	 605��60   $	 275��6B   $	��100��6S   $��25��6_   $��0,0,0,1q�6k   ���	#FF134187
�������$
��Left=�6�   $	��Top=�6�   �� 5+      $��/book.picture.png��6   $	��163��6/   $	 745��6<   $	 116��6N   $	��100��6_   $��Center=�6k   $	��Top=�6�   �� 50      -   5         ��Name$ btn_EscrowBookCancel��50   |   $��30��6   $��40��6!   $	 880��6,   $ 50��6>   $ 5��6N   $��X��6_   
���  �� � ToolTip$ Close��6�   $
��Left=�6�   $	��Top=�6�   51      52      53      
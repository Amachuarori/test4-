   M S B A M L   `   `   `  ����@  <test4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:test4test4  5   	       test4.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:test4     5   	     � Title$  
MainWindow��5   	   $	��300��6   $	��500��6)    � 
ResizeMode$ NoResize=�65    � 	Resources 5	       �� 
TargetType �� Property �� Value��%T   '��       �� 5
   
   " ��6   .�5      ��  � ��
 �����6+   5      5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ 
CheckPanel��5      $��0��6)   
�������.+�5      �  � ColumnDefinitions 5      �� 5      $��30 �6'   �� 5      $	��100 �6'   �� 5      $��20 �6'   �� 5      $	��100 �6'   �� 5      $��20 �6'   �� 5      $	��100 �6'   .+�5"      �� -   5        	 ��Name$	 Pending��5"   ,   $��0��6   $��0��6=   $��10 0 0 0q�6F   �� 5#      $��1��6   $��Pending��6,   �� 5$      -   5        $	 Jeopardy��5$   ,   $��2��6   $��0��6>   �� 5%      $��3��6   $��Jeopardy��6,   �� 5&      -   5        $	 	Completed��5&   ,   $��4��6   $��0��6?   �� 5'      $��5��6   $��	Completed��6,   5(      5)      �� 5+   
   -   5        
 ��Name$
 myScroll��5+      $��1��6+   
�������$��Visible=�5,      $
��Auto=�5-      .��5.      � -   5        $��myGrid��5.      50      51      56      57      
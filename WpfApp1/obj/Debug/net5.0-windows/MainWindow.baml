   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  Calculadora��5   	   $	��460��6   $	��360��6*   $	��460��66   $	��360��6F    � 	Resources 5
         RoundedButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius��%�   &	        �� 5      " ��6'   .�5      ��  � �� 5   
   �� 5      " ��6   .R�5      �� $ 8��6   #��z��6&   #��z��6P   $��1q�6|   ._�5      �� $��Center=�6!   $��Center=�6>   5      5      5   	   5      5      .��5      � -   5         �Name$ GridCalculadora��5   	   ���	#FF252525 � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $��* �6   �� 5"      $��* �6   �� 5#      $��* �6   	 � ColumnDefinitions	 5'   
   �� 5(      $��* �6   �� 5)      $��* �6   �� 5*      $��* �6   �� 5+      $��* �6   .+�5-   
   �� -   5        
 ��Name$
 equalButton��5-      #��[  6&   $��=��6R   $��Stretch=�6^   $��1q�6|   $��Stretch=�6�   $��3��6�   $��6��6�   ���	#FFC3C3C3���	#FF63aee0
���   �$��24(�6  6>  �� 5.   
   -   5        $
 colonButton��5.      #��[  6&   $��,��6R   $��Stretch=�6^   $��1q�6|   $��Stretch=�6�   $��2��6�   $��6��6�   ���	#FF575656���	#FF575656
�������$��24(�6  6>  �� 5/   
   -   5        $
 number0Button��5/      #��[  6(   $��0��6T   $��Stretch=�6`   $��1q�6~   $��Stretch=�6�   $��1��6�   $��6��6�   ���	#FF575656���	#FF575656
�������$��24(�6  6@  �� 50   
   -   5        $
 plusOrMinusButton��50      #��[  6,   $	��+/-��6X   $��Stretch=�6f   $��1q�6�   $��Stretch=�6�   $��0��6�   $��6��6�   ���	#FF575656���	#FF575656
�������$��24(�6
  6F  �� 51   
   -   5        $
 
plusButton��51      #��[  6%   $��+��6Q   $��Stretch=�6]   $��1q�6{   $��Stretch=�6�   $��3��6�   $��5��6�   ���	#FF444444���	#FF444444
�������$��24(�6  6>  �� 52   
   -   5        $
 number3Button��52      #��[  6(   $��3��6T   $��Stretch=�6`   $��1q�6~   $��Stretch=�6�   $��2��6�   $��5��6�   ���	#FF575656���	#FF575656
�������$��24(�6  6@  �� 53   
   -   5        $
 number2Button��53      #��[  6(   $��2��6T   $��Stretch=�6`   $��1q�6~   $��Stretch=�6�   $��1��6�   $��5��6�   ���	#FF575656���	#FF575656
�������$��24(�6  6@  �� 54   
   -	   5        $
 number1Button��54      #��[  6(   $��1��6T   $��Stretch=�6`   $��1q�6~   $��Stretch=�6�   $��0��6�   $��5��6�   ���	#FF575656���	#FF575656
�������$��24(�6  6A  �� 55   
   -
   5        $
 minusButton��55      #��[  6&   $��-��6R   $��Stretch=�6^   $��1q�6|   $��Stretch=�6�   $��3��6�   $��4��6�   ���	#FF444444���	#FF444444
�������$��24(�6  6>  �� 56   
   -   5        $
 number6Button��56      #��[  6(   $��6��6T   $��Stretch=�6`   $��1q�6~   $��Stretch=�6�   $��2��6�   $��4��6�   ���	#FF575656���	#FF575656
�������$��24(�6  6@  �� 57   
   -   5        $
 number5Button��57      #��[  6(   $��5��6T   $��Stretch=�6`   $��1q�6~   $��Stretch=�6�   $��1��6�   $��4��6�   ���	#FF575656���	#FF575656
�������$��24(�6  6@  �� 58   
   -   5        $
 number4Button��58      #��[  6(   $��4��6T   $��Stretch=�6`   $��1q�6~   $��Stretch=�6�   $��0��6�   $��4��6�   ���	#FF575656���	#FF575656
�������$��24(�6  6@  �� 59   
   -   5        $
 
multButton��59      #��[  6%   $��x��6Q   $��Stretch=�6]   $��1q�6{   $��Stretch=�6�   $��3��6�   $��3��6�   ���	#FF444444���	#FF444444
�������$��24(�6  6=  �� 5:   
   -   5        $
 number9Button��5:      #��[  6(   $��9��6T   $��Stretch=�6`   $��1q�6~   $��Stretch=�6�   $��2��6�   $��3��6�   ���	#FF575656���	#FF575656
�������$��24(�6  6@  �� 5;   
   -   5        $
 number8Button��5;      #��[  6(   $��8��6T   $��Stretch=�6`   $��1q�6~   $��Stretch=�6�   $��1��6�   $��3��6�   ���	#FF575656���	#FF575656
�������$��24(�6  6@  �� 5<   
   -   5        $
 number7Button��5<      #��[  6(   $��7��6T   $��Stretch=�6`   $��1q�6~   $��Stretch=�6�   $��0��6�   $��3��6�   ���	#FF575656���	#FF575656
�������$��24(�6  6@  �� 5=   
   -   5        $
 	divButton��5=      #��[  6$   $��÷��6P   $��Stretch=�6\   $��1q�6z   $��Stretch=�6�   $��3��6�   $��2��6�   ���	#FF444444���	#FF444444
�������$��24(�6   6<  �� 5>   
   -   5        $
 
sqrtButton��5>      #��[  6%   $
��√x��6Q   $��Stretch=�6^   $��1q�6|   $��Stretch=�6�   $��2��6�   $��2��6�   ���	#FF444444���	#FF444444
�������$��24(�6  6>  �� 5?   
   -   5        $
 	powButton��5?      #��[  6$   $	��x²��6P   $��Stretch=�6]   $��1q�6{   $��Stretch=�6�   $��1��6�   $��2��6�   ���	#FF444444���	#FF444444
�������$��24(�6  6=  �� 5@   
   -   5        $
 
fracButton��5@      #��[  6%   $��½��6Q   $��Stretch=�6]   $��1q�6{   $��Stretch=�6�   $��0��6�   $��2��6�   ���	#FF444444���	#FF444444
�������$��24(�6  6=  �� 5A   
   -   5        $
 
backButton��5A      #��[  6%   $	��⌫��6Q   $��Stretch=�6]   $��1q�6{   $��Stretch=�6�   $��3��6�   $��1��6�   ���	#FF444444���	#FF444444
�������$��24(�6  6=  �� 5B   
   -   5        $
 cButton��5B      #��[  6"   $��C��6N   $��Stretch=�6Z   $��1q�6x   $��Stretch=�6�   $��2��6�   $��1��6�   ���	#FF444444���	#FF444444
�������$��24(�6�   6:  �� 5C   
   -   5        $
 ceButton��5C      #��[  6#   $��CE��6O   $��Stretch=�6\   $��1q�6z   $��Stretch=�6�   $��1��6�   $��1��6�   ���	#FF444444���	#FF444444
�������$��24(�6   6<  �� 5D   
   -   5        $
 percentButton��5D      #��[  6(   $��%��6T   $��Stretch=�6`   $��1q�6~   $��Stretch=�6�   $��0��6�   $��1��6�   ���	#FF444444���	#FF444444
�������$��24(�6  6@  �� 5E   
   -   5         ��Name$ Display��5E   $    �� 
IsReadOnly$
 True��6   $��0��65   $��Right=�6>   $��5q�6Z   $��Stretch=�6e   $
��Auto��6�   $��40(�6�   $
��Auto��6�   $��0��6�   $��4��6�   $��0��6�   
�������$��Normal"�6�   $��Normal$�6  ��6  Z� ��6+  Z� 5G      5H      
   M S B A M L   `   `   `  ����K  GBestProgram4Ever, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:BestProgram4Ever.UserControlsBestProgram4Ever.UserControls  5      4    .BestProgram4Ever.UserControls.ChartListControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:BestProgram4Ever.UserControls     5        � 	Resources  5	         ScrollBarTrackThumb �� 
TargetType �� Property �� Value �� 
TargetType �Name ��Name �� CornerRadius �� Triggers	 P� Property
 P� Value �� 
TargetName J� Opacity � RowDefinitions ]�Name ]� Thumb n�Name ]� IncreaseRepeatButton ��Name ]� DecreaseRepeatButton��%  &	        '�� �    �� 5   
   " n�5   	   .�5      ��  � �� 5      �� 5      " n�6&   .R�5      � $
 Grid��6   .+�5      �� $��Stretch=�6(   $��Stretch=�5   !   $
��Auto��5   !   $
��Auto��5   !   
������ 5   !   �� 5      $ CornerScrollBarRectangle��6%   $ 5��5      $��Stretch=�5      $��Stretch=�5      $
��Auto��5      $
��Auto��5      $��0,1,0,1q�5      #��z��5      5       5      P� 5       	 �@�Tag$
 
Horizontal��5!   !   . �5"   "   �� $ CornerScrollBarRectangle��6)    � ��$
 Auto��5$   !   �� 5%   "   $ CornerScrollBarRectangle��6)    � ��$ 6��5'   !   5(      5*      5,      5-      �� 5.   
   " ��6   .�5/      ��  �@��IsFlicksEnabled .  50      �� 51       � �� �#ADABAB52      �� 53       � ��
 ���� 54      �� 55       � ��$ 7��56      �� 57       � �� 58      �� 59      " ��6&   .R�5:      � $ GridRoot��6   $	 0.5Q�61   $	��100��5;      #��z��5<       5=      �� 5>   "   $��0.00001* �60   .+�5@      ]� $ 
PART_Track��6$   $��0��5A      ��. |�.   5D   "   n� 5E   &   $ Thumb��6,   #��z��5F   %   #���   5G   %    5I   "   �� 5J   &   $ PageUp��63   $��ScrollBar.PageDownCommand��5K   -   $ 0Q�5L   -   |�.  5M   -    5O   "   �� 5P   &   $ PageDown��63   $��ScrollBar.PageUpCommand��5Q   -   $ 0Q�5R   -   |�.  5S   -   5U      5V      5X      5Z      5[      5\      .��5]      � .+�5^   
   �� -   5        $��	namesList��5^      $��54(�6#   $7��1/BestProgram4Ever;component/Fonts/#Final Frontier)�5_      
������ $��0q�5c      ���#F5F5F5$y�Visible=�5e      ��5`      �� *History.processNames+ �� SelectedItem 5a      �� *SelectedStr+ �� Mode$ OneWayToSource=�5e      �� 5f   
   -   5        $��	datesList��5f      $��54(�6#   $7��1/BestProgram4Ever;component/Fonts/#Final Frontier)�5g      
������ $��0q�5k      ���#F5F5F5$y�Hidden=�5m      ��5h      �� *History.processDates+ 5i      �� *SelectedStr+$ OneWayToSource=�5m      5o      5p      
   M S B A M L   `   `   `  ���� K  GBestProgram4Ever, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:BestProgram4Ever.UserControlsBestProgram4Ever.UserControls  7    1BestProgram4Ever.UserControls.SettingsListControl   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     =local+clr-namespace:BestProgram4Ever.UserControls       � 	Resources     CheckBoxStyle �� 
TargetType �� Property �� Value  MyFocusVisualStyte �� 
TargetType �� Bullet � ShowGridLines �� RelativeSource �� Path	 �� UpdateSourceTrigger
 � ColumnDefinitions � RowDefinitions �� CornerRadius �� Stretch J� Opacity'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard �� TargetProperty �� 
TargetName g� Duration	 W� To �� Triggers P� Property P� Value �� 
TargetName  ScrollBarTrackThumb �Name ��Name ]�Name ]� Thumb n�Name ]� IncreaseRepeatButton  ��Name! ]� DecreaseRepeatButton��%�
  &	        &	 �    '�� $	    �� " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � ��$ 30����  �@�FocusVisualStyle# �  ��  � �� �� " ��.R���  � #��z��$��30��$��30�� .  ����  �� *Self+$ Height�$	 PropertyChanged=�
 �� $��4* ��� $��1* ��� $��1* ��� $��4* ��� $��1* ��� $��1* ��� $��2* ��� $��2* � �� $��3* ��� $��1* ��� $��1* ��� $��1* ��� $��4* ��� $��1* ��� $��1* ��� $��4* �.+��� $��
MainBorder��$��9��$��9��$ 4��$��1q�
������ �� $��InnerBorder��$��1��$��5��$��2��$��5��$��1q����#808080F� $��	InnerPath��$��1��$��5��$��2��$��5��4������@KL ���)@KL ���)��)Ѡm��)ѠmpJ� 	$
 Fill=����#808080F� $��	CheckMark��$��2��$��5��$��1��$��5��$ 0Q�����0  `~C>\�E@�t���@wS+L+�!@�t���@wS+L+�!@����S0@Z8�Cge�����S0@Z8�Cge�/�*��,@$��A���t���@DF���E@�G �@�p���?	���#3babe3$
 Fill=����#3babe3F� $��InderminateMark��$��3��$��4��+����     	= �@B @KL �@KL @B � 	=     	$ 0Q�$
 Fill=�$��0�����#808080   CheckStates��.   Checked��. �� .��W� $ Opacity�$ 	CheckMark��$ 0:0:0.2D�$ 1X�  	Unchecked��. �� .��W� $ Opacity�$ 	CheckMark��$ 0:0:0.2D�$ 0X�  Indeterminate��. �� .��W� $ Opacity�$ InderminateMark��$ 0:0:0.2D�$ 1X�._��� $��4,0,4,0q�$��Center=�$
��Left=���.  P�  �@d�	IsChecked$
 TrueY�. ��� $ InnerBorder�� � y�$ 	Collapsed=�P�  � �� . . ��� $ 
MainBorder�� � �� �#81d2ebP�  � {� .  . ��� $ 	CheckMark�� � �� �#cccccc�� $ 	CheckMark�� � �� �#cccccc�� $ 	InnerPath�� � �� �#cccccc�� $ InderminateMark�� � �� �#cccccc�� $ InnerBorder�� � �� �#cccccc�� " n�.���  � �� �� " n�.R�� $
 Grid��.+��� $��Stretch=�$��Stretch=�$
��Auto��$
��Auto��
������ �� $ CornerScrollBarRectangle��$ 5��$��Stretch=�$��Stretch=�$
��Auto��$
��Auto��$��0,1,0,1q�#��z�� P�  �@�Tag$ 
Horizontal��. ��� $ CornerScrollBarRectangle�� � ��$
 Auto���� $ CornerScrollBarRectangle�� � ��$ 6���� " ��.���  �@��IsFlicksEnabled .  ��  � �� �#ADABAB��  � ��
 ���� ��  � ��$ 7����  � �� �� " ��.R�� $ GridRoot��$	 0.5Q�$	��100��#��z�� �� $��0.00001* �.+�]� $ 
PART_Track��$��0����. |�.   n� $ Thumb��#��z��#���   �� $  PageUp��$��ScrollBar.PageDownCommand��$ 0Q�|�.  ! �� $  PageDown��$��ScrollBar.PageUpCommand��$ 0Q�|�.  .��� .+��� -   $��settingsList��$��84(�$7��1/BestProgram4Ever;component/Fonts/#Final Frontier)�
������ $��0q����� *ProcessEntitiesCollection+���� " ��.���  � |� .  ���� .R��� #��[  $	��100�����#F5F5F5���� *ProcessName+" d� 	IsChecked" �� *Hidden+
   M S B A M L   `   `   `  ���� J  FDiplomacyOrders, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DiplomacyOrdersDiplomacyOrders      DiplomacyOrders.App   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     /localclr-namespace:DiplomacyOrders       �� 	Resources     ToggleSwitchStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius A�Name �� Triggers	 P� Property
 P� Value �� 
TargetName N� EnterActions �� 
TargetName g� Duration �� TargetProperty W� From	 W� To W� EasingFunction2  ,System.Windows.Media.Animation.QuadraticEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode N� ExitActions T� X ��Name  StandardBorderBrush �� Color  StandardBackgroundBrush  HoverBorderBrush  SelectedBackgroundBrush  SelectedForegroundBrush  DisabledForegroundBrush  
GlyphBrush  NormalBrush 	 NormalBorderBrush 
 HorizontalNormalBrush  HorizontalNormalBorderBrush  ScrollBarLineButton �� Path �� RelativeSource  PressedBrush  ScrollBarPageButton  ScrollBarThumb  ScrollBarThumbHor  VerticalScrollBar � RowDefinitions ]� DecreaseRepeatButton ]� Thumb ]� IncreaseRepeatButton  HorizontalScrollBar � ColumnDefinitions �� Triggers  FavsScrollViewer  �� VerticalOffset! � Value" �� ScrollableHeight# � Maximum$ �� ViewportHeight% �� ViewportSize*& �� #ComputedVerticalScrollBarVisibility' �� Orientation( �� HorizontalOffset) �� ScrollableWidth* �� ViewportWidth,+ �� %ComputedHorizontalScrollBarVisibility, ��Name��%/  &	        '�� �    &	 �    &	 �    &	 �    &	 �    &	 �    &	      &	     &	 #    &		 6    &	
 I    &	 \    &	 o    7  7 	 7  7  7  &	 "    &	 	    &	 �	    &	 �
    7  7  7  7 
 7  7  7  &	 �    7  7  7  7 
 7  7  7  '�� \    7  7  &	 �    '�� �    �� " d�.���  � ��$ 50����  � ��$ 25����  � ��$
 Left=���  � ��$ 	19,15,0,0q���  � �� �� " d�.R�� .+��� $ BackgroundBorder��$
 12.5�����#DDDDDDA� $ 
SwitchKnob��$��23��$��23�����#DDDDDD���#DDDDDD$��1��z�T� KnobTransform�� P� 	 �@d�	IsChecked$

 TrueY�. ��� $ BackgroundBorder�� � �� �#2e2c6d�� $ 
SwitchKnob�� � �� �#DDDDDD �� .���� .��W� $ 
SwitchKnob��$ 0:0:0.25D�$ RenderTransform.X� -12 12   $ EaseOut=� �� .���� .��W� $ 
SwitchKnob��$ 0:0:0.25D�$ RenderTransform.X� 12 -12   $ EaseOut=�P� 	 �@d�	IsChecked$
 FalseY�. ��� $ BackgroundBorder�� � �� �#4e3e90�� $ 
SwitchKnob�� � z� T� $	 -12Q�P� 	 �@J�IsMouseOver$

 True��. ��� $ 
SwitchKnob�� � �� �#DDDDDDP� 	 � ��$

 True��. ��� $ 
SwitchKnob�� � �� �#BBBBBB�� " ��.���  � �� �#1E2B47��  � ��
 �������  � ��$ 15(���  � ��$ 10q���  � ��$ 5q���  �@J�SnapsToDevicePixels$
 True����  � �� �� " ��.R��� $ 10��#��z��._��� $ MyContentPresenter��#��z��$��Center=�$��Center=�$��0,0,0,0q� P� 	 �@J�IsMouseOver$

 True��. ���  � �� �#0F1626��  � ��
 �����P� 	 � ��$

 True��. ���  � ��
 �OO/���  � ��
 ������� $ #2e2c6d���� $ Black���� $
 #DDD���� $
 Gray���� $ White���� $ #2e2c6d���� $
 #444���� $ #2e2c6d���� $ #2e2c6d���� $ #2e2c6d���� $ #2e2c6d���� " ��.���  � y�$ Hidden=���  �@J�SnapsToDevicePixels$
 True����  �@�OverridesDefaultStyle$
 true����  � |�$ false����  � �� �� " ��.R��� $��Border��$��1q�$ 2��8��  8�� $��1q�._�F� $��Center=�$��Center=�8�� ���� $ Content� �� *TemplatedParent+ P� 	 � ��$

 true��. ��� $ Border��8   � ��P� 	 � {�$
 false��. ��� 8   � ���� " ��.���  � y�$ Hidden=���  �@J�SnapsToDevicePixels$
 True����  �@�OverridesDefaultStyle$
 true����  � ��$ false����  � |�$ false����  � �� �� " ��.R��� 
���   ��� " n�.���  �@J�SnapsToDevicePixels$
 True����  �@�OverridesDefaultStyle$
 true����  � ��$ false����  � |�$ false����  � �� �� " n�.R��� $ 4��#��z��#��z��$��0q�$��8��$��8,0,-2,0q��� " n�.���  �@J�SnapsToDevicePixels$
 True����  �@�OverridesDefaultStyle$
 true����  � ��$ false����  � |�$ false����  � �� �� " n�.R��� $ 4��#��z��#��z��$��0q�$��8��$��0,0,-2,0q��� " ��.R��  �� $��0���� $��0.00001* ��� $��0��.+��� $��3��$ 2��
������ �� $��0��8��  $��18��$��ScrollBar.LineUpCommand��$��M 0 4 L 8 4 L 4 0 Z��]� $��
PART_Track��$��1��$
��true�� �� 8�� $��ScrollBar.PageUpCommand�� n� 8�� $��1,0,1,0q�8�� 8��  �� 8�� $��ScrollBar.PageDownCommand���� $��3��8�� $��18��$��ScrollBar.LineDownCommand��$��M 0 0 L 4 4 L 8 0 Z���� " ��.R��  �� $��0 ��� $��0.00001* ��� $��0 �.+��� $��3��$ 3��
������ �� $��0��8��  $��18��$��ScrollBar.LineLeftCommand��$��M 4 0 L 4 8 L 0 4 Z��]� $��
PART_Track��$��1��$��False�� �� 8�� $��ScrollBar.PageLeftCommand�� n� 8�� $��0,1,0,1q�8�� 8��  �� 8�� $ ��ScrollBar.PageRightCommand���� $��3��8�� $��18��$ ��ScrollBar.LineRightCommand��$��M 0 0 L 4 4 L 0 8 Z���� " ��.���  �@J�SnapsToDevicePixels$
 True����  �@�OverridesDefaultStyle$
 true�� P� 	 �@��Orientation$
 
Horizontal=�. ���  � ��$
 Auto����  � ��$ 12����  � ��8   P� 	 �@��Orientation$
 Vertical=�. ���  � ��$ 18����  � ��$
 Auto����  � ��8  �� " ��.���  �@�OverridesDefaultStyle$
 True����  � �� �� " ��.R��  �� $
��Auto ���  �� �� $
��Auto �.+��� $��1���� $��PART_VerticalScrollBar��#! z  ## z" #% z$ #y�z& �� $��PART_HorizontalScrollBar��$' 
Horizontal=�$��1��$��1��#! z( ## z) #% z* #y�z+ �� " ��.���  � �� �� " ��.R��  �� �� $
��Auto � �� �� $
��Auto �.+��� $��0���� $, PART_VerticalScrollBar��$��0��$��1��#! z  ## z" #% z$ #y�z& �� $, PART_HorizontalScrollBar��$' 
Horizontal=�$��1��$��0��#! z( ## z) #% z* #y�z+ 
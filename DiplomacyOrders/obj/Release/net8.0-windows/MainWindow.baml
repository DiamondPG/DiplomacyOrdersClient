   M S B A M L   `   `   `  ���� J  FDiplomacyOrders, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DiplomacyOrdersDiplomacyOrders       DiplomacyOrders.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:DiplomacyOrders       � Title$  
MainWindow��$	��480��$	��800��
������  � WindowStyle$
 None=� � AllowsTransparency$
 True�� � Icon$ /assets/images/icon.png�� � 
ResizeMode$ 	CanResize=� � WindowStartupLocation$ CenterScreen=� � 	Resources  
  TabBTN �� 
TargetType �� Property	 �� Value
 �� Triggers P� Property P� Value��%�   &	        �� " ��.���  � ��$	 24(���  � ��$	 Center=���  � ��
	 ���� ��  � ��
	 ���� 
 P�  �@J�IsMouseOver$
 True��. ���  � ��	 �#266CA8.���� ���#547aa5 �� CornerRadius$ 10��._��  � RowDefinitions �� $��40 ��� .+��� -   ���#4f5165$ 	10,10,0,0��._��  � ColumnDefinitions �� $��40 ��� �� �� �� �� $	��150 �.+�� $��5�� �� �� �� .+��� -    ��Name$ CloseBTN��$��2��.���� $"��/assets/images/close_btn.png���� -   $ MinimizeBTN��$��1��.���� $%��/assets/images/minimize_btn.png���� $��/assets/images/icon.png��$��5q�� $��1�� �� $	��200 ��� .+��� $ 0,0,0,10�����#5587ac._��  �� �� �� �� �� �� �� �� .+��� -   #��[  .��� $	��196��.+��� $"��/assets/images/home_icon.png��$
��Left=��� $
��Home��$��Right=�$��Center=�$��5q��� -   #��[  $��1��.��� $	��196��.+��� $!��/assets/images/map_icon.png��$
��Left=��� $��View Map��$��Right=�$��Center=�$��5q��� -   #��[  $��2��.��� $	��196��.+��� $+��%/assets/images/submit_orders_icon.png��$
��Left=��� $��Orders��$��Right=�$��Center=�$��5q��� -   #��[  $��3��.��� $	��196��.+��� $!��/assets/images/info_btn.png��$
��Left=��� $��Status��$��Right=�$��Center=�$��5q��� -    ��Name$ Content��$��1��
   M S B A M L   `   `   `  ���� J  FDiplomacyOrders, Version=0.1.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:DiplomacyOrders.assets.screensDiplomacyOrders.assets.screens  +    %DiplomacyOrders.assets.screens.Status   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     >local,clr-namespace:DiplomacyOrders.assets.screens     .��� .+��� $��Status of Orders��
�������$��28(�  �� TextAlignment$  Center=��� -    ��Name$ CountriesPanel������ .R�� $	��600�� � Orientation$ 
Horizontal=�$��Center=�$��Center=����� .R���  ��Name$
 Card��$��Center=�$��Center=� �� CornerRadius$ 10��$��5q� �� Padding$ 5q����#1f1f1f$	��100��$	��150��._��� $��5q�.+��� $��20(�
�������$  Center=����� *Name+�� $
 Pill��$ 5q�$��0,5,0,0q�$ 10��$��Bottom=�._���  ��Name$ PillText��$��14(�$  Center=�$��Center=�$��Center=� �� Triggers ��  �� Value$ false��	 �� Binding	 �� *Ready+.a��� 
 �� 
TargetName$

 Pill�� �� Property � �� �� Value �	#FFC50000�� $
 PillText�� � ��$ 	Not Ready���� $
 PillText�� � ��
 ������� $
 true��	 �� *Ready+.a��� $

 Pill�� � ��
 � � ��� $
 PillText�� � ��$ Ready���� $
 PillText�� � ��
 �   �
   M S B A M L   `   `   `  ����J  FDiplomacyOrders, Version=0.1.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:DiplomacyOrders.assets.screensDiplomacyOrders.assets.screens  5      +    %DiplomacyOrders.assets.screens.Status   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:DiplomacyOrders.assets.screens     5      .��5	      � .+�5
   
   �� $��Status of Orders��6   
�������$��28(�6?     �� TextAlignment$  Center=�6M   �� 5   
   -   5         ��Name$ CountriesPanel��5      ��5      �� 5      .R�5      � $	��600��6     � Orientation$ 
Horizontal=�6/   $��Center=�6H   $��Center=�6e   5      ��5      �� 5      .R�5      ��  ��Name$
 Card��6   $��Center=�6+   $��Center=�6H    �� CornerRadius$ 10��6c   $��5q�6u    �� Padding$ 5q�6�   ���#1f1f1f$	��100��6�   $	��150��6�   ._�5      �� $��5q�6%   .+�5      �� $��20(�6>   
�������$  Center=�6_   ��6(   �� *Name+6_   �� 5      $
 Pill��6%   $ 5q�63   $��0,5,0,0q�6?   $ 10��6P   $��Bottom=�6b   ._�5   "   ��  ��Name$ PillText��6,   $��14(�6>   $  Center=�6L   $��Center=�6c   $��Center=�6�   5      5      5       �� Triggers 5      �� 5       �� Value$ false��6@   	 �� Binding	 6&   �� *Ready+.a�5      �� 
 �� 
TargetName$

 Pill��6%    �� Property � �� �� Value �	#FFC500006M   �� 5      $
 PillText��6%    � ��$ 	Not Ready��6K   �� 5      $
 PillText��6%    � ��
 �����6Q   5       �� 5!      $
 true��6@   	 6&   �� *Ready+.a�5"      �� $

 Pill��6%    � ��
 � � �6M   �� 5#      $
 PillText��6%    � ��$ Ready��6K   �� 5$      $
 PillText��6%    � ��
 �   �6Q   5%      5'      5*      5+      5,      
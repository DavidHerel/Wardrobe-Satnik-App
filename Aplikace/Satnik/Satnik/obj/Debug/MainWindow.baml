   M S B A M L   `   `   `  ����A  =Satnik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SatnikSatnik  5   	   5clr-namespace:Satnik.ViewModelsSatnik.ViewModels  5   	       Satnik.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Satnik     5   	   2local1clr-namespace:Satnik.ViewModels     5   	     � Title$  
MainWindow��5	   	   $��498.731��6   $��499.324��6-    � 
ResizeMode$ NoResize=�6=    � 	Resources 5
      %   Satnik.ViewModels.MainViewModel   	ViewModel��%   &	          5   
   6   5      .��5      ]�  � DataContext# [  6   .+�5   
   �  5        boolConverter��%   &	       �� 5      6/   5       � RowDefinitions 5      �� 5      $	��65* �6    �� 5      $
��394* �6    .+�5      �� 
���   �
�������$��1q�6;   $
��Left=�6O   $��64��6j   $	��Top=�6v   $	��495��6�   ._�5      �� $��Můj šatník��6   $��35(�6-   $
��Bold"�6;   $��151.2,-0.8,149.4,1.2q�6M   
�������6k   5      �� 5      $��1��6   $��0,0.2,387.2,0.4q�6&    5        Flag �� 
TargetType �� Triggers P� Property P� Value	 �� Property
 �� Value �� 
TargetType �� CornerRadius �� Path �� RelativeSource��%�  &	       �� 5      " 	�6)    5       P� 5!       �@d�	IsChecked$ FalseY�6;   . �5"   "   �� 	 �@J�Opacity$	
 0.5Q�6<   5#      .�5&      �� 	 � ��$
 2q�6<   �� 5(      	 � ��
 5)      �� 5*   "   " 	�62   .R�5+   &   �� #��z��6-   #��z��5,   !   
������ $ 20��5.   !   ._�5/   *   �� ��60   �� $ Content� �� *TemplatedParent+50   '   51   #   53      54      55      .+�56      �� $��	0,0,0.8,0q�6   $	��395��62   .@�57      	� -   5         	�Name$ toggleMe��57   G   $ ��../Images/ic_home_24px.png��6"   #��[ 6Y   $��69��6w   	� 58      -   5        $ 	toggleMe2��58   J   $#��../Images/casual-t-shirt-.png��6"    d� 	IsChecked$
 TrueY�6]   #��[ 6n   $��69��6�   5:      5;      � 5<      $��106,2.6,-0.2,-0.2q�6   $��1��6.   y�6;   ��  �� ElementName$ toggleMe��$ 	IsChecked� �� 	Converter# [ .+�5>      �� $��Dnešní outfit��6   $
��Left=�60   $��25(�6K   $
��Bold"�6Y   $��	10,10,0,0q�6k   $	��Top=�6~   �� 5?      $��Další outfit��6   $��25(�6V   $
��Bold"�6d   $
��Left=�6v   $��105,331,0,0q�6�   $	��Top=�6�   $	��187��6�   
�������$��46��6�   ��60   �� *DalsiOutfitButton+6�   �� 5@      $
��Left=�62   $	��119��6M   $��	58,70,0,0q�6Z   $	��Top=�6m   $	��115��6�   ��6   �� *sakoVM+6�   �� 5A      $
��Left=�65   $	��119��6P   $��
197,70,0,0q�6]   $	��Top=�6q   $	��115��6�   ��6   �� *	kalhotyVM+6�   �� 5B      $
��Left=�64   $	��119��6O   $��
58,204,0,0q�6\   $	��Top=�6p   $	��115��6�   ��6   �� *
trickoVM+6�   �� 5C      $
��Left=�62   $	��119��6M   $��197,204,0,0q�6Z   $	��Top=�6o   $	��115��6�   ��6   �� *botyVM+6�   5D      � 5F      $��106,2.6,-0.2,-0.2q�6   $��1��6.   y�6;   �� $ 	toggleMe2��$ 	IsChecked�# [ .+�5G      �� -   5        $��pocetObleceni��5G      $
��Left=�6O   $��20(�6j   $
��Bold"�6x   $��	10,10,0,0q�6�   $	��Top=�6�   ��6-   �� *PocetObleceni+6�   �� 5H      $��Přidat další��6@   $��25(�6W   $
��Bold"�6e   $
��Left=�6w   $��105,331,0,0q�6�   $	��Top=�6�   $	��187��6�   
�������$��46��6�   ��6   �� *NoveObleceniButton+6�   �� 5I      $��10,58,10,97q�6@   ��6   �� *ObleceniCards+��5J      �� 5K      .R�5L      � $	��400��6(   5M      ��5O      �� 5P      .R�5Q      �� .+�5R   "   "  Satnik.ObleceniCustomControl  $��80��5W   5      DruhObleceni 5R   >   �� *Druh+ �� Mode$ TwoWay=�   Barva 5S   5   �� *Barva+$ TwoWay=�   	Kategorie 5T   5   �� *	Kategorie+$ TwoWay=�   Icon 5U   5   �� *Icon+$ TwoWay=�   RemoveCommand 5V   5   �� *
DeleteCity+5X   #   5Y      5Z      5\      5]      5_      5`      5c      
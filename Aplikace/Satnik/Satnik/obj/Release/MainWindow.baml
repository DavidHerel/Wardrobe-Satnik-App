   M S B A M L   `   `   `  ���� A  =Satnik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SatnikSatnik  5clr-namespace:Satnik.ViewModelsSatnik.ViewModels      Satnik.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     &localclr-namespace:Satnik     2local1clr-namespace:Satnik.ViewModels       � Title$  
MainWindow��$��498.731��$��499.324�� � 	Resources %   Satnik.ViewModels.MainViewModel   	ViewModel��%   &	          .��]�  � DataContext# [  .+��    boolConverter��%   &	       ��  � RowDefinitions �� $	��65* ��� $
��394* �.+��� 
���   �
�������$��1q�$
��Left=�$��64��$	��Top=�$	��495��._��� $��Můj šatník��$��35(�$
��Bold"�$��151.2,-0.8,149.4,1.2q�
��������� $��1��$��0,0.2,387.2,0.4q�   Flag �� 
TargetType �� Triggers P� Property P� Value �� Property	 �� Value
 �� 
TargetType �� CornerRadius �� Path �� RelativeSource��%�   &	       �� " 	� P�  �@d�	IsChecked$ FalseY�. ���  �@J�Opacity$		 0.5Q�.���  � ��$	 2q���  � ��	 �� "
 	�.R��� #��z��#��z��
������ $ 20��._��� ���� $ Content� �� *TemplatedParent+.+��� $��	0,0,0.8,0q�$	��395��.@�	� -    	�Name$ toggleMe��$ ��../Images/ic_home_24px.png�� d� 	IsChecked$
 TrueY�#��[ $��69��	� -   $ 	toggleMe2��$#��../Images/casual-t-shirt-.png��#��[ $��69��� $��106,2.6,-0.2,-0.2q�$��1��y���  �� ElementName$ toggleMe��$ 	IsChecked� �� 	Converter# [ .+��� $��Dnešní outfit��$
��Left=�$��25(�$
��Bold"�$��	10,10,0,0q�$	��Top=��� $��Další outfit��$��25(�$
��Bold"�$
��Left=�$��105,331,0,0q�$	��Top=�$	��187��
�������$��46������ *DalsiOutfitButton+�� $
��Left=�$	��119��$��	58,70,0,0q�$	��Top=�$	��115������ *sakoVM+�� $
��Left=�$	��119��$��
197,70,0,0q�$	��Top=�$	��115������ *	kalhotyVM+�� $
��Left=�$	��119��$��
58,204,0,0q�$	��Top=�$	��115������ *
trickoVM+�� $
��Left=�$	��119��$��197,204,0,0q�$	��Top=�$	��115������ *botyVM+� $��106,2.6,-0.2,-0.2q�$��1��y��� $ 	toggleMe2��$ 	IsChecked�# [ .+��� -   $��pocetObleceni��$
��Left=�$��20(�$
��Bold"�$��	10,10,0,0q�$	��Top=����� *PocetObleceni+�� $��Přidat další��$��25(�$
��Bold"�$
��Left=�$��105,331,0,0q�$	��Top=�$	��187��
�������$��46������ *NoveObleceniButton+�� $��10,58,10,97q����� *ObleceniCards+���� .R�� $	��400������ .R��� .+�"  Satnik.ObleceniCustomControl  $��80��   DruhObleceni �� *Druh+ �� Mode$ TwoWay=�   Barva �� *Barva+$ TwoWay=�   	Kategorie �� *	Kategorie+$ TwoWay=�   Icon �� *Icon+$ TwoWay=�   RemoveCommand �� *
DeleteCity+
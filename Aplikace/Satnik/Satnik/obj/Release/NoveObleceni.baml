   M S B A M L   `   `   `  ���� A  =Satnik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SatnikSatnik      Satnik.NoveObleceni   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     &localclr-namespace:Satnik       � Title$  NoveObleceni��$��690.377��$��421.769��.���  � RowDefinitions �� $	��22* ��� $	��51* �.+��� -    ��Name$ OkButton��$��Ok��$
��Left=�$��89,406.8,0,0q�$	��Top=�$	��105��$��1��$��40���� -   $ StornoButton��$��Storno��$
��Left=�$��222,406.8,0,0q�$	��Top=�$	��104��$��1��$��40���� $��1q����	#FF000000$��89,10,73.2,402.8q�$��2��._��� -    ��Name$ ObleceniImage��$
��Left=�$	��232��$��5.2,5.2,0,0q�$	��Top=�$	��237���� -   $ ObleceniButton��$��Přidat obrázek��$
��Left=�$��156,63.8,0,0q�$	��Top=�$	��119��$��1��$��32���� $��1��$��-72,228.8,73.2,53.8q� J� RenderTransformOrigin$ 0.5,0.5&� � 	Resources    Flag �� 
TargetType �� Triggers P� Property	 P� Value
 �� Property �� Value �� 
TargetType �� CornerRadius �� Path �� RelativeSource��%�   &	        �� " 	� P�  �@d�	IsChecked$	 FalseY�. ��� 
 �@J�Opacity$	 0.5Q�.��� 
 � ��$ 2q��� 
 � �� �� " 	�.R��� #��z��#��z��
������ $ 20��._��� ���� $ Content� �� *TemplatedParent+z�V� .~��� �� ��  �� Angle$ 0.096Q�T� .+�� $��73��$	��500��$��2,0,-88.4,0q�.+�	�  d� 	IsChecked$
 TrueY�$��30��$��30��$��../Images/Ellipse 18.png��#��[  $��94,5,376,38q�	� $��30��$��30��$��91,5,289,38q�$��../Images/Ellipse 19.png��#��[  	� $��30��$��30��$��177,5,293,38q�$��../Images/Ellipse 20.png��#��[  	� $��30��$��30��$��218,5,252,38q�$��../Images/Ellipse 21.png��#��[  	� $��30��$��30��$��212,4,168,36q�$��../Images/Ellipse 22.png��#��[  	� $��30��$��30��$��297,5,173,38q�$��../Images/Ellipse 23.png��#��[  	� $��30��$��30��$��297,4,83,36q�$��../Images/Ellipse 24.png��#��[  $ 0.346,0.533&�	� $��30��$��30��$��49,40,331,3q�$��../Images/Ellipse 25.png��#��[  	� $��30��$��30��$��91,40,289,3q�$��../Images/Ellipse 26.png��#��[  	� $��30��$��30��$��177,40,293,3q�$��../Images/Ellipse 27.png��#��[  	� $��30��$��30��$��218,40,252,3q�$��../Images/Ellipse 28.png��#��[  	� $��30��$��30��$��212,39,168,1q�$��../Images/Ellipse 29.png��#��[  	� $��30��$��30��$��297,40,173,3q�$��../Images/Ellipse 30.png��#��[  	� $��30��$��30��$��297,39,83,1q�$��../Images/Ellipse 31.png��#��[  �� $��Barva oblečení:��$
��Bold"�$
��Left=�$��19,201.8,0,0q�$��1��$	��Top=��� $��Druh oblečení:��$
��Bold"�$
��Left=�$��19,101.8,0,0q�$��1��$	��Top=�� $��10,132.8,-9.8,264.8q�$��1��.+�	� -    	�Name$ Tricko��$
 TrueY�$��Tričko��$
��Left=�$��	10,10,0,0q�$	��Top=�	� -   $ Kosile��$��Košile��$
��Left=�$��	73,10,0,0q�$	��Top=�	� -   $ Mikina��$��Mikina��$
��Left=�$��
138,10,0,0q�$	��Top=�	� -   $ Svetr��$��Svetr��$
��Left=�$��
203,10,0,0q�$	��Top=�	� -	   $
 Sako��$
��Sako��$
��Left=�$��
260,10,0,0q�$	��Top=�	� -
   $ Kabat��$��Kabát��$
��Left=�$��
316,10,0,0q�$	��Top=�	� -   $ Bunda��$��Bunda��$
��Left=�$��	10,33,0,0q�$	��Top=�	� -   $ Kalhoty��$��Kalhoty��$
��Left=�$��	73,33,0,0q�$	��Top=�	� -   $ Kratasy��$��Kraťasy��$
��Left=�$��
138,33,0,0q�$	��Top=�	� -   $ Sukne��$��Sukně��$
��Left=�$��
203,33,0,0q�$	��Top=�	� -   $
 Boty��$
��Boty��$
��Left=�$��
260,33,0,0q�$	��Top=�	� -   $ Doplnky��$��Doplňky��$
��Left=�$��
316,33,0,0q�$	��Top=��� $��Kategorie oblečení:��$
��Bold"�$
��Left=�$��19,318.8,0,0q�$��1��$	��Top=�� $��0,344.8,-9.8,44.8q�$��1��.+�	� $
 TrueY�$��Neformální��$
��Left=�$��	25,10,0,0q�$	��Top=�	� $��
Formální��$
��Left=�$��
123,10,0,0q�$	��Top=�
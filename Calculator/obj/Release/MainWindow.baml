   M S B A M L   `   `   `  ���� E  ACalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Calculator
Calculator      Calculator.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:Calculator       � Title$  
Calculator��$	��450��$	��280�����#2e3137 � Icon$ Calculator.ico�� � 	Resources  �� 
TargetType   baseBtn �� Property �� Value �� 
TargetType �� Padding �� Triggers	 P� Property
 P� Value :� RoutedEvent �� TargetProperty	 �� To g� Duration  
numericBtn �� BasedOn  operationButton��%R  &	        &	 �    7   &	     7   �� " �����  � ��
 �������  � �� �#545d6a��  � ��$ Segoe UI Symbol)���  � ��$ 16(���  � �� �� " ��.R��� #��z��#��z��#��z��#��z��# z��._��� $��Center=�$��Center=� P� 	 �@J�IsMouseOver
 . . ���  � ��
 �iii���  � �� �#2e3137:� $ Click��.[��� .���� .���� $ Background.Color�$ 	LightGrayX�$ 0:0:0.25D��� $ Background.Color�$ DimGrayX�$ 0:0:0.25D��� " ��8   .���  � �� �#2e3137�� " ��8   .���  � ��$ 25(�.���  � ColumnDefinitions �� $��0* ��� �� �� ��  � RowDefinitions �� �� �� �� �� �� .+��� -    ��Name$
 Btn7��#��[ $��2��$��0��$��2��.��7�� -   $
 Btn8��#��[ $��2��$��2��.��8�� -   $
 Btn9��#��[ $��2��$��3��.��9�� -   $
 Btn4��#��[ $��3��$��0��$��2��.��4�� -   $
 Btn5��#��[ $��3��$��2��.��5�� -   $
 Btn6��#��[ $��3��$��3��.��6�� -   $
 Btn1��#��[ $��4��$��0��$��2��.��1�� -   $
 Btn2��#��[ $��4��$��2��.��2�� -	   $
 Btn3��#��[ $��4��$��3��.��3�� -
   $
 Btn0��#��[ $��5��$��2��.��0�� -   $ BtnPlus��#��[ $��1��$��4��.��+�� -   $ BtnMinus��#��[ $��2��$��4��.��-�� -   $ BtnMul��#��[ $��3��$��4��.��×�� -   $ BtnDiv��#��[ $��4��$��4��.��÷�� -   $ 	BtnEquals��#��[ $��5��$��4��.��=�� -   $ BtnColon��#��[ $��5��$��3��$��,���� -   $ BtnCE��#��[  $��1��$��0��$��2��.��CE�� -   $
 BtnC��#��[  $��1��$��2��.��C�� -   $ BtnBackspace��#��[  $��1��$��3��$	������ -   $ BtnPositiveNegative��#��[ $��5��$��0��$��2��.��+-�� -    ��Name$ 	lblShowUp��
�������$��0��$��0��$	��Top=�$��5��$��Right=��� -    ��Name$ 
txtDisplay��
����������#2e3137 �� 
IsReadOnly .  �� TextAlignment$ Right=�$��30(�$��0q�$��0��$��0��$��5��$��40��$��Bottom=�.��0
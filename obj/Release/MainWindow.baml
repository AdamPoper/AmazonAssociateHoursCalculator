   M S B A M L   `   `   `  ���� R  NEmployeeHoursCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:EmployeeHoursCalculatorEmployeeHoursCalculator  (    "EmployeeHoursCalculator.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     7local%clr-namespace:EmployeeHoursCalculator       � Title$  Attrition Calculator��$	��480��$	��640��.���� .+�� -   $��MainGrid�� � ColumnDefinitions �� $��350px ��� $��350px � � RowDefinitions �� $
��60px ��� $
��60px ��� $
��60px ��� $
��60px ��� $
��60px ��� $
��60px �.+��� -   $��AssociatesLeftFirstLabel�����#CDCDCD$
��20px(�$��0��$��0��#!Associates Left After First Break�� -   $��HoursLostFirstLabel��$
��20px(�$��1��$��0��Hours Lost After First Break�� -   $��AssociatesLeftSecondLabel�����#CDCDCD$
��20px(�$��2��$��0��$"Associates Left After Second Break�� -   $��HoursLostSecondLabel��$
��20px(�$��3��$��0��Hours Lost After Second Break�� -   $��TotalHoursLostLabel�����#CDCDCD$
��20px(�$��4��$��0��Total Hours Lost�� -   $#��associatesLeftFirstValueLabel�����#CDCDCD$
��20px(�$��0��$��1��$
��Bold"�0�� -   $��hoursLostFirstValueLabel��$
��20px(�$��1��$��1��$
��Bold"�0�� -	   $$��associatesLeftSecondValueLabel�����#CDCDCD$
��20px(�$��2��$��1��$
��Bold"�0�� -
   $��hoursLostSecondValueLabel��$
��20px(�$��3��$��1��$
��Bold"�0�� -   $��totalHoursLostValueLabel�����#CDCDCD$
��20px(�$��4��$��1��$
��Bold"�0��  �� Orientation$ 
Horizontal=�.+��� -   $��openFileButt��$��100px��$
��50px��$��50, 0, 30, 0q�.��Open Excel File�� -   $��manLabel��$��Center=�.��Manager Names�� -   $��manBox��$��100px��$
��30px��
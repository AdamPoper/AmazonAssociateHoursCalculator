   M S B A M L   `   `   `  ����R  NEmployeeHoursCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:EmployeeHoursCalculatorEmployeeHoursCalculator  5   	   (    "EmployeeHoursCalculator.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:EmployeeHoursCalculator     5   	     � Title$  
MainWindow��5   	   $	��480��6   $	��640��6)   .��5	      � -   5        $��MainGrid��5	       � ColumnDefinitions 5
   
   �� 5      $��350px �6   �� 5      $��350px �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5        $��AssociatesLeftFirstLabel��5   %   $
��20px(�6   $��0��6E   $��0��6R   #!Associates Left After First Break6�   �� 5   
   -   5        $��HoursLostFirstLabel��5   %   $
��20px(�6   $��1��6@   $��0��6M   Hours Lost After First Break6{   �� 5   
   -   5        $��AssociatesLeftSecondLabel��5   %   $
��20px(�6   $��2��6F   $��0��6S   $"Associates Left After Second Break6�   �� 5   
   -   5        $��HoursLostSecondLabel��5   %   $
��20px(�6   $��3��6A   $��0��6N   Hours Lost After Second Break6}   �� 5   
   -   5        $��TotalHoursLostLabel��5   %   $
��20px(�6   $��4��6@   $��0��6M   Total Hours Lost6o   �� 5   
   -   5        $#��associatesLeftFirstValueLabel��5   $   $
��20px(�6   $��0��6I   $��1��6V   06i   �� 5   
   -   5        $��hoursLostFirstValueLabel��5   $   $
��20px(�6   $��1��6D   $��1��6Q   06d   �� 5   
   -	   5        $$��associatesLeftSecondValueLabel��5   $   $
��20px(�6   $��2��6J   $��1��6W   06j   �� 5   
   -
   5        $��hoursLostSecondValueLabel��5   $   $
��20px(�6   $��3��6E   $��1��6R   06e   �� 5    
   -   5        $��totalHoursLostValueLabel��5    $   $
��20px(�6   $��4��6D   $��1��6Q   06d   �� 5"   
   -   5        $��fileButt��5"      $��0��6!   $��5��61   $��150px��6>   $
��50px��6L   .��6q   Open Excel File6�   5#      5$      
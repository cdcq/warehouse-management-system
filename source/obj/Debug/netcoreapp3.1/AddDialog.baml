   M S B A M L   `   `   `  ����V  Rwarehouse-management-system, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:warehouse_management_systemwarehouse_management_system  5   	   +    %warehouse_management_system.AddDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:warehouse_management_system     5   	     � Title$  添加物品��5   	   $	��200��6   $	��400��6#   .��5	      � $��5q�6    � ColumnDefinitions 5
   
   �� 5      $��40 �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   $��0��6    .��6-   名称61   �� 5   
   -   5         ��Name$ nameBox��5      $��1��6#   $��0��63   $��5q�6@   5      �� 5   
   $��0��6   $��1��6    .��6-   数量61   �� 5   
   -   5        $ countBox��5      $��1��6$   $��1��64   $��5q�6A   5      �� 5   
   $��0��6   $��2��6    .��6-   价值61   �� 5   
   -   5        $ worthBox��5      $��1��6$   $��2��64   $��5q�6A   5      �� 5   
   $��0��6   $��3��6    .��6-   属性61   �� 5   
   -   5        $ propertyBox��5      $��1��6'   $��3��67   $��5q�6D   5       �� 5!   
   $��1��6   $��2��6%   $��4��69    �� Orientation$ 
Horizontal=�5"      $��Right=�6.   .+�5#      �� -   5        $��okButton��5#       �� 	IsDefault$
 True��6<   $��20��5$      $��40��6!   $��5,0,5,0q�6,   .��6=   确认6A   �� 5%      -   5        $��canceButton��5%       �� IsCancel$
 True��6(   $��20��5&      $��40��6!   $��5,0,5,0q�6,   .��6=   取消6A   5'      5(      5)      
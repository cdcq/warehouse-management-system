   M S B A M L   `   `   `  ����V  Rwarehouse-management-system, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:warehouse_management_systemwarehouse_management_system  5   	   ,    &warehouse_management_system.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:warehouse_management_system     5   	     � Title$  仓库管理系统��5   	   $	��495��6   $	��800��6%   .��5	      � .+�5
   
   ]� .+�5      o� $	��Top=�6   .@�5      m� $��
文件(_F)��6   $��25��6+   .@�5      m� -   5        $��
新建(_N)��5      6G   m� 5      -   5        $��
打开(_O)��5      6H   �� 5      6"   m� 5      -   5        $��
退出(_E)��5      6D   5      m� 5      $��
物品(_I)��6   .@�5      m� -   5        $��添加物品(_A)��5      61   m� 5      -   5        $��移除物品(_R)��5      61   �� 5      m� 5      -   5        $��
入库(_I)��5      6/   m� 5      -   5        $��
出库(_O)��5      6/   5      m� 5      $��
查看(_W)��6   .@�5      m� -   5        $��查看属性(_P)��5      61   5      m� 5      $��
统计(_S)��6   .@�5      m� -	   5        $��基本统计(_B)��5      61   m� 5      -
   5        $��历史统计(_H)��5      61   5      m� 5       $��
帮助(_H)��6   .@�5!      m� -   5        $��请查看使用文档��5!      60   5"      5#      � 5$      $��Right=�6   .+�5%      �� $��	工具栏��6   $��5q�6(   .��5&      �� .+�5'      �� -   5        
�������$��5q�5'   4    � ToolTip$ 添加��5(   7   .��5)      �� $��resource\icons\add.png��6$   $��30��5*   $   5+      �� 5,      -   5        
�������$��5q�5,   4   $ 移除��5-   6   .��5.      �� $��resource\icons\remove.png��6$   $��30��5/   $   50      �� 51      -   5        
�������$��5q�51   4   $ 入库��52   5   .��53      �� $��resource\icons\input.png��6$   $��30��54       55      �� 56      -   5        
�������$��5q�56   4   $ 出库��57   6   .��58      �� $��resource\icons\output.png��6$   $��30��59       5:      �� 5;      -   5        
�������$��5q�5;   4   $ 查找��5<   6   .��5=      �� $��resource\icons\search.png��6$   $��30��5>       5?      �� 5D      -   5        
�������$��5q�5D   4   $ 统计��5E   9   .��5F      �� $"��resource\icons\statistic.png��6$   $��30��5G       5H      �� 5I      -   5        
�������$��5q�5I   4   $ 历史��5J   7   .��5K      �� $ ��resource\icons\history.png��6$   $��30��5L   $   5M      5N      5O      5P      �� 5Q      $��5q�6   $	��Top=�6"   $��20��67   .��5R      �� -   5         ��Name$ nameBox��5R      6/   5S      � 5T      .+�5U      �� -   5         ��Name$ itemList��5U      $��5q�6-    �� View 5V      �� 5W      P�5X      �� 5Y   "   $��名称��61    �� Width$	 100��6=    �� DisplayMemberBinding 5Z   1   ��  �� Path$
 Name��� 5[   "   $��数量��61   $ 50��6=    5\   1   �� $ Count��� 5]   "   $��价值��61   $	 100��6=    5^   1   �� $ Worth��� 5_   "   $��属性��61   $	 400��6=    5`   1   �� $ 
Properties�5b      5d      5e      5f      5g      5h      
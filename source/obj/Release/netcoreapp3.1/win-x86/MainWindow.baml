   M S B A M L   `   `   `  ���� V  Rwarehouse-management-system, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:warehouse_management_systemwarehouse_management_system  ,    &warehouse_management_system.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ;local)clr-namespace:warehouse_management_system       � Title$  仓库管理系统��$	��495��$	��800��.��� .+�]� .+�o� $	��Top=�.@�m� $��
文件(_F)��$��25��.@�m� -   $��
新建(_N)��m� -   $��
打开(_O)���� m� -   $��
退出(_E)��m� $��
物品(_I)��.@�m� -   $��添加物品(_A)��m� -   $��移除物品(_R)���� m� -   $��
入库(_I)��m� -   $��
出库(_O)��m� $��
查看(_W)��.@�m� -   $��查看属性(_P)��m� $��
统计(_S)��.@�m� -	   $��基本统计(_B)��m� -
   $��历史统计(_H)��m� $��
帮助(_H)��� $��Right=�.+��� $��	工具栏��$��5q�.���� .+��� -   
�������$��5q� � ToolTip$ 添加��.���� $��resource\icons\add.png��$��30���� -   
�������$��5q�$ 移除��.���� $��resource\icons\remove.png��$��30���� -   
�������$��5q�$ 入库��.���� $��resource\icons\input.png��$��30���� -   
�������$��5q�$ 出库��.���� $��resource\icons\output.png��$��30���� -   
�������$��5q�$ 查找��.���� $��resource\icons\search.png��$��30���� -   
�������$��5q�$ 统计��.���� $"��resource\icons\statistic.png��$��30���� -   
�������$��5q�$ 历史��.���� $ ��resource\icons\history.png��$��30���� $��5q�$	��Top=�$��20��.���� -    ��Name$ nameBox��� .+��� -    ��Name$ itemList��$��5q� �� View �� P��� $��名称�� �� Width$	 100�� �� DisplayMemberBinding ��  �� Path$
 Name��� $��数量��$ 50�� �� $ Count��� $��价值��$	 100�� �� $ Worth��� $��属性��$	 400�� �� $ 
Properties�
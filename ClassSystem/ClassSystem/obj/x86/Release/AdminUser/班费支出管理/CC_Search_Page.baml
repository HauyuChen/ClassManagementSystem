   M S B A M L   `   `   `  ����   ClassSystem=    7ClassSystem.AdminUser.班费支出管理.CC_Search_Page   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008       N� Title$  CC_Search_Page��.��� .+�&   System.Windows.Controls.DataGrid  -     Name$ 	datagrid1��$
��Left=�$	��Top=�$	��200��$	��563��   AutoGenerateColumns .  $��	12,83,0,0q�����    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 使用时间��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
CostTime+  $ 使用项目�� �� *
CostProj+  $ 使用地点�� �� *	CostPlace+  $ 参加人数�� �� *	JoinNum+  $ 原始班费�� �� *OCost+  $ 消费金额�� �� *	CostSum+  $ 剩余班费�� �� *RCost+�� -   $��	TB_SI_Sno��$��23��$��Right=�$��
0,48,295,0q�$	��Top=�$	��104���� -   $��label1��$-��'请输入你要查询的时间记录：��$��28��$
��Left=�$��	12,46,0,0q�$	��Top=��� -   $��BTN_CC_Search��$��查询��$��23��$��Right=�$��
0,48,206,0q�$	��Top=�$��75���� -   $��label2��$��班费支出记录��$��31��$
��Left=�$��	253,9,0,0q�$	��Top=�$��18(�$
��Bold"��� -   $��label3��$��记录次数：��$��28��$
��Left=�$��292,336,0,0q�$	��Top=��� -   $��label4��$��剩余班费：��$��28��$
��Left=�$��
47,333,0,0q�$	��Top=��� -   $��TB_RCOST��$��23��$
��Left=�$��118,335,0,0q�$	��Top=�$��81���� -	   $��TB_ATY��$��23��$��Right=�$��0,338,117,0q�$	��Top=�$	��120���� -
   $��label5��$	��元��$��28��$
��Left=�$��201,333,0,0q�$	��Top=�
   M S B A M L   `   `   `  ����   ClassSystem!    ClassSystem.CCostDetailPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008       N� Title$  CCostDetailPage��.��� .+�&   System.Windows.Controls.DataGrid  -     Name$ 	datagrid1��$
��Left=�$	��Top=�$	��200��$	��563��   AutoGenerateColumns .  $��	12,83,0,0q�����    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 使用时间��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
CostTime+  $ 使用项目�� �� *
CostProj+  $ 使用地点�� �� *	CostPlace+  $ 参加人数�� �� *	JoinNum+  $ 原始班费�� �� *OCost+  $ 消费金额�� �� *	CostSum+  $ 剩余班费�� �� *RCost+�� -   $��TB_CC��$��23��$
��Left=�$��	78,48,0,0q�$	��Top=�$	��104���� -   $��label1��$��使用时间：��$��28��$
��Left=�$��	12,46,0,0q�$	��Top=�$��70���� -   $��BTN_CC_Search��$��查询��$��23��$
��Left=�$��
201,47,0,0q�$	��Top=�$��75���� -   $��label2��$��班费支出查询��$��34��$
��Left=�$��	225,4,0,0q�$	��Top=�$��20(�$
��Bold"��� -   $��label3��$��记录次数：��$��28��$
��Left=�$��292,336,0,0q�$	��Top=��� -   $��label4��$��剩余班费：��$��28��$
��Left=�$��
47,333,0,0q�$	��Top=��� -   $��TB_RCOST��$��23��$
��Left=�$��118,335,0,0q�$	��Top=�$��64���� -	   $��TB_ATY��$��23��$
��Left=�$��361,335,0,0q�$	��Top=�$��43���� -
   $��label5��$	��元��$��28��$
��Left=�$��186,333,0,0q�$	��Top=��� -   $��label6��$	��次��$��28��$
��Left=�$��408,333,0,0q�$	��Top=�
   M S B A M L   `   `   `  ����  ClassSystem=    7ClassSystem.AdminUser.班费支出管理.CC_Search_Page   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  CC_Search_Page��5      .��5
      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	datagrid1��5      $
��Left=�6>   $	��Top=�6Y   $	��200��6q   $	��563��6~      AutoGenerateColumns .  $��	12,83,0,0q�6�   ��6&   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 使用时间��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *
CostTime+  5      $ 使用项目��6%    64   �� *
CostProj+  5      $ 使用地点��6%    64   �� *	CostPlace+  5      $ 参加人数��6%    64   �� *	JoinNum+  5      $ 原始班费��6%    64   �� *OCost+  5      $ 消费金额��6%    64   �� *	CostSum+  5      $ 剩余班费��6%    64   �� *RCost+5      �� 5   
   -   5        $��	TB_SI_Sno��5   N   $��23��6   $��Right=�6   $��
0,48,295,0q�6:   $	��Top=�6_   $	��104��6w   �� 5   
   -   5        $��label1��5   b   $-��'请输入你要查询的时间记录：��6   $��28��6(   $
��Left=�64   $��	12,46,0,0q�6O   $	��Top=�6p   �� 5   
   -   5        $��BTN_CC_Search��5   Z   $��查询��6   $��23��6   $��Right=�6*   $��
0,48,206,0q�6F   $	��Top=�6o   $��75��6�   6�   �� 5   
   -   5        $��label2��5   [   $��班费支出记录��6   $��31��6!   $
��Left=�6-   $��	253,9,0,0q�6H   $	��Top=�6i   $��18(�6�   $
��Bold"�6�   �� 5   
   -   5        $��label3��5   \   $��记录次数：��6   $��28��6    $
��Left=�6,   $��292,336,0,0q�6G   $	��Top=�6j   �� 5   
   -   5        $��label4��5   [   $��剩余班费：��6   $��28��6    $
��Left=�6,   $��
47,333,0,0q�6G   $	��Top=�6i   �� 5   
   -   5        $��TB_RCOST��5   N   $��23��6   $
��Left=�6   $��118,335,0,0q�69   $	��Top=�6^   $��81��6v   �� 5   
   -	   5        $��TB_ATY��5   O   $��23��6   $��Right=�6   $��0,338,117,0q�6:   $	��Top=�6]   $	��120��6u   �� 5   
   -
   5        $��label5��5   X   $	��元��6   $��28��6   $
��Left=�6(   $��201,333,0,0q�6C   $	��Top=�6f   5      5       
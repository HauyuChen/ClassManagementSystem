   M S B A M L   `   `   `  ����  ClassSystem!    ClassSystem.CCourseInfoPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  CCourseInfoPage��5      .��5
      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	datagrid1��5      $
��Left=�6>   $	��Top=�6Y   $	��309��6q   $	��563��6~      AutoGenerateColumns .  $��	12,83,0,0q�6�   ��6&   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 课程编号��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Cno+  5      $ 课程名称��6%    64   �� *Cname+  5      $ 任课教师��6%    64   �� *
Cteacher+  5      $ 课程学分��6%    64   �� *	Ccredit+  5      $ 上课时间��6%    64   �� *Ctime+  5      $ 上课地点��6%    64   �� *Cplace+5      �� 5   
   -   5        $��TB_CI��5   N   $��23��6   $��Right=�6   $��
0,48,263,0q�6:   $	��Top=�6[   $	��104��6s   �� 5   
   -   5        $��label1��5   f   $9��3请输入你要查询课程编号或课程名称：��6   $��28��6,   $
��Left=�68   $��	12,46,0,0q�6S   $	��Top=�6t   $	��213��6�   �� 5   
   -   5        $��BTN_CI_Search��5   Z   $��查询��6   $��23��6   $��Right=�6*   $��
0,48,159,0q�6F   $	��Top=�6o   $��75��6�   6�   �� 5   
   -   5        $��label2��5   [   $��课程信息查询��6   $��34��6!   $
��Left=�6-   $��	225,4,0,0q�6H   $	��Top=�6i   $��20(�6�   $
��Bold"�6�   5      5      
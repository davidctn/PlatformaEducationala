   M S B A M L   `   `   `  ����P  LPlatformaEducationala, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:PlatformaEducationala.ViewsPlatformaEducationala.Views  5   	   S.clr-namespace:PlatformaEducationala.ViewModels PlatformaEducationala.ViewModels  5   	   S.clr-namespace:PlatformaEducationala.Converters PlatformaEducationala.Converters  5   	   /    )PlatformaEducationala.Views.CoursesWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:PlatformaEducationala.Views     5   	   >ctx.clr-namespace:PlatformaEducationala.ViewModels     5   	   Cconvert1.clr-namespace:PlatformaEducationala.Converters     5   	     � Title$  CoursesWindow��5
   	    � 
ResizeMode$ NoResize=�5   	   ���#181235$	��306��5   	   $	��436��5   	    � DataContext 5      /  )PlatformaEducationala.ViewModels.CourseVM  5   
    � 	Resources 5      6  0PlatformaEducationala.Converters.CourseConverter   courseConvert��%   &	          5   
   6<   5      .��5      � $��518,0,0,165q�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��coursesGrid��5      $��-210,0,90,-168q�6'      AutoGenerateColumns .     
IsReadOnly . $��Visible=�5      ��5      �� *CoursesList+ �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 61   �� *Id+  5      $ 
CourseName��6%   	 69   �� *
CourseName+5      �� 5    
   -   5        
 ��Name$
 DeleteCourseButton��5!      $��Sterge��5"      
���   �$��16(�5$      $��Medium"�5%      $��Fonts/#Dosis)�5&      $y�Visible=�5'      $��-365,0,260,-48q�5(      $��50��6)   $��Bottom=�65   ��5)      ��  �� ElementName$ coursesGrid�� �� Path$ SelectedItem���5*      �� *DeleteCourseCommand+��5+      �� 5,       �� 
TargetType" ��6   .�5-      ��  �� Property � �� �� Value$ Fonts/#Dosis)�6?   �� 5.       � �� �#FE658463   �� 5/       �@�Cursor$
 Hand��6/    �� Triggers 50      P� 51       P� Property �@J�IsMouseOver P� Value . . �53      ��  � ��
 �� ��6;   54      56      ��58      �� 59       �� 
TargetType" ��6"   .R�5:      �� $��90��6    �� CornerRadius$ 12��5;   !   #��z��5<   !   ._�5=      �� $��Center=�6+   $��Center=�5>   /   5?      5@      5B      �� 5D   
   -   5        $
 AddCourseButton��5E      $��Adauga��5F      
���   �$��16(�5H      $��Medium"�5I      $��Fonts/#Dosis)�5J      $y�Visible=�5K      $��-510,110,0,-48q�5L      $
��Left=�6$   $��90��6?   ��5S      �� 5T      " ��6   .�5U      ��  � ��$ Fonts/#Dosis)�6?   �� 5V       � �� �#FE658463   �� 5W       �@�Cursor$
 Hand��6/    5X      P� 5Y       �@J�IsMouseOver . . �5[      ��  � ��
 �� ��6;   5\      5^      ��5`      �� 5a      " ��6"   .R�5b      �� $��90��6   $ 12��5c   !   #��z��5d   !   ._�5e      �� $��Center=�6+   $��Center=�5f   /   5g      5h      5j      �� 5l   
   -   5        $
 ModifyCourseButton��5m      $��Modifica��5n      
���   �$��16(�5p      $��Medium"�5q      $��Fonts/#Dosis)�5r      $y�Visible=�5s      $��-425,180,330,-113q�5t      ��5v      �� *ModifyCourseCommand+��5w      �� $ coursesGrid��$ SelectedItem���5z      �� 5{      " ��6   .�5|      ��  � ��$ Fonts/#Dosis)�6?   �� 5}       � �� �#FE658463   �� 5~       �@�Cursor$
 Hand��6/    5      P� 5�       �@J�IsMouseOver . . �5�      ��  � ��
 �� ��6;   5�      5�      ��5�      �� 5�      " ��6"   .R�5�      �� $��90��6   $ 12��5�   !   #��z��5�   !   ._�5�      �� $��Center=�6+   $��Center=�5�   /   5�      5�      5�      �� 5�   
   -   5         ��Name$ CourseNameInput��5�      $
��Left=�6+   $��30��6F   $��-510,50,0,0q�6R    �� TextWrapping$
 Wrap=�6g   $	��Top=�5�   U   $	��225��6m   ��5�   {   �� $ coursesGrid��$ SelectedItem.CourseName�$ PropertyChanged=�5�   m   �� 5�   
   $��Course Name��6   $
��Left=�6'   $��-510,10,0,0q�6B   $	��Top=�6W   
�������$��20(�6�   $��35��6�   $	��160��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   5�      5�      
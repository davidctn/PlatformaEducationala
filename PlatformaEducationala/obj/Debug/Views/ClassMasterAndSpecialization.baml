   M S B A M L   `   `   `  ����P  LPlatformaEducationala, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:PlatformaEducationala.ViewsPlatformaEducationala.Views  5   	   S.clr-namespace:PlatformaEducationala.ViewModels PlatformaEducationala.ViewModels  5   	   >    8PlatformaEducationala.Views.ClassMasterAndSpecialization   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:PlatformaEducationala.Views     5   	   ?ctx1.clr-namespace:PlatformaEducationala.ViewModels     5   	     � Title$"  ClassMasterAndSpecialization��5	   	   $	��466��6.   $	��800��6;    � 
ResizeMode$ NoResize=�5
   	   ���#181235 � DataContext 5      .  (PlatformaEducationala.ViewModels.ClassVM  5   
   .��5      � .+�5      &   System.Windows.Controls.DataGrid  -   5        $
��Grid��5      $��
521,0,-6,5q�6      AutoGenerateColumns .     
IsReadOnly . $��Visible=�5      ��5      �� *ClassesListDB+   Columns 5   
   0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6!   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *Id+  5      $ 	ClassName��6!    64   �� *	ClassName+  5      $ Specialization��6!    69   �� *Specialization+  5      $ ClassMaster��6!    66   �� *ClassMaster+5      �� 5   
   -   5         ��Name$ AddClassMasterButton��5      $��Adauga diriginte��5      
���   �$��16(�5       $��Medium"�5!      $��Fonts/#Dosis)�5"      $y�Visible=�5#      $��25,10,579,376q�5$      	 J� RenderTransformOrigin$	 
0.524,-0.6&�5&   V   ��5%      �� *AddClassMasterCommand+��5&      �� 
 �� ElementName$

 Grid�� �� Path$ SelectedItem���5(      �� 5)       �� 
TargetType" ��6   .�5*      ��  �� Property � �� �� Value$ Fonts/#Dosis)�6?   �� 5+       � �� �#FE658463   �� 5,       �@�Cursor$
 Hand��6/    �� Triggers 5-      P� 5.       P� Property �@J�IsMouseOver P� Value . . �50      ��  � ��
 �� ��6;   51      53      ��55      �� 56       �� 
TargetType" ��6"   .R�57      �� $	��150��6    �� CornerRadius$ 12��58   !   #��z��59   !   ._�5:      �� $��Center=�6+   $��Center=�5;   /   5<      5=      5?      �� 5@   
   -   5        $ AddSpecializationButton��5A      $��Adauga specializare��5B      
���   �$��16(�5D      $��Medium"�5E      $��Fonts/#Dosis)�5F      $y�Visible=�5G      $��25,85,579,301q�5H      $	 	0.619,3.2&�5J   V   ��5I      �� *AddSpecializationCommand+��5J      �� $

 Grid��$ SelectedItem���5L      �� 5M      " ��6   .�5N      ��  � ��$ Fonts/#Dosis)�6?   �� 5O       � �� �#FE658463   �� 5P       �@�Cursor$
 Hand��6/    5Q      P� 5R       �@J�IsMouseOver . . �5T      ��  � ��
 �� ��6;   5U      5W      ��5Y      �� 5Z      " ��6"   .R�5[      �� $	��160��6   $ 12��5\   !   #��z��5]   !   ._�5^      �� $��Center=�6+   $��Center=�5_   /   5`      5a      5c      �� 5d   
   -   5         ��Name$ SpecializationInput��5d      $
��Left=�6/   $��30��6J   $��235,106,0,0q�6V    �� TextWrapping$
 Wrap=�6k   $	��Top=�5e   Y   $	��225��6q   ��5d      �� $

 Grid��$! SelectedItem.Specialization� �� UpdateSourceTrigger$ PropertyChanged=�5e   q   �� 5g   
   -   5        $ ClassMasterInput��5g      $
��Left=�6,   $��30��6G   $��
235,31,0,0q�6S   $
 Wrap=�6g   $	��Top=�5h   V   $	��225��6n   ��5g   {   �� $

 Grid��$ SelectedItem.ClassMaster�$ PropertyChanged=�5h   n   5i      5k      
   M S B A M L   `   `   `  ����P  LPlatformaEducationala, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:PlatformaEducationala.ViewsPlatformaEducationala.Views  5   	   S.clr-namespace:PlatformaEducationala.ViewModels PlatformaEducationala.ViewModels  6A   �Oclr-namespace:PlatformaEducationala.Converters.PlatformaEducationala.ConvertersAPlatformaEducationala.Converters.PlatformaEducationala.Converters  5   	   9    3PlatformaEducationala.Views.ModifyAndDeleteStudents   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:PlatformaEducationala.Views     5   	   >ctx.clr-namespace:PlatformaEducationala.ViewModels     6A   dconvert1Oclr-namespace:PlatformaEducationala.Converters.PlatformaEducationala.Converters     5   	     � Title$  ModifyAndDeleteStudents��5
   	   $	��450��6)   $	��800��66    � 
ResizeMode$ NoResize=�5      ���#181235 � DataContext 5      /  )PlatformaEducationala.ViewModels.PersonVM  5   
   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��personsGrid��5      $��225,0,10,10q�6'      AutoGenerateColumns .     
IsReadOnly . $��Visible=�5      ��5      �� *StudentsList+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  5      $ 	FirstName��6%    68   �� *	FirstName+  5      $ LastName��6%    67   �� *
LastName+  5      $ EmailAdress��6%    6:   �� *EmailAddress+  5      $ Password��6%    67   �� *
Password+  5      $ 	ClassName��6%    68   �� *	ClassName+5      �� 5   
   -   5         ��Name$ DeleteStudentButton��5      $��Sterge��5      
���   �$��16(�5!      $��Medium"�5"      $��Fonts/#Dosis)�5#      $y�Visible=�5$      $��45,10,644,376q�5%      	 J� RenderTransformOrigin$	 
0.524,-0.6&�5'   ]   ��5&      �� *DeleteStudentCommand+��5'      �� 
 �� ElementName$
 personsGrid�� �� Path$ SelectedItem���5)      �� 5*       �� 
TargetType" ��6   .�5+      ��  �� Property � �� �� Value$ Fonts/#Dosis)�6?   �� 5,       � �� �#FE658463   �� 5-       �@�Cursor$
 Hand��6/    �� Triggers 5.      P� 5/       P� Property �@J�IsMouseOver P� Value . . �51      ��  � ��
 �� ��6;   52      54      ��56      �� 57       �� 
TargetType" ��6"   .R�58      �� $��90��6    �� CornerRadius$ 12��59   !   #��z��5:   !   ._�5;      �� $��Center=�6+   $��Center=�5<   /   5=      5>      5@      �� 5A   
   -   5        $ ModifyStudentButton��5B      $��Modifica��5C      
���   �$��16(�5E      $��Medium"�5F      $��Fonts/#Dosis)�5G      $y�Visible=�5H      $��45,55,644,331q�5I      $	 	0.619,3.2&�5K   ]   ��5J      �� *ModifyStudentCommand+��5K      �� $
 personsGrid��$ SelectedItem���5M      �� 5N      " ��6   .�5O      ��  � ��$ Fonts/#Dosis)�6?   �� 5P       � �� �#FE658463   �� 5Q       �@�Cursor$
 Hand��6/    5R      P� 5S       �@J�IsMouseOver . . �5U      ��  � ��
 �� ��6;   5V      5X      ��5Z      �� 5[      " ��6"   .R�5\      �� $��90��6   $ 12��5]   !   #��z��5^   !   ._�5_      �� $��Center=�6+   $��Center=�5`   /   5a      5b      5d      �� 5f   
   -   5         ��Name$ FirstNameInput��5f      $
��Left=�6*   $��30��6E   $��	0,140,0,0q�6Q    �� TextWrapping$
 Wrap=�6d   $	��Top=�5g   T   $	��225��6l   ��5f   x   �� $
 personsGrid��$ SelectedItem.FirstName� �� UpdateSourceTrigger$ PropertyChanged=�5g   l   �� 5i   
   -   5        $ LastNameInput��5i      $
��Left=�6)   $��30��6D   $��	0,205,0,0q�6P   $
 Wrap=�6c   $	��Top=�5j   S   $	��225��6k   ��5i   w   �� $
 personsGrid��$ SelectedItem.LastName�$ PropertyChanged=�5j   k   �� 5k   
   -   5        $ EmailAdressInput��5k      $
��Left=�6,   $��30��6G   $��	0,280,0,0q�6S   $
 Wrap=�6f   $	��Top=�5l   W   $	��225��6o   ��5k   z   �� $
 personsGrid��$ SelectedItem.EmailAddress�$ PropertyChanged=�5l   o   �� 5m   
   -   5        $ PasswordInput��5m      $
��Left=�6)   $��30��6D   $��	0,350,0,0q�6P   $
 Wrap=�6c   $	��Top=�5n   S   $	��225��6k   ��5m   w   �� $
 personsGrid��$ SelectedItem.Password�$ PropertyChanged=�.��5n   w   5o      �� 5p   
   $��	FirstName��6   $
��Left=�6%   $��	50,95,0,0q�6@   $	��Top=�6S   
�������$��20(�6~   $��40��6�   6�   �� 5q   
   $��LastName��6   $
��Left=�6$   $��
52,165,0,0q�6?   $	��Top=�6S   
�������$��20(�6~   $��40��6�   6�   �� 5r   
   $��Email Address��6   $
��Left=�6)   $��
50,235,0,0q�6D   $	��Top=�6X   
�������$��20(�6�   $��40��6�   6�   �� 5s   
   $��Password��6   $
��Left=�6$   $��
57,310,0,0q�6?   $	��Top=�6S   
�������$��20(�6~   $��40��6�   6�   5t      5u      
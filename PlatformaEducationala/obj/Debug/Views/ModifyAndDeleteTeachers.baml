   M S B A M L   `   `   `  ����P  LPlatformaEducationala, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:PlatformaEducationala.ViewsPlatformaEducationala.Views  5   	   S.clr-namespace:PlatformaEducationala.ViewModels PlatformaEducationala.ViewModels  6A   9    3PlatformaEducationala.Views.ModifyAndDeleteTeachers   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:PlatformaEducationala.Views     5   	   >ctx.clr-namespace:PlatformaEducationala.ViewModels     6A     � Title$  ModifyAndDeleteTeachers��5   	   $	��450��6)   $	��800��66    � 
ResizeMode$ NoResize=�5	   	   ���#181235 � DataContext 5      /  )PlatformaEducationala.ViewModels.PersonVM  5   
   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��personsGrid��5      $��230,10,10,0q�6'      AutoGenerateColumns .     
IsReadOnly . $��Visible=�5      ��5      �� *TeachersList+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  5      $ 	FirstName��6%    68   �� *	FirstName+  5      $ LastName��6%    67   �� *
LastName+  5      $ EmailAdress��6%    6:   �� *EmailAddress+  5      $ Password��6%    67   �� *
Password+5      �� 5   
   -   5         ��Name$ DeleteTeacherButton��5      $��Sterge��5      
���   �$��16(�5      $��Medium"�5      $��Fonts/#Dosis)�5       $y�Visible=�5!      $��45,10,644,375q�5"      ��5#      �� *DeleteTeacherCommand+��5$      �� 	 �� ElementName$	 personsGrid��
 �� Path$
 SelectedItem���5%      �� 5&       �� 
TargetType" ��6   .�5'      ��  �� Property � �� �� Value$ Fonts/#Dosis)�6?   �� 5(       � �� �#FE658463   �� 5)       �@�Cursor$
 Hand��6/    �� Triggers 5*      P� 5+       P� Property �@J�IsMouseOver P� Value . . �5-      ��  � ��
 �� ��6;   5.      50      ��52      �� 53       �� 
TargetType" ��6"   .R�54      �� $��90��6    �� CornerRadius$ 12��55   !   #��z��56   !   ._�57      �� $��Center=�6+   $��Center=�58   /   59      5:      5<      �� 5=   
   -   5        $ ModifyTeacherButton��5>      $��Modifica��5?      
���   �$��16(�5A      $��Medium"�5B      $��Fonts/#Dosis)�5C      $y�Visible=�5D      $��45,55,644,331q�5E      ��5F      �� *ModifyTeacherCommand+��5G      �� $	 personsGrid��$
 SelectedItem���5I      �� 5J      " ��6   .�5K      ��  � ��$ Fonts/#Dosis)�6?   �� 5L       � �� �#FE658463   �� 5M       �@�Cursor$
 Hand��6/    5N      P� 5O       �@J�IsMouseOver . . �5Q      ��  � ��
 �� ��6;   5R      5T      ��5V      �� 5W      " ��6"   .R�5X      �� $��90��6   $ 12��5Y   !   #��z��5Z   !   ._�5[      �� $��Center=�6+   $��Center=�5\   /   5]      5^      5`      �� 5b   
   -   5         ��Name$ FirstNameInput��5b      $
��Left=�6*   $��30��6E   $��	0,140,0,0q�6Q    �� TextWrapping$
 Wrap=�6d   $	��Top=�5c   T   $	��225��6l   ��5b   x   �� $	 personsGrid��$
 SelectedItem.FirstName� �� UpdateSourceTrigger$ PropertyChanged=�5c   l   �� 5d   
   -   5        $ LastNameInput��5d      $
��Left=�6)   $��30��6D   $��	0,205,0,0q�6P   $
 Wrap=�6c   $	��Top=�5e   S   $	��225��6k   ��5d   w   �� $	 personsGrid��$
 SelectedItem.LastName�$ PropertyChanged=�5e   k   �� 5f   
   -   5        $ EmailAdressInput��5f      $
��Left=�6,   $��30��6G   $��	0,280,0,0q�6S   $
 Wrap=�6f   $	��Top=�5g   W   $	��225��6o   ��5f   z   �� $	 personsGrid��$
 SelectedItem.EmailAddress�$ PropertyChanged=�5g   o   �� 5h   
   -   5        $ PasswordInput��5h      $
��Left=�6)   $��30��6D   $��	0,350,0,0q�6P   $
 Wrap=�6c   $	��Top=�5i   S   $	��225��6k   ��5h   w   �� $	 personsGrid��$
 SelectedItem.Password�$ PropertyChanged=�.��5i   w   5j      �� 5k   
   $��	FirstName��6   $
��Left=�6%   $��	50,95,0,0q�6@   $	��Top=�6S   
�������$��20(�6~   $��40��6�   6�   �� 5l   
   $��LastName��6   $
��Left=�6$   $��
52,165,0,0q�6?   $	��Top=�6S   
�������$��20(�6~   $��40��6�   6�   �� 5m   
   $��Email Address��6   $
��Left=�6)   $��
50,235,0,0q�6D   $	��Top=�6X   
�������$��20(�6�   $��40��6�   6�   �� 5n   
   $��Password��6   $
��Left=�6$   $��
57,310,0,0q�6?   $	��Top=�6S   
�������$��20(�6~   $��40��6�   6�   5o      5p      
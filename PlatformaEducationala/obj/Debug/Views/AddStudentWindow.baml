   M S B A M L   `   `   `  ����P  LPlatformaEducationala, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:PlatformaEducationala.ViewsPlatformaEducationala.Views  5   	   �Oclr-namespace:PlatformaEducationala.Converters.PlatformaEducationala.ConvertersAPlatformaEducationala.Converters.PlatformaEducationala.Converters  5   	   S.clr-namespace:PlatformaEducationala.ViewModels PlatformaEducationala.ViewModels  6j   2    ,PlatformaEducationala.Views.AddStudentWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:PlatformaEducationala.Views     5   	   dconvert1Oclr-namespace:PlatformaEducationala.Converters.PlatformaEducationala.Converters     5   	   >ctx.clr-namespace:PlatformaEducationala.ViewModels     6j     � Title$  AddStudentWindow��5	   	   $	��486��6"   $	��800��6/    � 
ResizeMode$ NoResize=�5
      ���#181235 � DataContext 5      /  )PlatformaEducationala.ViewModels.PersonVM  5   
   .��5      � .+�5   
   �� $��	FirstName��6   $
��Left=�6%   $��
10,127,0,0q�6@   $	��Top=�6T   
�������$��71��5       $	��180��6,   $��30(�5      �� 5   
   $��LastName��6   $
��Left=�6$   $��
10,198,0,0q�6?   $	��Top=�6S   
�������$��71��5       $	��180��6,   $��30(�5      �� 5   
   $��EmailAdress��6   $
��Left=�6'   $��
10,262,0,0q�6B   $	��Top=�6V   
�������$��71��5       $	��205��6,   $��30(�5      �� 5   
   $��Password��6   $
��Left=�6#   $��
10,338,0,0q�6>   $	��Top=�6R   
�������$��71��5       $	��180��6,   $��30(�5      �� 5   
   $��	ClassName��6   $
��Left=�6$   $��10,399,0,-13q�6?   $	��Top=�6U   
�������$��71��5       $	��180��6,   $��30(�5      �� 5   
   -   5         ��Name$ FirstNameInput��5      $
��Left=�6*   $��30��6E   $��195,140,0,0q�6Q    �� TextWrapping$
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��375��6�   �� 5    
   -   5        $ LastNameInput��5       $
��Left=�6)   $��30��6D   $��195,205,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��375��6�   �� 5!   
   -   5        $ EmailAdressInput��5!      $
��Left=�6,   $��30��6G   $��195,280,0,0q�6S   $
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $	��375��6�   �� 5"   
   -   5        $ PasswordInput��5"      $
��Left=�6)   $��30��6D   $��195,350,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��375��6�   �� 5#   
   -   5        $ ClassNameInput��5#      $
��Left=�6*   $��30��6E   $��190,409,0,0q�6Q   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��375��6�   �� 5$   
   $��
-10,0,10,0q�6    � 	Resources 5%      W  QPlatformaEducationala.Converters.PlatformaEducationala.Converters.PersonConverter   personConverter��%   &	          5&      6F   5'      .+�5(      �� -   5         ��Name$ AddStudentButton��5)      $��Adauga��5*      
���   �$��16(�5,      $��Medium"�5-      $��Fonts/#Dosis)�5.      $y�Visible=�5/      $��465,70,224,316q�50      $��35��52       J� RenderTransformOrigin$ 0.5,0.5&�6   ��51      �� *AddStudentCommand+��53      `� 54       `� 	Converter# [  6#   .1�55      �� 	 �� ElementName$	 FirstNameInput��6"   
 �� Path$

 Text�6?   �� 56      $	 LastNameInput��6"   $

 Text�6>   �� 57      $	 EmailAdressInput��6"   $

 Text�6A   �� 58      $	 PasswordInput��6"   $

 Text�6>   �� 59      $	 ClassNameInput��6"   $

 Text�6?   5:      ��5=      �� 5>       �� 
TargetType" ��6   .�5?      ��  �� Property � �� �� Value$ Fonts/#Dosis)�6C   �� 5@       � �� �#FE658467   �� 5A       �@�Cursor$
 Hand��63    �� Triggers 5B      P� 5C       P� Property �@J�IsMouseOver P� Value . . �5E   "   ��  � ��
 �� ��6?   5F      5H      ��5J      �� 5K       �� 
TargetType" ��6&   .R�5L      �� $��90��6!    �� CornerRadius$ 12��5M   !   #��z��5N   !   ._�5O      �� $��Center=�6/   $��Center=�5P   /   5Q      5R      5T      5V      �� 5W   
   $��Adauga studenti��6   $
��Left=�6*   $��	95,39,0,0q�6E   $	��Top=�6X   $	��385��6p   $��70��6|   
�������$��45(�5Y      5Z      5[      
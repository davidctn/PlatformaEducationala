   M S B A M L   `   `   `  ����P  LPlatformaEducationala, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:PlatformaEducationala.ViewsPlatformaEducationala.Views  5   	   �Oclr-namespace:PlatformaEducationala.Converters.PlatformaEducationala.ConvertersAPlatformaEducationala.Converters.PlatformaEducationala.Converters  5   	   S.clr-namespace:PlatformaEducationala.ViewModels PlatformaEducationala.ViewModels  5   	   2    ,PlatformaEducationala.Views.AddTeacherWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:PlatformaEducationala.Views     5   	   dconvert1Oclr-namespace:PlatformaEducationala.Converters.PlatformaEducationala.Converters     5   	   >ctx.clr-namespace:PlatformaEducationala.ViewModels     5   	     � Title$  AddTeacherWindow��5
   	   $	��450��6"   $	��800��6/    � 
ResizeMode$ NoResize=�5   
   ���#181235 � DataContext 5      /  )PlatformaEducationala.ViewModels.PersonVM  5   
   .��5      � .+�5   
   �� $��	FirstName��6   $
��Left=�6%   $��
10,110,0,0q�6@   $	��Top=�6T   
�������$��71��5       $	��180��6,   $��30(�5      �� 5   
   $��LastName��6   $
��Left=�6$   $��
10,186,0,0q�6?   $	��Top=�6S   
�������$��71��5       $	��180��6,   $��30(�5      �� 5   
   $��EmailAdress��6   $
��Left=�6'   $��
10,262,0,0q�6B   $	��Top=�6V   
�������$��71��5       $	��205��6,   $��30(�5      �� 5   
   $��Password��6   $
��Left=�6#   $��
10,333,0,0q�6>   $	��Top=�6R   
�������$��62��5       $	��180��6,   $��30(�5      �� 5   
   -   5         ��Name$ FirstNameInput��5      $
��Left=�6*   $��30��6E   $��195,123,0,0q�6Q    �� TextWrapping$
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��375��6�   �� 5   
   -   5        $ LastNameInput��5      $
��Left=�6)   $��30��6D   $��195,193,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��375��6�   �� 5   
   -   5        $ EmailAddressInput��5      $
��Left=�6-   $��30��6H   $��195,269,0,0q�6T   $
 Wrap=�6i   $�� ��6}   $	��Top=�6�   $	��375��6�   �� 5    
   -   5        $ PasswordInput��5       $
��Left=�6)   $��30��6D   $��195,338,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��375��6�   �� 5"   
   $��-10,-11,10,10q�6    � 	Resources 5#      W  QPlatformaEducationala.Converters.PlatformaEducationala.Converters.PersonConverter   personConverter��%   &	          5$      6F   5%      .+�5&      �� -   5         ��Name$ AddTeacherButton��5'      $��Adauga��5(      
���   �$��16(�5*      $��Medium"�5+      $��Fonts/#Dosis)�5,      $y�Visible=�5-      $��440,70,234,316q�5.      $��34��50      ��5/      �� *AddTeacherCommand+��51      `� 52       `� 	Converter# [  6#   .1�53      ��  �� ElementName$ FirstNameInput��6"   	 �� Path$
	 Text�6?   �� 54      $ LastNameInput��6"   $
	 Text�6>   �� 55      $ EmailAddressInput��6"   $
	 Text�6B   �� 56      $ PasswordInput��6"   $
	 Text�6>   57      ��5:      �� 5;      
 �� 
TargetType"
 ��6   .�5<      ��  �� Property � �� �� Value$ Fonts/#Dosis)�6C   �� 5=       � �� �#FE658467   �� 5>       �@�Cursor$
 Hand��63    �� Triggers 5?      P� 5@       P� Property �@J�IsMouseOver P� Value . . �5B   "   ��  � ��
 �� ��6?   5C      5E      ��5G      �� 5H       �� 
TargetType" ��6&   .R�5I      �� $��90��6!    �� CornerRadius$ 12��5J   !   #��z��5K   !   ._�5L      �� $��Center=�6/   $��Center=�5M   /   5N      5O      5Q      5R      �� 5S   
   $��Adauga profesori��6   $
��Left=�6+   $��	80,35,0,0q�6F   $	��Top=�6Y   $	��360��6q   $��80��6}   
�������$��45(�5U      5V      5W      
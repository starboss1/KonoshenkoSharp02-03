   M S B A M L   `   `   `  ����  KonoshenkoLab02C    =KMA.ProgrammingInCSharp2019.KonoshenkoLab02.InformationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  InformationWindow��5   	   $	��550��6#   $	��600��60   .��5      � ��5	   
   
� 5
       
� GradientOrigin$ 0.5,0.5&�6"   .��5      �  � Color$
 Blue��6    � Offset$ 0Q�6,   � 5      $ CornflowerBlue��6   $ 1Q�66   5       � RowDefinitions 5   
   �� 5      $��7* �6   6*   �� 5      $��7* �6   6*   �� 5      $��7* �6   6*   �� 5      $��7* �6   6*   �� 5      $��7* �6   6*   �� 5      $��7* �6   6*   �� 5      $��7* �6   6*   �� 5      $��7* �6   6*   �� 5      $��7* �6   6*   .+�5   
   �� $��0��6   $��0��6!   $��10q�61   $��15(�6=   $��Italic$�6K   ��6^   �� *	FirstName+ �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��1��6   $��0��6!   $��10q�61   $��15(�6=   $��Italic$�6K   ��6^   �� *
LastName+$ OneWay=�$ PropertyChanged=�6�   �� 5   
   $��2��6   $��0��6!   $��10q�61   $��15(�6=   $��Italic$�6K   ��6^   �� *Email+$ OneWay=�$ PropertyChanged=�6�   �� 5   
   $��3��6   $��0��6!   $��10q�61   $��15(�6=   $��Italic$�6K   ��6^   �� *DateOfBirth+$ OneWay=�$ PropertyChanged=�6�   �� 5   
   $��4��6   $��0��6!   $��10q�61   $��15(�6=   $��Italic$�6K   ��6^   �� *	IsAdult+$ OneWay=�$ PropertyChanged=�6�   �� 5   
   $��5��6   $��0��6!   $��10q�61   $��15(�6=   $��Italic$�6K   ��6^   �� *	SunSign+$ OneWay=�$ PropertyChanged=�6�   �� 5    
   $��6��6   $��0��6!   $��10q�61   $��15(�6=   $��Italic$�6K   ��6^   �� *ChineseSign+$ OneWay=�$ PropertyChanged=�6�   �� 5!   
   $��7��6   $��0��6!   $��10q�61   $��15(�6=   $��Italic$�6K   ��6^   �� *
IsBirthday+$ OneWay=�$ PropertyChanged=�6�   5"      5#      
   M S B A M L   `   `   `  ����E  ACustomQuiz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:CustomQuiz.Windows.MakeQuizCustomQuiz.Windows.MakeQuiz  5   	   ,    &CustomQuiz.Windows.MakeQuiz.HomeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:CustomQuiz.Windows.MakeQuiz     5   	     � Title$  Custom Quizzes��5   	   $	��400��6    $	��500��6-    � 
ResizeMode$ CanMinimize=�69   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6!   $��3��61   $��Center=�6E   $��Center=�6`   $��28(�6}   $
��Bold"�6�   Initial Quiz Options5      �� 5   
   $��15q�6   $��1��6    $��0��6-   $��Center=�6=   $��20(�6X   $
��Bold"�6f   
Quiz Name:5      �� 5   
   -   5         ��Name$ TextBoxTitle��5      $��1��5      $��1��5      $��2��5       $��Center=�5!      $��Center=�5"      $��20(�5#      $��15q�5$      $	��100��5%      ��5&      �� *	QuizTitle+�� 5(   
   -   5         ��Name$ CheckBoxRandomOptionOrder��5(      $��2��66   $��0��6C   $��3��6S   $��Center=�6g   $��Center=�6�   $��15q�6�    d� 	IsChecked 6�   �� *RandomOptionOrder+.��5)      �� $��20(�6   $��Center=�6&   Random Option Order5+      5,      �� 5-   
   -   5        $! CheckBoxRandomQuestionOrder��5-      $��3��68   $��0��6E   $��3��6U   $��Center=�6i   $��Center=�6�   $��15q�6�    6�   �� *RandomQuestionOrder+.��5.      �� $��20(�6   $��Center=�6&   Random Question Order50      51      �� 52   
   -   5        $��4��52      $��0��6   $��15q�6.   $��20(�6:   .��6e   	Go Back54      �� 55   
   -   5        $��4��55      $��1��6   $��15q�6.   $��20(�6:   .��6b   Save57      �� 58   
   -   5        $��4��58      $��2��6   $��15q�6.   $��20(�6:   .��6e   Next5:      5;      5<      
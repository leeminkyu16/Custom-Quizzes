   M S B A M L   `   `   `  ����E  ACustomQuiz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:CustomQuiz.Windows.MakeQuizCustomQuiz.Windows.MakeQuiz  5   	   0    *CustomQuiz.Windows.MakeQuiz.OverviewWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:CustomQuiz.Windows.MakeQuiz     5   	     � Title$  MakeQuizOverviewWindow��5   	   $	��550��6(   $	��500��65    � 
ResizeMode$ CanMinimize=�6A   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��5* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6!   $��3��61   $��Center=�6E   $��Center=�6`   $��28(�6}   $
��Bold"�6�   Quiz Overview5      �� 5   
   $��Center=�6   $��1��6/   $��0��6<   $��15 0 0 0q�6L   $��20(�6^   $
��Bold"�6l   
Quiz Name:5      �� 5   
   -   5         ��Name$ TextBoxQuizName��5      $��1��5      $��1��5      $��2��5       $��Center=�5!      $��Center=�5"      $��15q�5#      $	��100��5$      $��20(�5%      ��5&      �� *	QuizTitle+�� 5(   
   -   5         ��Name$ QuestionListBox��5+      $��2��5)      $��3��5*       �� DisplayMemberPath$ questionText��5-      $��20(�5.      ��5,      �� *	Questions+5.      �� 50   
   -   5        $��3��50      $��0��6   $��20(�6.   $��10q�6<   .��6e   	Move Up52      �� 53   
   -   5        $��3��53      $��1��6   $��20(�6.   $��10q�6<   .��6b   Edit55      �� 56   
   $��3��6   $��2��6   $��20(�6.   $��10q�6<   .��6H   Delete58      �� 59   
   -   5        $��4��59      $��0��6   $��20(�6.   $��10q�6<   .��6g   	Move Down5;      �� 5<   
   -   5        $��4��5<      $��1��6   $��20(�6.   $��10q�6<   .��6b   Save5>      �� 5?   
   -   5        $��4��5?      $��2��6   $��20(�6.   $��10q�6<   .��6b   Exit5A      5B      5C      
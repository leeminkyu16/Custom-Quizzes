   M S B A M L   `   `   `  ����E  ACustomQuiz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:CustomQuiz.Windows.DoQuizCustomQuiz.Windows.DoQuiz  5   	   ,    &CustomQuiz.Windows.DoQuiz.ResultWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:CustomQuiz.Windows.DoQuiz     5   	     � Title$  
Quiz Maker��5   	   $	��500��6   $	��500��6)    � 
ResizeMode$ CanMinimize=�65   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ TextBlockQuizName��5      $��0��6/   $��20(�6<   $��	ExtraBold"�6J   $��Center=�6a   $��Center=�6~   	Quiz Name5      �� 5   
   -   5        $ TextBlockFraction��5      $��1��6/   $��20(�6<   $
��Bold"�6J   $��Center=�6\   $��Center=�6y   
Fraction5      �� 5   
   -   5        $ TextBlockPercentage��5      $��2��61   $��20(�6>   $
��Bold"�6L   $��Center=�6^   $��Center=�6{   
Percentage5      �� 5   
   -   5        $��3��5      $��15q�6   $��20(�6*   .��6R   
Go to Menu5      5      5       
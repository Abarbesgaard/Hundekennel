   M S B A M L   `   `   `  ����J  FWPF_Hundekennel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WPF_Hundekennel.ViewWPF_Hundekennel.View  5      %    WPF_Hundekennel.View.Collection   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:WPF_Hundekennel.View     5      
�������.��5      �   � RowDefinitions  5   
   �� 5      $��10 �6   �� 5      �� 5      �� 5      �� 5      $��10 �6    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      �� 5      $��40 �6   �� 5      �� 5      $��20 �6   .+�5   
   �� 
�������$��0q�5       $��1��5!      $��3��5"      $��1��5#      $��10q�5$      ��5%      �� *Dogs+ �� SelectedItem 5&      �� *SelectedDog+��5'      �� 5(      .R�5)      ��  �� Orientation$ 
Horizontal=�6!   .+�5*      �� $
��Bold"�5+   $   ��5*   $   �� *	DogName+5+   $   �� 5,      $�� ��6$   �� 5-      ��6$   �� *	DogGender+5.      5/      51      �� 55   
   ���#bde0fe �� CornerRadius$ 10��56      $��1��57      $��3��58      $��3��59         WindowBackgroundColor#��[  5:      ._�5<      �� $ Vertical=�6   $��1��5=      $��3��5>      $��3��5?      $��
10,10,10,0q�5@      .+�5B      �� 
�������$ 10��5C      
�������._�5F      �� $ 
Horizontal=�6!   .+�5G      �� $��Center=�6      WindowdTheme_FontColor#��[ 5H       $
��Navn��5I       $
��Bold"�5J       $��14(�5K       �� 5L      
�������$��Center=�5M   "   
���������5O   "   �� *SelectedDog.DogName+5Q      5R      �� 5S      
�������$ 10��5T      
�������$��0,10,0,0q�5V      ._�5X      �� $ 
Horizontal=�6!   .+�5Z      �� $��Center=�6    $
��Køn��5[       $
��Bold"�5\       $��14(�5]       #��[ 5^       �� 5`      
�������$��Center=�5a   "   
���������5c   "   �� *SelectedDog.DogGender+5e      5f      5h      5i      5l      5m      
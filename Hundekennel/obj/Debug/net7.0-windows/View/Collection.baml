   M S B A M L   `   `   `  ����F  BHundekennel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Hundekennel.ViewHundekennel.View  5      =#clr-namespace:Hundekennel.ViewModelHundekennel.ViewModel  5      !    Hundekennel.View.Collection   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Hundekennel.View     5      9	viewmodel#clr-namespace:Hundekennel.ViewModel     5      
�������.��5      �   � RowDefinitions  5   
   �� 5      $��10 �6   �� 5      �� 5      �� 5      �� 5      $��10 �6    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      �� 5      $��40 �6   �� 5      �� 5      $��20 �6   .+�5!   
   �� 
�������$��0q�5"      $��1��5#      $��3��5$      $��1��5%      $��10q�5&      ��5'      �� *	AllDogs+ �� SelectedItem 5(      �� *SelectedDog+��5)      �� 5*      .R�5+      ��  �� Orientation$ 
Horizontal=�6!   .+�5,      �� $
��Bold"�5-   $   ��5,   $   �� *Name+5-   $   �� 5.      $�� ��6$   �� 5/      ��6$   �� *DateOfBirth+50      51      53      �� 57   
   ���#bde0fe �� CornerRadius$ 10��58      $��1��59      $��3��5:      $��3��5;         WindowBackgroundColor#��[  5<      ._�5>      �� $ Vertical=�6   $��1��5?      $��3��5@      $��3��5A      $��
10,10,10,0q�5B      .+�5D      �� 
�������$ 10��5E      
�������._�5H      �� $ 
Horizontal=�6!   .+�5I      �� $��Center=�6      WindowdTheme_FontColor#��[ 5J       $
��Navn��5K       $
��Bold"�5L       $��14(�5M       �� 5N      -   5         ��Name$ HundeNavnTextBox��5N   "   
�������$��Center=�5P   "   
���������5R   "   �� *SelectedDog.Name+5T      5U      �� 5V      
�������$ 10��5W      
�������$��0,10,0,0q�5Y      ._�5[      �� $ 
Horizontal=�6!   .+�5]      �� $��Center=�6    $��Stamtavle nummer��5^       $
��Bold"�5_       $��14(�5`       #��[ 5a       �� 5c      
�������$��Center=�5d   "   
���������5f   "   �� *SelectedDog.Lineage+5h      5i      �� 5j      $��Bottom=�6   $��30��5k      $��30��5l      $��+��5m      $��Center=�5n      $��Stretch=�5o      $��20(�5p      $
��Bold"�5q      $��10q�5r      ��5s      �� *AddDogCommand+��5t      ��  �� ElementName$ HundeNavnTextBox�� �� Path$
 Text�5v      5w      5x      5{      5|      
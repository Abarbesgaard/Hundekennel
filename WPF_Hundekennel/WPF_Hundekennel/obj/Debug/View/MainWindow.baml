   M S B A M L   `   `   `  ����J  FWPF_Hundekennel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WPF_HundekennelWPF_Hundekennel  5   	   E'clr-namespace:WPF_Hundekennel.ViewModelWPF_Hundekennel.ViewModel  5   	        WPF_Hundekennel.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WPF_Hundekennel     5   	   =	viewModel'clr-namespace:WPF_Hundekennel.ViewModel     5   	     � Title$  Caroline Lyst��5	   	   $	��450��5
   	   $	��800��5   	    � DataContext 5      -   'WPF_Hundekennel.ViewModel.MainViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      .+�5   
   � $��1��6      MenuBackgroundColor_Primary#��[  5       � RowDefinitions 5      �� 5      �� 5      $��50 �6    .+�5      �� .+�5       ��  & "MenuBackgroundColor_PrimaryVariant#��[ 5!      ._�5#      �� $
��Menu��6   $��20(�5$      
�������$��5,0,0,4q�5&      $
��Bold"�5'      5(      	� 5*      $	��Top=�6   $
��Hjem��5+      $��20(�5,      
�������  MenuButtonTheme#��[ 5.      ��5/      �� *HomeViewCommand+51      	� 53      $	��Top=�6   $��Tilføj Kuld��54      $��20(�55      
�������#��[ 57      $�� ��58      5:      	� 5<      $��Register��6   $��20(�5=      
�������#��[ 5?      ��5@      �� *CollectionViewCommand+5B      5D      5F      �� 5G   
   $��1��6   $��1��5H      $��10q�5I      ��5J      �� *CurrentView+5K      5M      
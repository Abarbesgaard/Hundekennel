   M S B A M L   `   `   `  ����F  BHundekennel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Hundekennel.ViewHundekennel.View  5   	   =#clr-namespace:Hundekennel.ViewModelHundekennel.ViewModel  5   	   !    Hundekennel.View.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Hundekennel.View     5   	   9	viewModel#clr-namespace:Hundekennel.ViewModel     5   	     � Title$  Caroline Lyst��5	   	   $	��450��6   $	��800��6,    � DataContext 5
      )   #Hundekennel.ViewModel.MainViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      .+�5   
   � $��1��6      MenuBackgroundColor_Primary#��[  5       � RowDefinitions 5      �� 5      �� 5      $��50 �6    .+�5      �� .+�5      ��  & "MenuBackgroundColor_PrimaryVariant#��[ 6   ._�5       �� $
��Menu��6   $��20(�5!      
�������$��5,0,0,4q�5#      $
��Bold"�5$      5%      	� 5'      $	��Top=�6   $
��Hjem��5(      $��20(�5)      
�������  MenuButtonTheme#��[ 5+      ��5,      �� *HomeViewCommand+5.      	� 50      $	��Top=�6   $��Tilføj Kuld��51      $��20(�52      
�������#��[ 54      $�� ��55      57      	� 59      $��Register��6   $��20(�5:      
�������#��[ 5<      ��5=      �� *CollectionViewCommand+5?      5A      5C      �� 5D   
   $��1��6   $��1��5E      $��10q�5F      ��5G      �� *CurrentView+5H      5J      
   M S B A M L   `   `   `  ����D  @MES_OpcUa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:MES_OpcUa.ViewModelMES_OpcUa.ViewModel  5   	       MES_OpcUa.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   0vm!clr-namespace:MES_OpcUa.ViewModel     5   	   $	��200��5   	   $	��700��6   $	��200��6"   $	��700��62   $	��200��6A   $	��700��6Q     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�6.    � WindowState$ Normal=�6A    � AllowsTransparency$
 True��5   	   $��5q�5	   	   ���#252629 � DataContext 5
      '   !MES_OpcUa.ViewModel.MainViewModel  5   
   .��5      �� 
��� � �$��1q�6!   ._�5   
   � ���#1e1f21 � RowDefinitions 5      �� 5      $	��100 �6    �� 5      $	��100 �6     � ColumnDefinitions 5      �� 5      $	��550 �6#   �� 5      $��* �6#   .+�5      �� $��2��6   $��0��6%   $��20q�62   ._�5      �� -   5         ��Name$ btnExit��5         startupButton#��[  5      $��40��5   &   $��40��62   $��Right=�5      $	��Top=�6-   
���  ��
���\\��
���  ��$��X��5      ��5      �� *CloseApplicationCommand+5      �� 5       -   5         ��Name$ AddressBorder��5!        startupBorder#��[ 6(   $��
10, 50,0,0q�5"      $��2��6%   $��Center=�5#      $	��Top=�6.   ._�5$      �� -   5        	 ��Name$	 AddressTextBox��5'        startupTextBox#��[ 5%      $	��450��5'   -   $��30��69   ��5&      �� *	Address+5'   9   5(      �� 5)      $��1��6   $��2��6"   $	��100��62   $	��100��6>   $��Right=�5*      $	��Top=�61   $��0, 0, 20, 0q�5+      ._�5,      �� #��[  6   $��2��5-      $��2��6)   $��0,0,0,10q�66   $	��100��6H   ���#16470b���#309e18$��O��5.   D   $��Light"�5/      $��20(�6,   
��� d ���50      �� *ConnectToServer+��6=   �� 
 �� ElementName$
 AddressTextBox�� �� Path$
 Text�51      52      53      54      
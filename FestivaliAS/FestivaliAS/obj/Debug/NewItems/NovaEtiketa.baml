   M S B A M L   `   `   `  ����F  BFestivaliAS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:FestivaliAS.ViewModelsFestivaliAS.ViewModels  5   	   &     FestivaliAS.NewItems.NovaEtiketa   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TXceed.Wpf.Toolkit, Version=2.7.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   0local$clr-namespace:FestivaliAS.ViewModels  5   	     � Title$  Nova Etiketa��5
   	    � Icon$- '/../Images/icons8-new-ticket-35 (1).png��6   $	��400��6N   $	��550��6[    � 
ResizeMode$ NoResize=�6g    � WindowStartupLocation$ CenterScreen=�6}    � 	Resources 5      -  'FestivaliAS.ViewModels.EtiketaViewModel   DataContext��%   &	          5   
   6!   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Help��5      6<   .��5      �  � DataContext# [  6   ���#9DB6A4.+�5   
   �� -   5         ��Name$ Osnovno��5      $��Osnovno��6$   
���iii�$��2q�6K   
�������$��15(�6w   $
��Bold"�6�   $��29,10,18,73q�6�   .��5      � .+�5      �� $��Jedinstvena oznaka:��6   $
��Left=�66   $��Normal"�6Q   $��20(�6e   $��Arial)�6s   $��0,6,0,-6q�6�   �� 5      -   5        	 ��Name$	 	IdTextBox��5      
���iii�$��Normal"�6C   $
��Left=�6�   $	��Top=�6�   $	��186��6�   $
��Left=�6  $��Center=�5      $��20(�64   $��Arial)�6B   ���#DDECE1
���   �$��
255,10,0,0q�6}   ��5   X   �� *
Etiketa.Id+
 �� ValidatesOnDataErrors
 .  �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5   }   �� 5      $��18(�6   $
��Bold"�6&   
���  ��$��0,36,44,182q�6�   ��6I   ��  �� ElementName$ 	IdTextBox�� �� Path$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   �� 5      $��Boja:��6   $��Normal"�6)   $
��Left=�6=   $��20(�6X   $��Arial)�6f   $	��192��6y   $
��Auto��6�   $��
0,66,0,150q�6�   #  Xceed.Wpf.Toolkit.ColorPicker  5      -   5          Name$ ColorPicker��5   #   
���iii� J� IsHitTestVisible . $��255,66,33,154q�6�      SelectedColor 6N   �� *Etiketa.Boja+
 . $ PropertyChanged=�$ TwoWay=�6�   �� 5!      -   5        $	 Booja��5!      
���iii�$��Normal"�6?   $
��Left=�6�   $	��Top=�6�   $��0��6�   $
��Left=�6�   $��Center=�5"      $��20(�64   $��0��6B   $��Arial)�6M   ���#DDECE1
���   �$��
255,66,0,0q�6�   ��5!   T   �� *Etiketa.Color+
 . $ PropertyChanged=�5"   �   �� 5$      $��18(�6   $
��Bold"�6&   
���  ��$��0,109,192,109q�6�   ��6I   �� $ Booja��$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   �� 5'      $��Opis:��6   $��Normal"�6(   $
��Left=�6<   $��20(�6W   $��Arial)�6e   $
��Auto��6x   $
��Auto��6�   $��0,149,0,-149q�6�   �� 5(      $
��Left=�6   
���iii�$��85��6K   $��Normal"�6W   $��101,149,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6   $	��340��5)      $��20(�6   ���#DDECE1$��Arial)�6A   
���   �" �� VerticalScrollBarVisibility$
 Auto=�6g   ��5(   l   �� *Etiketa.Opis+
 . $ PropertyChanged=�$ TwoWay=�5)   g   5,      5.      �� 53   
   -   5        $��
DodajDugme��53      $��Dodaj��6b   $
��Left=�6r   $	��106��6�   $��22(�6�   $��Arial)�6�   
���2͚�$��283,317,0,10q�6�   ��6#   �� *AddEtiketaCommand+6�   �� 54   
   -   5        $��Odustani��54      $��Odustani��6!   $
��Left=�64   $	��106��6O   $��22(�6[   $��Arial)�6i   
�������$��416,317,0,10q�6�   6�   58      59      
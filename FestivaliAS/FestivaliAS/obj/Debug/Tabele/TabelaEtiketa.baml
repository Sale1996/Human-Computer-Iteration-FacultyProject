   M S B A M L   `   `   `  ����F  BFestivaliAS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:FestivaliAS.ViewModelsFestivaliAS.ViewModels  5   	   &     FestivaliAS.Tabele.TabelaEtiketa   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:FestivaliAS.ViewModels     5   	   X TXceed.Wpf.Toolkit, Version=2.7.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  TabelaEtiketa��5	   	    � Icon$- '/../Images/icons8-data-sheet-35 (2).png��6   $	��700��6N   $	��740��6[    � 
ResizeMode$ NoResize=�6g    � WindowStartupLocation$ CenterScreen=�6}    � 	Resources 5
      -  'FestivaliAS.ViewModels.EtiketaViewModel   DataContext��%   &	          5   
   6!   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Help��5      6<   .��5      � ���#9DB6A4 � DataContext 6   ��  �� Source# [  .+�5   
   �� -   5        	 ��Name$		 Add��5      $��Dodaj��6R   $
��Left=�6b   
���2͚�$	��106��6�   $��22(�6�   $��Arial)�6�   $��334,547,0,81q�6�   
 J� RenderTransformOrigin$
 0.623,0.512&�6�   ��6   �� *!KreirajNovuEtiktuUTabeliCommand+6�   �� 5   
   -   5        $
	 Edit��5      $��Izmeni��6K   $
��Left=�6\   
����ح�$	��106��6�   $��22(�6�   $��Arial)�6�   $��466,547,0,81q�6�   $
 -0.146,0.583&�6�   ��6   �� *EditEtiketaClickCommand+6�   �� 5   
   -   5        $	 Delete��5      $��Izbriši��6J   $
��Left=�6\   
�������$��22(�6�   $��Arial)�6�   $	��106��6�   $��602,547,0,81q�6�   ��6!   �� *RemoveEtiketaCommand+6�   �� 5   
   -   5        $��Izadji��5      $��Izađi��6   $
��Left=�6/   $	��106��6J   $��22(�6V   $��Arial)�6d   
�������$��602,609,0,19q�6�   6�   �� 5   
   -   5         ��Name$ FilterTipova��5      
���iii�
�������$��2q�6W   $��Filter i pretraga��6k   $
��Left=�6�   $��DemiBold"�6�   $��	22,10,0,0q�6�   $��24(�6�   $��Arial)�6�   $	��Top=�5      $	��146��6+   $	��686��68   .��5      � .+�5      �� 
���iii�$
��Left=�6�   $	��Top=�6�   $	��535��6�   $
��Left=�6�   $��Center=�5       $��20(�64   $��Arial)�6B   ���#DDECE1
���   �$��6,35,0,0q�6}   ��5   0   �� *EtiketaFilter.Id+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5    }   �� 5'      -   5        $	 FindTip��5'      $��Normal"�6[   $��	Pretraži��6o   $
��Left=�6�   
�������$	��106��6�   $��22(�6�   $��Arial)�6�   $��
546,0,0,68q�6�   $
 0.542,0.062&�6�   ��6*   �� *PretragaFilterEtiketeCommand+6�   �� 5(      -   5        $��
PonistiTip��5(      $��Normal"�6[   $��Poništi��6o   $
��Left=�6�   $	��106��6�   $��22(�6�   $��Arial)�6�   
�������$��546,56,0,10q�6�   $
 0.052,0.643&�6�   ��6+   �� *PonistavanjePretrageCommand+6�   5*      5+      &   System.Windows.Controls.DataGrid  51   
   -	   5        $��tipGrid��51      
�������   AutoGenerateColumns .     
IsReadOnly . $��22,186,26,136q�6�   $��20(�6�   $��Arial)�6     	RowHeight$ 50Q�6   �� SelectedItem 6W   �� *SelektovanaEtiketa+$ PropertyChanged=���6�   �� *	Etikete+   Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ Jedinstvena oznaka��6%      MinWidth$	 200Q�6A      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Z   �� *Id+4  .System.Windows.Controls.DataGridTemplateColumn  54      $ Boja etikete��6)   $	 200Q�6?   $ * 6N      CellTemplate 55      �� 56      .R�57      �� $	��200��6J   $��5q�6Y   ��6(   ��  �� Path$ Color�6Y   58      5:        5;      $
 Opis��6%   $	 200Q�63   $ * 6B    6L   �� *Opis+5?      5C      5D      
   M S B A M L   `   `   `  ����F  BFestivaliAS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:FestivaliAS.ViewModelsFestivaliAS.ViewModels  5   	   "    FestivaliAS.Tabele.TabelaTip   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:FestivaliAS.ViewModels     5   	     � Title$  
Tabela Tip��5   	    � Icon$- '/../Images/icons8-data-sheet-35 (1).png��6   $	��700��6L   $	��860��6Y    � 
ResizeMode$ NoResize=�6e    � WindowStartupLocation$ CenterScreen=�6|    � 	Resources 5
      )  #FestivaliAS.ViewModels.TipViewModel   DataContext��%   &	          5   
   6   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Help��5      6<   .��5      � ���#9DA1B6 � DataContext 6   ��  �� Source# [  .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��tipGrid��5      
�������	   AutoGenerateColumns	 .  
   
IsReadOnly
 . $��22,189,28,134q�6�   $��20(�6�   $��Arial)�6�      	RowHeight$ 50Q�6   �� SelectedItem 6X   �� *SelektovaniTip+ �� UpdateSourceTrigger$ PropertyChanged=���6�   �� *Tipovi+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Jedinstvena oznaka��6%      MinWidth$	 200Q�6A      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Z   �� *Id+  5      $	 Ime��6%   $	 200Q�63   $ * 6B    6L   �� *Name+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Ikonica��6)   $ * 6:      CellTemplate 5      �� 5      .R�5      �� ��6$   �� *
IconPath+5      5        5      $
 Opis��6%   $	 200Q�63   $ * 6B    6L   �� *Opis+5"      �� 5+   
   -   5         ��Name$	 Add��5+      $��Dodaj��6O   $
��Left=�6_   
���2͚�$	��106��6�   $��22(�6�   $��Arial)�6�   $��445,552,0,76q�6�   ��6   �� *KreirajNoviTipUTabeliCommand+6�   �� 5,   
   -   5        $
 Edit��5,      $��Izmeni��6G   $
��Left=�6X   
����ح�$	��106��6�   $��22(�6�   $��Arial)�6�   $��584,552,0,76q�6�   ��6   �� *EditTipClickCommand+6�   �� 5-   
   -   5        $ Delete��5-      $��Izbriši��6G   $
��Left=�6Y   
�������$��22(�6�   $��Arial)�6�   $	��106��6�   $��720,552,0,76q�6�   ��6"   �� *RemoveTipCommand+6�   �� 5.   
   -   5        $��Izadji��5.      $��Izađi��6   $
��Left=�6/   $	��106��6J   $��22(�6V   $��Arial)�6d   
�������$��720,607,0,21q�6�    J� RenderTransformOrigin$ 0.575,0.976&�6�   6�   �� 55   
   -   5         ��Name$ FilterTipova��55      
���iii�
�������$��2q�6W   $��Filter i pretraga��6k   $
��Left=�6�   $��DemiBold"�6�   $��	22,10,0,0q�6�   $��24(�6�   $��Arial)�6�   $	��Top=�56      $	��147��6+   $	��804��68   .��57      � .+�5:      �� 
���iii�$
��Left=�6�   $	��Top=�6�   $	��660��6�   $
��Left=�6�   $��Center=�5;      $��20(�64   $��Arial)�6B   ���#DDE0EC
���   �$��8,36,0,0q�6}   $��34��6�   ��5:   0   �� *TipFilter.Id+$ PropertyChanged=� �� Mode$ TwoWay=�5;   �   �� 5@      -   5        $ FindTip��5@      $��Normal"�6T   $��	Pretraži��6h   $
��Left=�6{   
�������$	��106��6�   $��22(�6�   $��Arial)�6�   $��
676,0,0,69q�6�   ��6*   �� *PretragaFilterCommand+6�   �� 5A      -	   5        $��
PonistiTip��5A      $��Normal"�6V   $��Poništi��6j   $
��Left=�6|   $	��106��6�   $��22(�6�   $��Arial)�6�   
�������$��676,56,0,13q�6�   ��6+   �� *PonistiPretraguCommand+6�   5C      5D      5F      5G      
   M S B A M L   `   `   `  ����F  BFestivaliAS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:FestivaliAS.ViewModelsFestivaliAS.ViewModels  5   	   ,    &FestivaliAS.Tabele.TabelaManifestacija   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:FestivaliAS.ViewModels     5   	     � Title$  Tabela Manifestacija��5
   	    � Icon$) #/../Images/icons8-data-sheet-35.png��6&   $	��900��6Q   $
��1350��6^    � 
ResizeMode$ NoResize=�6k    � WindowStartupLocation$ CenterScreen=�6�    � 	Resources 5      3  -FestivaliAS.ViewModels.ManifestacijaViewModel   DataContext��%   &	          5   
   6'   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Help��5      6<   .��5      � ���#B6A59D � DataContext 6   ��  �� Source# [  .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��manifestationsGrid��5      
�������	   AutoGenerateColumns	 .  
   
IsReadOnly
 . $��38,231,32,160q�6�   $��20(�6
  $��Arial)�6     	RowHeight$ 50Q�6+   �� SelectedItem 6b   �� *SelektovanaManifestacija+ �� UpdateSourceTrigger$ PropertyChanged=���6�   �� *Manifestacije+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Jedinstvena oznaka��6%      MinWidth$	 190Q�6A      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Z   �� *Id+  5      $	 Ime��6%   $	 130Q�63   $ * 6B    6L   �� *Name+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Ikonica��6)   $ * 6;      CellTemplate 5      �� 5      .R�5      �� ��6$   �� *
IconPath+5      5        5       $ Kategorija cena��6%   $	 170Q�6?   $ * 6P    6[   �� *KategorijaCena+  5!      $ Mesto održavanja��6%   $	 170Q�6?   $ * 6P    6[   �� *MestoOdrzavanja+  5"      $ Datum održavanja��6%   $	 180Q�6?   $ * 6P    6Z   �� *Date+ �� StringFormat$ {0:dd.MM.yy}��  5#      $ Alkohol��6%   $	 200Q�68   $ * 6G    6Q   �� *StatusAlkohola+5(      �� 5+   
   -   5         ��Name$	 Add��5+      $��Dodaj��6Y   $
��Left=�6i   
���2͚�$	��106��6�   $��22(�6�   $��Arial)�6�   $��916,725,0,103q�6�   ��6   �� *(&KreirajNovuManifestacijuUTabeliCommand+6�   �� 5,   
   -   5        $
 Edit��5,      $��Izmeni��6Q   $
��Left=�6b   
����ح�$	��106��6�   $��22(�6�   $��Arial)�6�   $��1063,725,0,103q�6�   ��6   �� *EditManifestacijaClickCommand+6�   �� 5-   
   -   5        $ Delete��5-      $��Izbriši��6P   $
��Left=�6b   
�������$��22(�6�   $��Arial)�6�   $	��106��6�   $��1206,725,0,103q�6�   ��6!   �� *RemoveManifestacijaCommand+6�   �� 5.   
   -   5        $ Izadji��5.      $��Izađi��6!   $
��Left=�61   $	��106��6L   $��22(�6X   $��Arial)�6f   
�������$��1206,804,0,24q�6�   6�   �� 59   
   -   5         ��Name$ FilterManifestacije��59      
���iii�
�������$��2q�6^   $��Filter i pretraga��6r   $
��Left=�6�   $��DemiBold"�6�   $��38,0,0,0q�6�   $��24(�6�   $��Arial)�6�   $	��Top=�5:      $	��178��6+   $
��1274��68   .��5;      � .+�5=      �� 
���iii�$
��Left=�6�   $��Normal"�6�   $	��Top=�6�   $
��1131��6�   $
��Left=�6�   $��Center=�5>      $��20(�64   $��Arial)�6B   ���#ECE0DD
���   �$��	10,52,0,0q�6}   ��5=   0   �� *ManifestacijaFilter.Id+$ PropertyChanged=� �� Mode$ TwoWay=�5>   }   �� 5^      -   5        $ FindManifestacije��5^      $��Normal"�6k   $��	Pretraži��6   $
��Left=�6�   
�������$	��106��6�   $��22(�6�   $��Arial)�6�   $��1146,10,0,90q�6�   ��64   �� *$"PretragaFilterManifestacijeCommand+6�   �� 5_      -	   5        $��PonistiManifestacije��5_      $��Normal"�6`   $��Poništi��6t   $
��Left=�6�   $	��106��6�   $��22(�6�   $��Arial)�6�   
�������$��1146,79,0,21q�6�   ��65   �� *PonistiPretraguCommand+6�   5a      5c      5e      5f      
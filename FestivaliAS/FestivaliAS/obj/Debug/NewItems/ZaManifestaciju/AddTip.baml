   M S B A M L   `   `   `  ����F  BFestivaliAS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:FestivaliAS.ViewModelsFestivaliAS.ViewModels  5   	   1    +FestivaliAS.NewItems.ZaManifestaciju.AddTip   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:FestivaliAS.ViewModels     5   	   -   5          � Title$  	Ubaci tip��5   	    � Icon$- '/../Images/icons8-data-sheet-35 (1).png��6   $	��640��6K   $	��860��6X    � 
ResizeMode$ NoResize=�6y    � WindowStartupLocation$ CenterScreen=�6�    � 	Resources 5
      )  #FestivaliAS.ViewModels.TipViewModel   DataContext��%   &	          5   
   6   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Help��5      6<   .��5      � ���#9DA1B6 � DataContext 6   ��  �� Source# [  .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��tipGrid��5      
�������	   AutoGenerateColumns	 .  
   
IsReadOnly
 . $��22,202,28,88q�6�   $��20(�6�   $��Arial)�6�      	RowHeight$ 50Q�6  $��5��6   �� SelectedItem 6W   �� *SelektovaniTip+ �� UpdateSourceTrigger$ PropertyChanged=���6�   �� *Tipovi+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Jedinstvena oznaka��6%      MinWidth$	 200Q�6A      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Z   �� *Id+  5      $ Naziv��6%   $	 200Q�65   $ * 6D    6N   �� *Name+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Ikonica��6)   $	 200Q�6:   $ * 6I      CellTemplate 5      �� 5      .R�5      �� ��6$   �� *
IconPath+5      5        5       $
 Opis��6%   $	 200Q�63   $ * 6B    6L   �� *Opis+5$      �� 5)   
   -   5         ��Name$ FilterTipova��5)      
���iii�
�������$��2q�6W   $��Filter i pretraga��6k   $
��Left=�6�   $��DemiBold"�6�   $��	22,10,0,0q�6�   $��24(�6�   $��Arial)�6�   $	��Top=�5*      $	��133��6+   $	��804��68   .��5+      � .+�5.      �� 
���iii�$
��Left=�60   $	��Top=�6K   $	��654��6c   $
��Left=�6o   $��Center=�5/      $��20(�64   $��Arial)�6B   ���#DDE0EC
���   �$��8,30,0,0q�6}   �� 54      -   5         ��Name$ FindTip��54      $��Normal"�6*   $��	Pretraži��6>   $
��Left=�6Q   
�������$	��106��6�   $��22(�6�   $��Arial)�6�   $��667,-5,0,60q�6�   �� 55      -   5        $��
PonistiTip��55      $��Normal"�6+   $��Poništi��6?   $
��Left=�6Q   $	��106��6l   $��22(�6x   $��Arial)�6�   
�������$��
667,48,0,7q�6�   59      5:      �� 5;   
   -   5        $	 Add��5;      $��Ubaci��6K   $
��Left=�6[   
���2͚�$	��106��6�   $��22(�6�   $��Arial)�6�   $��586,547,0,21q�6�   ��6   �� *UbaciPostojeciTipCommand+6�   �� 5<   
   -   5        $ AddNovi��5<      $��Napravi novi tip��6S   $
��Left=�6n   
���2͚�$	��164��6�   $��22(�6�   $��Arial)�6�   $��22,547,0,21q�6�   ��6"   �� *KreirajNoviTipUTabeliCommand+6�   �� 5>   
   -	   5        $��Izadji��5>      $��Odustani��6O   $
��Left=�6b   $	��106��6}   $��22(�6�   $��Arial)�6�   
�������$��720,547,0,21q�6�    J� RenderTransformOrigin$ 0.575,0.976&�6�   ��6   �� *OdustaniOdUbacivanjaCommand+6�   5A      5B      
   M S B A M L   `   `   `  ����F  BFestivaliAS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:FestivaliAS.ViewModelsFestivaliAS.ViewModels  5   	   +    %FestivaliAS.PotvrdeBrisanja.ObrisiTip   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:FestivaliAS.ViewModels     5   	     � Title$  Obrisi Tip?��5   	    � Icon$- '/../Images/icons8-data-sheet-35 (1).png��6   $	��640��6M   $	��860��6Z    � 
ResizeMode$ NoResize=�6f    � WindowStartupLocation$ CenterScreen=�6|    � 	Resources 5	      3  -FestivaliAS.ViewModels.ManifestacijaViewModel   DataContext��%   &	          5
   
   6'   5      .��5      � ���#9DA1B6 � DataContext 6   ��  �� Source# [  .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��tipGrid��5      
�������   AutoGenerateColumns .     
IsReadOnly . $��22,120,28,150q�6�   $��20(�6  $��Arial)�6  	 �� SelectedItem	 6W   �� *SelektovanaManifestacija+
 �� UpdateSourceTrigger$
 PropertyChanged=���6�   �� *ManifestacijeKojeSadrzeTip+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Jedinstvena oznaka��6%      MinWidth$	 200Q�6A      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Z   �� *Id+  5      $ Naziv��6%   $	 200Q�65   $ * 6D    6N   �� *Name+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Ikonica��6)   $	 200Q�6:   $ * 6I      CellTemplate 5      �� 5      .R�5      �� ��6$   �� *
IconPath+5      5        5      $
 Opis��6%   $	 200Q�63   $ * 6B    6L   �� *Opis+5      �� 5!   
   -   5         ��Name$ FilterTipova��5!      
���iii�
�������$��2q�6W   $
��Left=�6l   $��DemiBold"�6�   $��	22,10,0,0q�6�   $��24(�6�   $��Arial)�6�   $	��Top=�5"      $��94��6+   $	��804��67   .��5#      � .+�5&      �� $_��YSelektovan tip postoji u manifestacijama. Da bi obrisao tip potrebno je izmeniti tip svih��6   $��Normal"�6|   $��20(�6�   $��Arial)�6�   $��
10,15,0,37q�6�   6�   �� 5'      $O��Imanifestacija koje su navedene u tabeli ili ih obrisati zajedno sa tipom.��6   $��Normal"�6l   $��20(�6�   $��Arial)�6�   $��10,51,-51,5q�6�   6�   5)      5*      �� 5,   
   -   5         ��Name$
 Edit��5,      $��Izmeni��6Q   $
��Left=�6b   
����ح�$	��106��6�   $��22(�6�   $��Arial)�6�   $��720,476,0,92q�6�   ��6   �� *EditManifestacijaClickCommand+6�   �� 5-   
   -   5        $ Izadji��5-      $��Odustani��6V   $
��Left=�6i   $	��106��6�   $��22(�6�   $��Arial)�6�   
�������$��720,547,0,21q�6�   ��6!   �� *" OdustaniOdBrisanjaEtiketeCommand+6�   �� 5.   
   -   5        $ Delete��5.      $��Izbriši��6W   $
��Left=�6i   
�������$��22(�6�   $��Arial)�6�   $	��106��6�   $��577,547,0,21q�6�   ��6!   �� *#!IzbrisiTipKojiSadrziManifestacije+6�   �� 5/   
   -   5        $ 	DeleteAll��5/      $*��$Izbriši tip sa svim manifestacijama��6Z   $
��Left=�6�   
�������$��22(�6�   $��Arial)�6�   $	��347��6�   $��22,476,0,92q�6�   ��6$   �� *#!ObrisiTipSaManifestacijamaCommand+6�   51      52      
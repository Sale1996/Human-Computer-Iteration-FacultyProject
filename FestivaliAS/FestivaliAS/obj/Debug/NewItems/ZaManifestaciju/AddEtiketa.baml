   M S B A M L   `   `   `  ����F  BFestivaliAS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:FestivaliAS.NewItems.ZaManifestaciju$FestivaliAS.NewItems.ZaManifestaciju  5   	   ?$clr-namespace:FestivaliAS.ViewModelsFestivaliAS.ViewModels  5   	   5    /FestivaliAS.NewItems.ZaManifestaciju.AddEtiketa   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:FestivaliAS.NewItems.ZaManifestaciju     5   	   7local1$clr-namespace:FestivaliAS.ViewModels     5   	   X TXceed.Wpf.Toolkit, Version=2.7.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  Ubaci Etiketu��5
   	    � Icon$- '/../Images/icons8-data-sheet-35 (2).png��6   $	��720��6N   $
��1200��6[    � 	Resources 5      -  'FestivaliAS.ViewModels.EtiketaViewModel   DataContext��%   &	          5   
   6"   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Help��5      6<   .��5      � ���#9DB6A4 � DataContext 6   ��  �� Source# [  .+�5   
   �� -   5         ��Name$ FilterTipova��5      
���iii�
�������$��2q�6W   $��Filter i pretraga��6k   $
��Left=�6�   $��DemiBold"�6�   $��	30,10,0,0q�6�   $��24(�6�   $��Arial)�6�   $	��Top=�5      $	��164��6+   $	��569��68   .��5      �  � ColumnDefinitions 5      �� 5      $
��497* �6'   �� 5      $
��177* �6'   .+�5      �� 
���iii�$
��Left=�60   $	��Top=�6K   $	��428��6c   $
��Left=�6o   $��Center=�5       $��20(�64   $��Arial)�6B   ���#DDECE1
���   �$��8,44,0,0q�6}   $��2��6�   �� 5'      -   5        	 ��Name$	 FindTip��5'      $��Normal"�6*   $��	Pretraži��6>   $
��Left=�6Q   
�������$	��106��6�   $��22(�6�   $��Arial)�6�   $��
30,10,0,78q�6�   $��1��6�   �� 5(      -   5        $��
PonistiTip��5(      $��Normal"�6+   $��Poništi��6?   $
��Left=�6Q   $	��106��6l   $��22(�6x   $��Arial)�6�   
�������$��
30,67,0,21q�6�   
 J� RenderTransformOrigin$
 0.052,0.643&�6�   $��1��6�   5*      5+      &   System.Windows.Controls.DataGrid  5/   
   -   5        $��tipGrid��5/      
�������   AutoGenerateColumns .     
IsReadOnly . $��30,192,593,168q�6�   $��20(�6�   $��Arial)�6     	RowHeight$ 50Q�6   �� SelectedItem 6W   �� *SelektovanaEtiketa+ �� UpdateSourceTrigger$ PropertyChanged=���6�   �� *	Etikete+   Columns 50      0  *System.Windows.Controls.DataGridTextColumn  51      ,  &System.Windows.Controls.DataGridColumn   Header$ Jedinstvena oznaka��6%      MinWidth$	 200Q�6A      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Z   �� *Id+4  .System.Windows.Controls.DataGridTemplateColumn  52      $ Boja etikete��6)   $	 200Q�6?   $ * 6N      CellTemplate 53      �� 54      .R�55      �� $	��200��6J   $��5q�6Y   ��6(   ��  �� Path$ Color�6Y   56      58        59      $
 Opis��6%   $	 200Q�63   $ * 6B    6L   �� *Opis+5=      �� 5A   
   -   5        $��Izadji��5A      $��Odustani��6   $
��Left=�62   $	��106��6M   $��22(�6Y   $��Arial)�6g   
�������$��1060,621,0,25q�6�   6�   �� 5B   
   -   5        $	 Ubaci��5B      $��Ubaci��6Q   $
��Left=�6a   
���2͚�$	��106��6�   $��22(�6�   $��Arial)�6�   $��922,621,0,25q�6�   $
 0.623,0.512&�6�   ��6    �� *UbaciPostojecuEtiketuCommand+6�   �� 5C   
   -   5        $	 	DodajNovi��5C      $��Napravi novu etiketu��6$   $
��Left=�6C   
���2͚�$	��212��6w   $��22(�6�   $��Arial)�6�   $��30,532,0,114q�6�   $
 0.646,0.136&�6�   ��6�   �� *!KreirajNovuEtiktuUTabeliCommand+�� 5D   
   -	   5        $	 Delete��5D      $��Izbriši��6Y   $
��Left=�6k   
�������$��22(�6�   $��Arial)�6�   $	��106��6�   $��1060,532,0,114q�6�   ��6!   �� *%#ObrisiEtiketuIzManifestacijeCommand+6�     5J   
   -
   5        $��EtiketeNaseManifestacije��5J      
������� .   . $��624,192,26,168q�6  $��20(�6   $��Arial)�6.  $ 50Q�6A   6K   �� *!EtiketaZaBrisanjeUManifestaciji+$ PropertyChanged=���6�   �� *EtiketeManifestacije+ 5K        5L      $ Jedinstvena oznaka��6%   $	 200Q�6A   $ * 6P    6Z   �� *Id+  5M      $ Boja etikete��6)   $	 200Q�6?   $ * 6N    5N      �� 5O      .R�5P      �� $	��200��6J   $��5q�6Y   ��6(   �� $ Color�6Y   5Q      5S        5T      $
 Opis��6%   $	 200Q�63   $ * 6B    6L   �� *Opis+5X      �� 5[   
   -   5        $ Obavestenje��5[      
���iii�
�������$��2q�6V   $
��Left=�6j   $��DemiBold"�6�   $��
624,94,0,0q�6�   $��24(�6�   $��Arial)�6�   $	��Top=�5\      $��80��6+   $	��542��67   .��5]      � .+�5^      �� $2��,Etikete koje se već nalaze u manifestaciji:��6   $��Normal"�6N   $��20(�6b   $��Arial)�6q   $��
10,25,39,0q�6�   6�   5`      5a      5d      5e      
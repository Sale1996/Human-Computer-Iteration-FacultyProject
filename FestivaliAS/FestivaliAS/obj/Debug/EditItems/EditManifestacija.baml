   M S B A M L   `   `   `  ����F  BFestivaliAS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:FestivaliAS.ViewModelsFestivaliAS.ViewModels  5   	   -    'FestivaliAS.EditItems.EditManifestacija   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:FestivaliAS.ViewModels     5   	   -   5          � Title$  Izmena Manifestacije��5	   	    � Icon$" /../Images/icons8-add-35.png��6&   $	��685��6J   $	��890��6W    � 
ResizeMode$ NoResize=�6c    � WindowStartupLocation$ CenterScreen=�6�    � 	Resources 5
      3  -FestivaliAS.ViewModels.ManifestacijaViewModel   DataContext��%   &	          5   
   6'   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Help��5      6<   .��5      �  � DataContext# [  6   $��0,0,0,0q�66   ���#B6A59D.+�5   
   �� -   5        $��IzmeniDugme��5      $��Izmeni��6Q   $
��Left=�6b   $��532,583,0,30q�6}   $	��139��6�   $��22(�6�   $��Arial)�6�   
����ح���6$   �� *EditManifestacijaCommand+6�   �� 5   
   -   5        $��	Odustani1��5      $��Odustani��6]   $
��Left=�6p   $��708,583,0,30q�6�   $	��140��6�   $��22(�6�   $��Arial)�6�   
���������6"   �� *(&OdustaniPravljenjeManifestacijeCommand+6�   �� 5   
   -   5         ��Name$ Osnovno1��5      $��Osnovno��6%   $
��Left=�66   $
��Bold"�6Q   $��	10,10,0,0q�6d   $��15(�6w   $	��Top=�5      $	��555��6+   $	��415��68   
���iii�$��2q�6Z   
�������.��5      � .+�5      �� $��Jedinstvena oznaka:��6   $��Normal"�66   $
��Left=�6J   $��20(�6e   $��Arial)�6s   $
��Auto��6�   $��	0,5,0,443q�6�   �� 5      -   5        	 ��Name$		 Id1��5      $��Normal"�6'   $
��Left=�6�   $	��Top=�6�   $	��186��6�   $
��Left=�6�   $��Center=�5      $��20(�64   $��Arial)�6B   ���#ECE0DD
���   �$��	207,5,0,0q�6}   ��5   ;   �� *#!SelektovanaManifestacijaBackup.Id+
 �� ValidatesOnDataErrors
 .  �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5   }   �� 5      $��18(�6   $
��Bold"�6&   
���  ��$��0,29,192,423q�6�   ��6I   ��  �� ElementName$	 Id1�� �� Path$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   �� 5"      $
��Ime:��6   $
��Left=�6'   $��Normal"�6B   $��20(�6V   $��Arial)�6d   $	��192��6w   $��
0,61,0,382q�6�   6�   �� 5$      -   5        $	 Name1��5$      $��Normal"�6)   $
��Left=�6�   $	��Top=�6�   $	��186��6�   $
��Left=�6�   $��Center=�5%      $��20(�64   $��Arial)�6B   ���#ECE0DD
���   �$��
207,61,0,0q�6}   ��5$   =   �� *%#SelektovanaManifestacijaBackup.Name+
 . $ PropertyChanged=�$ TwoWay=�5%   }   �� 5&      $��15(�6   $
��Bold"�6&   
���  ��$��0,90,129,364q�6�   ��6I   �� $ Name1��$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   �� 5*      $	��Tip��6   $��Normal"�6&   $
��Left=�6;   $��20(�6V   $��Arial)�6d   $	��202��6w   $��0,123,0,297q�6�   6�   �� 5+      -   5        $		 Tip��5+      
���iii�$��Normal"�6=    �� 
IsReadOnly . $
��Left=�6�   $	��Top=�6�   $	��186��6   $
��Left=�6  $��20(�6/  $��Arial)�6=  ���#ECE0DD$��207,122,0,0q�6e  ��6Q   �� *'%SelektovanaManifestacijaBackup.Tip.Id+$ PropertyChanged=�$ OneWay=�6e  �� 5,      -	   5         ��Name$ dugmeTip��5,      $��Center=�6O   $��Normal"�6r   ���#C9BDB9
���   �$��Ubaci��6�   $
��Left=�6�   $	��Top=�6�   $��20(�6�   $��
57,122,0,0q�6�   $��29��6  $��60��6  ��6+   �� *UbaciTipCommand+6,  �� 5-      -
   5        $ 	ozveziTip��5-      $��Center=�6S   $��Normal"�6v   ���#C9BDB9
���   �$��Osveži��6�   $
��Left=�6�   $	��Top=�6�   $��20(�6�   $��128,122,0,0q�6  $��29��6  $��69��6%  ��6,   �� *RefreshEditCommand+62  �� 50      $��Kategorija cena:��6   $��Normal"�63   $
��Left=�6G   $��20(�6b   $��Arial)�6p   $	��192��6�   $��0,188,0,254q�6�   6�   �� 51      -   5         ��Name$ KategorijaCena1��51      $��Normal"�64   ���#C2B9B9$
��Left=�6�   $	��Top=�6  $��20(�6  $��Arial)�6*  $��207,192,0,0q�6=  $	��186��6R  $��29��6^   �� Text 6]   �� */-SelektovanaManifestacijaBackup.KategorijaCena+
 . $ PropertyChanged=�$ TwoWay=�.@�52      �� -   5         ��Name$ 	Besplatno��52   #   $��	Besplatno��66   ���#ECE0DD6a   �� 53      -   5        $ 	NiskeCene��53   #   $��
Niske cene��66   ���#ECE0DD6b   �� 54      -   5        $ SrednjeCene��54   #   $��Srednje cene��69   ���#ECE0DD6g   �� 55      -   5        $ 
VisokeCene��55   #   $��Visoke cene��67   ���#ECE0DD6d   56      �� 57      $��18(�6   $
��Bold"�6&   
���  ��$
��Auto��6�   $��0,232,16,221q�6�   ��6I   �� $ KategorijaCena1��$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   �� 5;      $��Mesto održavanja:��6   $��Normal"�64   $
��Left=�6H   $��20(�6c   $��Arial)�6q   $	��192��6�   $��0,275,0,176q�6�   6�   �� 5<      -   5        $ MestoOdrzavanja1��5<      $��Normal"�65   ���#C2B9B9$
��Left=�6�   $	��Top=�6  $��20(�6   $��Arial)�6.  $��207,274,0,0q�6A  $	��186��6V  $��29��6b   6_   �� *0.SelektovanaManifestacijaBackup.MestoOdrzavanja+
 . $ PropertyChanged=�$ TwoWay=�.@�5=      �� -   5        $ MestoOdrzavanjaNapolju��5=   #   $��Napolju��6C   ���#ECE0DD6l   �� 5>      -   5        $ MestoOdrzavanjaUnutra��5>   #   $��Unutra��6B   ���#ECE0DD6j   5?      �� 5@      $��18(�6   $
��Bold"�6&   
���  ��$��0,308,16,140q�6�   ��6I   �� $ MestoOdrzavanja1��$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   �� 5B      $��Datum održavanja:��6   $��Normal"�64   $
��Left=�6H   $��20(�6c   $��Arial)�6q   $	��202��6�   $��0,346,0,105q�6�   6�   (  "System.Windows.Controls.DatePicker  5C      -   5        $��DatumOdržavanja1��5C      $��Normal"�6�   $
��Left=�6�   $	��Top=�6�   $��207,350,0,0q�6�   $	��186��6  $��29��6      Text 65   �� *%#SelektovanaManifestacijaBackup.Date+
 . $ PropertyChanged=�$ TwoWay=�6   �� 5E      $��Opis:��6   $��Normal"�6)   $
��Left=�6=   $��20(�6X   $��Arial)�6f   $��57��6y   $��0,429,0,-429q�6�   6�   �� 5F      $��Normal"�6   $
��Left=�6�   $��90��6�   $��
57,429,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��330��5G      $��20(�6   ���#ECE0DD$��Arial)�6A   
���   �" �� VerticalScrollBarVisibility$
 Auto=�6g   ��5F   .   �� *%#SelektovanaManifestacijaBackup.Opis+
 . $ PropertyChanged=�$ TwoWay=�5G   g   5I      5L      �� 5Q   
   -   5        $ Ikonica1��5Q      $��Ikonica��6%   $
��Left=�66   $��
439,10,0,0q�6Q   $	��Top=�5R      $	��180��6+   $	��430��68   
���iii�$��2q�6Z   
�������$��15(�6�   $
��Bold"�6�   .��5S      � .+�5T      � .+�5U      �� -   5        $ dugmeIkonica��5U      $��Normal"�6g   ���#C9BDB9
���   �$��Izaberi Ikonicu��6�   $
��Left=�6�   $	��Top=�6�   $��20(�6�   $��268,102,0,0q�6�   $��42��6  $	��140��6  ��63   �� *!AddManifestationIconEditCommand+6-  �� 5V      $��10,10,175,10q�6W   $��Stretch=�6m   $��Stretch=�6�   ��6   �� *)'SelektovanaManifestacijaBackup.IconPath+6�   5X      5Y      5Z      �� 5`   
   -   5        $ 	groupBox1��5`      $��Dodatne informacije��6&   $
��Left=�6C   $��439,195,0,0q�6^   $	��Top=�5a      $	��370��6+   $	��430��68   
���iii�$��2q�6Z   
�������$��15(�6�   $
��Bold"�6�   .��5b      � .+�5d      �� $��Normal"�6   $ ��Status služenja alkohola:��6,   $
��Left=�6P   $��20(�6k   $��Arial)�6y   $��	0,0,0,266q�6�   $	��231��6�   6�   �� 5e      -   5        $ StatusAlkohola1��5e   /   $��Normal"�6   ���#C2B9B9$
��Left=�6�   $	��Top=�6  $��20(�6  $��Arial)�6*  $��	236,4,0,0q�6=  $	��172��6P   6]   �� */-SelektovanaManifestacijaBackup.StatusAlkohola+
 . $ PropertyChanged=�$ TwoWay=�.@�5f      �� -   5        $ StatusNemaAlkohola��5f   #   $��Nema alkohola��6?   ���#ECE0DD6o   �� 5g      -   5        $ StatusMozeDoneti��5g   #   $��Alkohol se može doneti��6=   ���#ECE0DD6u   �� 5h      -   5        $ StatusKupujeNaLicuMesta��5h   #   $��Kupuje se na licu mesta��6D   ���#ECE0DD6}   5i      �� 5k      $��18(�6   $
��Bold"�6&   
���  ��$��0,33,105,233q�6�   ��6I   �� $ StatusAlkohola1��$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   �� 5n      $��Normal"�6   $/��)Da li je dostupno za hendikepirane osobe:��6,   $
��Left=�6`   $��20(�6{   $��Arial)�6�   $	��381��6�   $��
0,55,0,209q�6�   6�   	� 5o      -   5         	�Name$ Hendikepirani1��5o   2   $��Normal"�6    	� 	GroupName$ 	MyGroup11��6�   $��Da��6�   $��20(�6	  $��Arial)�6  $��105,88,254,184q�6*   d� 	IsChecked 6K   �� *86SelektovanaManifestacijaBackup.HendikepiraniDozvoljeni+
 . $ PropertyChanged=�$ TwoWay=�6*  	� 5p      $��Normal"�6   $ 	MyGroup11��6�   $��Ne��6�   $��20(�6�   $��Arial)�6  $��214,88,157,184q�6   J� RenderTransformOrigin$ 
0.431,1.44&�6.   62   �� *<:SelektovanaManifestacijaBackup.HendikepiraniNisuDozvoljeni+
 . $ PropertyChanged=�$ TwoWay=�6.  �� 5q      $
��Bold"�6   
���  ��$	��300��6�   $��8,122,110,151q�6�   ��6;   �� $ Hendikepirani1��$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   �� 5s      $��Normal"�6   $#��Da li je pušenje dozvoljeno:��6,   $
��Left=�6S   $��20(�6n   $��Arial)�6|   $��0,135,0,131q�6�   $	��261��6�   6�   	� 5t      $��Normal"�6   $ 
MyGroup111��63   $��Da��6�   $��20(�6�   $��Arial)�6�   $��105,172,260,100q�6   6J   �� *20SelektovanaManifestacijaBackup.PusenjeDozvoljeno+
 . $ PropertyChanged=�$ TwoWay=�6  	� 5u      $��Normal"�6   $ 
MyGroup111��62   $��Ne��6�   $��20(�6�   $��Arial)�6�   $ 
0.431,1.44&�6  $��214,172,149,99q�64   6I   �� *64SelektovanaManifestacijaBackup.PusenjeNijeDozvoljeno+
 . $ PropertyChanged=�$ TwoWay=�64  �� 5w      $��Etikete:��6   $��Normal"�6+   $
��Left=�6@   $��20(�6[   $��Arial)�6i   $	��192��6|   $��
0,230,0,77q�6�   6�   �� 5x      -   5        $ dugmeEtiketa��5x      $��Normal"�6Z   ���#C9BDB9
���   �$��Ubaci��6�   $
��Left=�6�   $	��Top=�6�   $��20(�6�   $��
87,230,0,0q�6�   $��29��6�   $��60��6  ��60   �� *UbaciEtiketuCommand+6  �� 5y      -   5        $ ozveziEtikete��5y      $��Center=�6^   $��Normal"�6�   ���#C9BDB9
���   �$��Osveži��6�   $
��Left=�6�   $	��Top=�6�   $��20(�6  $��158,230,0,0q�6  $��29��6$  $��69��60  ��60   �� *RefreshEditEtiketaCommand+6=  �� 5z      -   5        $ etikete��5z   �   $��Normal"�6    �� DisplayMemberPath$ Id��6s   ���#C9BDB9$
��Left=�6�   $	��Top=�6�   $��20(�6�   $��Arial)�6�   $��236,230,0,0q�6  $	��172��6  ��6/   �� $, &SelektovanaManifestacijaBackup.Etikete�6'  �� 5}      $��Normal"�6   $��Očekivana publika:��6,   $
��Left=�6I   $��20(�6d   $��Arial)�6r   $��0,280,0,-14q�6�   $	��355��6�   6�   �� 5~      -   5        $	 OcekivanaPublika1��5~   .   $��Normal"�6   $
��Left=�6�   $	��Top=�6�   $	��172��6
  $
��Left=�6  $��Center=�5      $��20(�64   $��Arial)�6B   ���#ECE0DD
���   �$��236,280,0,0q�6}   $��29��6�   ��5~   I   �� *1/SelektovanaManifestacijaBackup.OcekivanaPublika+
 . $ PropertyChanged=�$ TwoWay=�5   �   �� 5�      $��18(�6   $
��Bold"�6&   
���  ��$��0,309,-57,-1q�6�   ��6I   �� $ OcekivanaPublika1��$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   5�      5�      5�      5�      
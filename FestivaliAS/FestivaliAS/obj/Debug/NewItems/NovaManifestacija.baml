   M S B A M L   `   `   `  ����F  BFestivaliAS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:FestivaliAS.ViewModelsFestivaliAS.ViewModels  5   	   ,    &FestivaliAS.NewItems.NovaManifestacija   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:FestivaliAS.ViewModels     5   	   -   5          � Title$  Nova Manifestacija��5   	    � Icon$" /../Images/icons8-add-35.png��6$   $	��685��6I   $	��890��6V    � 
ResizeMode$ NoResize=�6w    � WindowStartupLocation$ CenterScreen=�6�    � 	Resources 5	      3  -FestivaliAS.ViewModels.ManifestacijaViewModel   DataContext��%   &	          5
   
   6'   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Help��5      6<   .��5      �  � DataContext# [  6   $��0,0,0,0q�66   ���#B6A59D.+�5   
   �� -   5        $��
DodajDugme��5      $��Dodaj��6O   $
��Left=�6_   $��532,583,0,30q�6z   $	��139��6�   $��22(�6�   $��Arial)�6�   
���2͚���6#   �� *AddManifestacijaCommand+6�   �� 5   
   -   5        $��Odustani��5      $��Odustani��6\   $
��Left=�6o   $��708,583,0,30q�6�   $	��140��6�   $��22(�6�   $��Arial)�6�   
���������6!   �� *(&OdustaniPravljenjeManifestacijeCommand+6�   �� 5   
   -   5         ��Name$ Osnovno��5      $��Osnovno��6$   $
��Left=�65   $
��Bold"�6P   $��	10,10,0,0q�6c   $��15(�6v   $	��Top=�5      $	��555��6+   $	��415��68   
���iii�$��2q�6Z   
�������.��5      � .+�5      �� $��Jedinstvena oznaka:��6   $��Normal"�66   $
��Left=�6J   $��20(�6e   $��Arial)�6s   $
��Auto��6�   $��	0,5,0,443q�6�   �� 5      -   5        	 ��Name$	 Id��5      
���iii�$��Normal"�6<   $
��Left=�6�   $	��Top=�6�   $	��186��6�   $
��Left=�6�   $��Center=�5       $��20(�64   $��Arial)�6B   ���#ECE0DD
���   �$��	207,5,0,0q�6}   ��5   P   �� *Manifestacija.Id+
 �� ValidatesOnDataErrors
 .  �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5    }   �� 5!      $��18(�6   $
��Bold"�6&   
���  ��$��0,29,10,423q�6�   ��6I   ��  �� ElementName$ Id�� �� Path$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   �� 5$      $
��Ime:��6   $
��Left=�6'   $��Normal"�6B   $��20(�6V   $��Arial)�6d   $	��192��6w   $��
0,61,0,382q�6�   6�   �� 5&      -   5        $
	 Name��5&      
���iii�$��Normal"�6>   $
��Left=�6�   $	��Top=�6�   $	��186��6�   $
��Left=�6  $��Center=�5'      $��20(�64   $��Arial)�6B   ���#ECE0DD
���   �$��
207,61,0,0q�6}   ��5&   R   �� *Manifestacija.Name+
 . $ PropertyChanged=�$ TwoWay=�5'   }   �� 5(      $��18(�6   $
��Bold"�6&   
���  ��$��0,90,10,364q�6�   ��6I   �� $
 Name��$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   �� 5+      $	��Tip��6   $��Normal"�6&   $
��Left=�6;   $��20(�6V   $��Arial)�6d   $	��192��6w   $��0,123,0,297q�6�   6�   �� 5,      -   5        $		 Tip��5,      
���iii�$��Normal"�6=    �� 
IsReadOnly . $
��Left=�6�   $	��Top=�6�   $��0��6  $
��Left=�6  $��20(�65  $��Arial)�6C  ���#ECE0DD$��207,122,0,0q�6k  $��0��6�   J� RenderTransformOrigin$ 0.5,0.5&�6�  ��6Q   �� *Manifestacija.Tip+
 . $ PropertyChanged=�$ OneWay=�.��6�  5.      �� 5/      -	   5        $	 TipID��5/      
���iii�$��Normal"�6?    . $
��Left=�6�   $	��Top=�6�   $	��186��6  $
��Left=�6  $��20(�6<  $��Arial)�6J  ���#ECE0DD$��207,122,0,0q�6r  ��6S   �� *Manifestacija.Tip.Id+
 . $ PropertyChanged=�$ OneWay=�6r  �� 51      -
   5         ��Name$ dugmeTip��51      $��Center=�6O   $��Normal"�6r   ���#C9BDB9
���   �$��Ubaci��6�   $
��Left=�6�   $	��Top=�6�   $��20(�6�   $��
57,122,0,0q�6�   $��29��6  $��60��6  ��6+   �� *UbaciTipCommand+6,  �� 52      -   5        $ 	ozveziTip��52      $��Center=�6O   $��Normal"�6r   ���#C9BDB9
���   �$��Osveži��6�   $
��Left=�6�   $	��Top=�6�   $��20(�6�   $��128,122,0,0q�6   $��29��6  $��69��6!  ��6,   �� *RefreshCommand+6.  �� 53      $��18(�6   $
��Bold"�6&   
���  ��$��0,151,10,303q�6�   ��6I   �� $	 Tip��$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   �� 57      $��Kategorija cena:��6   $��Normal"�63   $
��Left=�6G   $��20(�6b   $��Arial)�6p   $	��192��6�   $��0,188,0,254q�6�   6�   �� 58      -   5         ��Name$ KategorijaCena��58      
���iii�$��Normal"�6I   ���#C9BDB9$
��Left=�6�   $	��Top=�6	  $��20(�6!  $��Arial)�6/  $��207,192,0,0q�6B  $	��186��6W  $��30��6c   �� Text 6r   �� *Manifestacija.KategorijaCena+
 . $ PropertyChanged=�$ TwoWay=�.@�59      �� $��	Besplatno��6#   ���#ECE0DD6N   �� 5:      $��
Niske cene��6#   ���#ECE0DD6O   �� 5;      $��Srednje cene��6#   ���#ECE0DD6Q   �� 5<      $��Visoke cene��6#   ���#ECE0DD6P   5=      �� 5>      $��18(�6   $
��Bold"�6&   
���  ��$
��Auto��6�   $��0,232,10,221q�6�   ��6I   �� $ KategorijaCena��$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   �� 5B      $��Mesto održavanja:��6   $��Normal"�64   $
��Left=�6H   $��20(�6c   $��Arial)�6q   $	��192��6�   $��0,275,0,176q�6�   6�   �� 5C      -   5        $ MestoOdrzavanja��5C      
���iii�$��Normal"�6J   ���#C9BDB9$
��Left=�6�   $	��Top=�6  $��20(�6$  $��Arial)�62  $��207,274,0,0q�6E  $	��186��6Z  $��29��6f   6t   �� *Manifestacija.MestoOdrzavanja+
 . $ PropertyChanged=�$ TwoWay=�.@�5D      �� $��Napolju��6#   ���#ECE0DD6L   �� 5E      $��Unutra��6#   ���#ECE0DD6K   5F      �� 5G      $��18(�6   $
��Bold"�6&   
���  ��$��0,308,10,140q�6�   ��6I   �� $ MestoOdrzavanja��$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   �� 5I      $��Datum održavanja:��6   $��Normal"�64   $
��Left=�6H   $��20(�6c   $��Arial)�6q   $	��192��6�   $��0,346,0,105q�6�   6�   (  "System.Windows.Controls.DatePicker  5J      -   5        $��DatumOdrzavanja��5J      
���iii�$��Normal"�6�   $
��Left=�6�   $	��Top=�6�   $��207,350,0,0q�6  $	��186��6,  $��29��68     Text 6J   �� *Manifestacija.Date+
 . $ PropertyChanged=�$ TwoWay=� �� TargetNullValue$  ��68  �� 5K      -   5        $	 DatumString��5K      
���iii�$��Normal"�6E   $
��Left=�6�   $	��Top=�6�   $��0��6�   $��0��6	  $
��Left=�6  $��	7,374,0,0q�66  ��6Y   �� *Manifestacija.Datum+
 . $ PropertyChanged=�$ TwoWay=�66  �� 5M      $��18(�6   $
��Bold"�6&   
���  ��$��0,372,72,76q�6�   ��6I   �� $ DatumString��$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   �� 5P      $��Opis:��6   $��Normal"�6)   $
��Left=�6=   $��20(�6X   $��Arial)�6f   $��57��6y   $��0,429,0,-429q�6�   6�   �� 5Q      $��Normal"�6   
���iii�$
��Left=�6�   $��90��6�   $��
57,429,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6  $	��336��5R      $��20(�6   ���#E8DCDC$��Arial)�6A   
���   �" �� VerticalScrollBarVisibility$
 Auto=�6g   ��5Q   D   �� *Manifestacija.Opis+
 . $ PropertyChanged=�$ TwoWay=�5R   g   5T      5W      �� 5[   
   -   5        $ Ikonica��5[      $��Ikonica��6$   $
��Left=�65   $��
439,10,0,0q�6P   $	��Top=�5\      $	��180��6+   $	��430��68   
���iii�$��2q�6Z   
�������$��15(�6�   $
��Bold"�6�   .��5]      � .+�5^      �� -   5        $ dugmeIkonica��5^      $��Normal"�6X   ���#C9BDB9
���   �$��Izaberi Ikonicu��6�   $
��Left=�6�   $	��Top=�6�   $��20(�6�   $��268,102,0,0q�6�   $��42��6  $	��140��6  ��6/   �� *AddManifestationIcon+6  �� 5_      $��10,10,175,10q�6B   $��Stretch=�6X   $��Stretch=�6v   ��6   �� *Manifestacija.IconPath+6v   5a      5b      �� 5f   
   -   5        $ groupBox��5f      $��Dodatne informacije��6%   $
��Left=�6B   $��439,195,0,0q�6]   $	��Top=�5g      $	��370��6+   $	��430��68   
���iii�$��2q�6Z   
�������$��15(�6�   $
��Bold"�6�   .��5h      � .+�5j      �� $��Normal"�6   $ ��Status služenja alkohola:��6,   $
��Left=�6P   $��20(�6k   $��Arial)�6y   $��	0,0,0,266q�6�   $	��231��6�   6�   �� 5k      -   5        $ StatusAlkohola��5k   /   $��Normal"�6   ���#C9BDB9$
��Left=�6�   $	��Top=�6�   $��20(�6
  $��Arial)�6  $��	236,4,0,0q�6+  $	��172��6>   6\   �� *Manifestacija.StatusAlkohola+
 . $ PropertyChanged=�$ TwoWay=�.@�5l      �� $��Nema alkohola��6#   ���#ECE0DD6S   �� 5m      $��Alkohol se može doneti��6#   ���#ECE0DD6\   �� 5n      $��Kupuje se na licu mesta��6#   ���#ECE0DD6\   5o      �� 5q      $��18(�6   $
��Bold"�6&   
���  ��$��0,33,44,233q�6�   ��6I   �� $ StatusAlkohola��$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   �� 5t      $��Normal"�6   $/��)Da li je dostupno za hendikepirane osobe:��6,   $
��Left=�6`   $��20(�6{   $��Arial)�6�   $	��381��6�   $��
0,55,0,209q�6�   6�   	� 5u      -   5         	�Name$ Hendikepirani��5u   2   $��Normal"�6    	� 	GroupName$ MyGroup��6�   $��Da��6�   $��20(�6�   $��Arial)�6  $��105,88,254,228q�6   d� 	IsChecked 6J   �� *'%Manifestacija.HendikepiraniDozvoljeni+
 . $ PropertyChanged=�$ TwoWay=�6  	� 5v      -   5        $��Normal"�5v      $ MyGroup��6�   $��Ne��6�   $��20(�6  $��Arial)�6  $��214,88,149,228q�6"  $ 
0.431,1.44&�6:   6Q   �� *+)Manifestacija.HendikepiraniNisuDozvoljeni+
 . $ PropertyChanged=�$ TwoWay=�6:  �� 5w      $
��Bold"�6   $��18(�6*   
���  ��$��0,114,0,159q�6�   ��6I   �� $ Hendikepirani��$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   �� 5y      $��Normal"�6   $#��Da li je pušenje dozvoljeno:��6,   $
��Left=�6S   $��20(�6n   $��Arial)�6|   $��0,135,0,172q�6�   $	��261��6�   6�   	� 5z      -   5        $ Pusenje��5z   2   $��Normal"�6   $ MyGroup1��6E   $��Da��6�   $��20(�6�   $��Arial)�6�   $��105,172,260,149q�6   6Z   �� *!Manifestacija.PusenjeDozvoljeno+
 . $ PropertyChanged=�$ TwoWay=�6  	� 5{      -   5        $��Normal"�5{      $ MyGroup1��6K   $��Ne��6�   $��20(�6�   $��Arial)�6  $ 
0.431,1.44&�6  $��214,172,149,149q�6:   6`   �� *%#Manifestacija.PusenjeNijeDozvoljeno+
 . $ PropertyChanged=�$ TwoWay=�6:  �� 5|      $
��Bold"�6   $��18(�6*   
���  ��$��
0,195,0,78q�6�   ��6I   �� $ Pusenje��$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   �� 5      $��Etikete:��6   $��Normal"�6+   $
��Left=�6@   $��20(�6[   $��Arial)�6i   $	��192��6|   $��
0,230,0,77q�6�   6�   �� 5�      -   5        $ dugmeEtiketa��5�      $��Normal"�6X   ���#C9BDB9
���   �$��Ubaci��6�   $
��Left=�6�   $	��Top=�6�   $��20(�6�   $��
87,230,0,0q�6�   $��29��6�   $��60��6  ��6/   �� *UbaciEtiketuCommand+6  �� 5�      -   5        $ ozveziEtikete��5�      $��Center=�6Z   $��Normal"�6}   ���#C9BDB9
���   �$��Osveži��6�   $
��Left=�6�   $	��Top=�6�   $��20(�6�   $��158,230,0,0q�6  $��29��6   $��69��6,  ��60   �� *RefreshEtiketaCommand+69  �� 5�      -   5        $ etikete��5�   /   $��Normal"�6    �� DisplayMemberPath$ Id��6s   ���#C9BDB9 �� 
IsReadOnly . $
��Left=�6�   $	��Top=�6�   $��20(�6�   $��Arial)�6�   $��236,230,0,0q�6  $	��172��6  ��6@   �� $ Manifestacija.Etikete�5�      �� 5�      $��Normal"�6   $��Očekivana publika:��6,   $
��Left=�6I   $��20(�6d   $��Arial)�6r   $��0,280,0,-14q�6�   $	��355��6�   6�   �� 5�      -   5        $	 OcekivanaPublika��5�   D   $��Normal"�6   
���iii�$
��Left=�6�   $	��Top=�6�   $	��172��6  $
��Left=�6  $��Center=�5�      $��20(�64   $��Arial)�6B   ���#ECE0DD
���   �$��236,280,0,0q�6}   $��29��6�   ��5�   ^   �� * Manifestacija.OcekivanaPublika+
 . $ PropertyChanged=�$ TwoWay=�5�   �   �� 5�      $��18(�6   $
��Bold"�6&   
���  ��$��0,309,-57,-1q�6�   ��6I   �� $ OcekivanaPublika��$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   5�      5�      5�      5�      
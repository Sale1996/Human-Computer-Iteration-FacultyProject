   M S B A M L   `   `   `  ����F  BFestivaliAS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:FestivaliAS.ViewModelsFestivaliAS.ViewModels  5   	   "    FestivaliAS.NewItems.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:FestivaliAS.ViewModels     5   	     � Title$  Unost tipa manifestacije��5   	    � Icon$  /../Images/icons8-t-35.png��6*   $	��370��6M   $	��930��6Z    � 
ResizeMode$ NoResize=�6f    � WindowStartupLocation$ CenterScreen=�5	   	    � 	Resources 5      )  #FestivaliAS.ViewModels.TipViewModel   DataContext��%   &	          5   
   6   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Help��5      6<   .��5      �  � DataContext# [  6   $��0,0,0,0q�66   ���#9DA1B6.+�5   
   �� -   5        $��
DodajDugme��5      $��Dodaj��6F   $
��Left=�6V   $	��106��6q   $��22(�6}   $��Arial)�6�   
���2͚�$��672,279,0,19q�6�   ��6$   �� *AddTipCommand+6�   �� 5   
   -   5        $��Odustani��5      $��Odustani��6!   $
��Left=�64   $	��106��6O   $��22(�6[   $��Arial)�6i   
�������$��802,280,0,19q�6�    J� RenderTransformOrigin$ 2.835,0.407&�6�   �� 5   
   -   5        	 ��Name$	 Osnovno��5      $��Osnovno��6$   
���iii�$��2q�6K   
�������$��15(�6w   $
��Bold"�6�   $��10,13,474,39q�6�   $��2��6�   .��5      � .+�5      �� $��Jedinstvena oznaka:��6   $
��Left=�66   $��Normal"�6Q   $��20(�6e   $��Arial)�6s   $��0,6,0,-6q�6�   �� 5      -   5        
 ��Name$
 	IdTextBox��5       � ToolTip$y sOvde unesi identifikacionu oznaku koja se sastoji iz slova, brojeva, donje crte i da joj maksimalna dužina bude 15��6.   $��Normal"�6�   
���iii�$
��Left=�6=  $	��Top=�6X  $	��186��6p  $
��Left=�6|  $��Center=�5      $��20(�64   $��Arial)�6B   ���#DDE0EC
���   �$��
216,10,0,0q�6}   ��5   �   �� *Tip.Id+ �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5   }   �� 5       $��18(�6   $
��Bold"�6&   
���  ��$��0,36,26,178q�6�   ��6I   ��  �� ElementName$ 	IdTextBox�� �� Path$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   �� 5"      $
��Ime:��6   $��Normal"�6'   $
��Left=�6;   $��20(�6V   $��Arial)�6d   $	��142��6w   $
��Auto��6�   $��
0,72,0,143q�6�   �� 5#      -   5        $
 
ImeTextBox��5#   �   $��Normal"�6   $9 3Ovde unesi ime tipa koje nije duže od 15 karaktera��6.   
���iii�$
��Left=�6�   $	��Top=�6  $	��186��60  $
��Left=�6<  $��Center=�5$      $��20(�64   $��Arial)�6B   ���#DDE0EC
���   �$��
216,72,0,0q�6}   ��5#   �   �� *
Tip.Name+ . $ PropertyChanged=�$ TwoWay=�5$   }   �� 5%      $��18(�6   $
��Bold"�6&   
���  ��$��0,106,129,108q�6�   ��6I   �� $ 
ImeTextBox��$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   �� 5(      $��Opis:��6   $��Normal"�6(   $
��Left=�6<   $��20(�6W   $��Arial)�6e   $
��Auto��6x   $
��Auto��6�   $��0,140,0,-140q�6�   �� 5)      $
��Left=�6   $ Ovde unesi opis tipa��65   
���iii�$��90��6j   $��Normal"�6v   $��
62,145,0,0q�6�    �� TextWrapping$
 Wrap=�6  $	��Top=�6  $	��340��5*      $��20(�6   ���#DDE0EC$��Arial)�6A   
���   �" �� VerticalScrollBarVisibility$
 Auto=�6g   ��5)   �   �� *
Tip.Opis+ . $ PropertyChanged=�$ TwoWay=�5*   g   5-      5/      �� 52   
   -   5        $	 Ikonica��52      $��Ikonica��6$   $
��Left=�65   $��
478,13,0,0q�6P   $	��Top=�53      $	��180��6+   $	��430��68   
���iii�$��2q�6Z   
�������$��15(�6�   $
��Bold"�6�   .��54      � .+�55      �� -   5         ��Name$ dugmeIkonica��55      $4 .Preko ovog dugmeta se vrši izbor ikonice tipa��6/   $��Normal"�6�   ���#B9BCC9
���   �$��Izaberi Ikonicu��6�   $
��Left=�6�   $	��Top=�6�   $��20(�6  $��268,102,0,0q�6  $��42��62  $	��140��6>  ��6g   �� *
AddTipIcon+6L  �� 56      -	   5         ��Name$ IconPath��56      $��10,10,175,10q�6L   $��Stretch=�6b   $��Stretch=�6�   ��6,   �� *Tip.IconPath+6�   �� 57      -
   5        $
 IkonicaTipa1��57      $��Normal"�61   
���iii�$��0��6�   $��0��6�   $��0,0,408,152q�6�   ��6\   �� *Tip.IconPath+ . $ PropertyChanged=�6�   �� 59      $��18(�6   $
��Bold"�6&   
���  ��$��
0,0,10,111q�6�   ��6I   �� $ IkonicaTipa1��$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   5;      5<      5>      5?      
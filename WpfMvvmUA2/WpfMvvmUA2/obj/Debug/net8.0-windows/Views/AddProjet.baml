   M S B A M L   `   `   `  ����E  AWpfMvvmUA2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WpfMvvmUA2.ViewsWpfMvvmUA2.Views  5   	        WpfMvvmUA2.Views.AddProjet   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WpfMvvmUA2.Views     5   	     � Title$  	AddProjet��5   	   $	��300��6   $	��450��6(   .��5	      � .+�5
   
   �� .+�5      �� $��Titre de projet��6   $��	44,37,0,0q�6.   $	��Top=�6A   $
��Left=�6Y   �� 5      $��30��6.   $	��202��6:   $��1q�6F   ���#E0E0E0$
��Left=�6p   $��	44,20,0,0q�6�   ��6   �� *Titre+6�   5      �� 5   
   .+�5      �� $��Avancement de projet��6   $��
44,137,0,0q�63   $	��Top=�6G   $
��Left=�6_   �� 5      -   5         ��Name$ status��5      $
��Left=�6'   $��	44,17,0,0q�6B   $	��Top=�6U   $	��297��6m    � Minimum$ 0Q�6y    � Maximum$	 100Q�6�   $��26��6�    �� TickPlacement$ BottomRight=�5       �� TickFrequency$ 10Q�61    � Value$ 0Q�6D   5      �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5      �� $��Progression: ��6   $��
44,215,2,1q�6-   $��76��6A   �� 5      $��
0,200,10,1q�6   $	��178��6r   $��32��6~   ��6(   ��  �� ElementName$ status��	 �� Path$	 Value�
 �� StringFormat$
 {0:0}%��6~   5      �� 5   
   $��30��6   $	��Add��6C   $��70��6Q   $��Center=�6\   $��5q�6~   $��25q�5      $��Bottom=�6   $��Right=�6-   $��1q�6I   ���#E0E0E0��5      �� *AddProjetCommand+5      5       5!      
   M S B A M L   `   `   `  ����E  AWpfMvvmUA2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WpfMvvmUA2.ViewsWpfMvvmUA2.Views  5          WpfMvvmUA2.Views.Membres   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:WpfMvvmUA2.Views     5        N� Title$  Membres��5	       N� 
Background �#F2F2F2.��5
      �  � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $��40 �6   �� 5      $��* �6   .+�5   
   ]� $��0��6   .+�5      �� $��Liste des Membres��6   $��26(�61   $��	30,30,0,0q�6?   �� 5      $��30��6   $��
Add Membre��6I   $	��105��6^   $��Center=�6j   $��5q�6�   $��	0,25,25,0q�5      $	��Top=�6   $��Right=�60   $��1q�6L   ���#E0E0E0��5   !   �� *ShowAddMembreWindow+5      5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   $��Center=�5      .+�5      �� $��Filtrer par Nom��6   $��14(�6/   $��0,5,5,5q�6=   �� 5      -   5        $��FilterTextBox��5      $��30��6+   $	��200��67   $��5,5,25,5q�6C   $	��Top=�6U   $��Right=�5      $��1q�6!   ���#E0E0E0��6L   �� *
FilterText+ �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5   
   -   5        $��
MembreList��5       $��2��6   
������ $��25q�6t   $��0q�6�   ��62   �� *FilteredMembres+ �� View 5      �� 5      .P�5       �� $	��Nom��6K    �� Width$	 100��6X    �� DisplayMemberBinding 6%   �� *Nom+6X   �� 5!      $��Prenom��6N   $	 100��6^    6%   �� *Prenom+6^   �� 5"      $
��Role��6L   $	 250��6Z    6%   �� *Role+6Z   �� 5#      $��Email��6M   $	 150��6\    6%   �� *Email+6\   �� 5%      $��Actions��6%   $ 50��66    �� CellTemplate 5&      �� 5'      .R�5(   "   ��    ActionButtonStyle#��[  5*   &   ���#bd0921��5(   )   �� *DataContext.DeleteMembre+	 �� RelativeSource	 �� 
 �� AncestorType
 ListView��5)   )   �� .��5+   &   F�   
DeleteIcon#��[ 6+   $��12��6N   $��12��6Z   $��2q�6e   
������� �� Stretch$ Uniform=�6}   $��Center=�6�   5,   #   5-      5/      50      52      53      54      
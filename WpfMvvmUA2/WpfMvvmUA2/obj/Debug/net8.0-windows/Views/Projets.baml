   M S B A M L   `   `   `  ����E  AWpfMvvmUA2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WpfMvvmUA2.ViewsWpfMvvmUA2.Views  5          WpfMvvmUA2.Views.Projets   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:WpfMvvmUA2.Views     5        N� Title$  Projets��5	       N� 
Background �#F2F2F2.��5      �  � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $��40 �6   �� 5      $��* �6   .+�5   
   ]� $��0��6   .+�5      �� $��Projets��6   $��26(�6'   $��	30,30,0,0q�65   �� 5      $��30��6   $��
Add Projet��6@   $	��105��6U   $��Center=�6a   $��5q�6�   $��	0,25,25,0q�5      $	��Top=�6"   $��Right=�6:   $��1q�6V   ���#E0E0E0��5   !   �� *
ShowWindow+5      5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   $��Center=�5      .+�5      �� $��Filtrer par Nom��6   $��14(�6/   $��0,5,5,5q�6=   �� 5      -   5        $��FilterTextBox��5      $��30��6+   $	��200��67   $��5,5,25,5q�6C   $	��Top=�6U   $��Right=�5      $��1q�6/   ���#E0E0E0��6Y   �� *
FilterText+ �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5   
   -   5        $��
ProjetList��5       $��2��6   
������ $��25q�6t   $��0q�6�   ��62   �� *FilteredProjets+ �� View 5      �� 5      .P�5!      �� $	��Nom��6M    �� Width$	 150��6Z    �� DisplayMemberBinding 6%   �� *Titre+6Z   �� 5"      $��
Avancement��6%   $	 200��69    �� CellTemplate 5#      �� 5$      .R�5%   "   �� $ 
Horizontal=�6-   $��Right=�6F   $	��Top=�6b   .+�5&   &   � 	 �Name$	 
progresBar��62   $��20��6F   $	��100��6R   $��5,0,5,0q�6^   
 � Value
 6p   �� *status+�� 5'   &   $��Center=�6w   $��Center=�6�   $��5,0,0,0q�6�   ��60   ��  �� ElementName$ status�� �� Path$ Value� �� StringFormat$ {0:0}%��6�   5(   #   5)      5+      �� 5.      $��Actions��6%   $ 50��66    5/      �� 50      .R�51   "   ��    ActionButtonStyle#��[  6)   ���#bd0921.��52   &   F�   
DeleteIcon#��[ 6+   $��12��6N   $��12��6Z   $��2q�6e   
������� �� Stretch$ Uniform=�53   -   $��Center=�6?   54   #   55      57      58      5:      5;      5<      
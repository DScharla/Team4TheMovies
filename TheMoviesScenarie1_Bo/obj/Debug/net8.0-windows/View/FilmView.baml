   M S B A M L   `   `   `  ����P  LTheMoviesScenarie1_Bo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TheMoviesScenarie1_BoTheMoviesScenarie1_Bo  5   	   $    TheMoviesScenarie1_Bo.FilmView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:TheMoviesScenarie1_Bo     5   	     � Title$  FilmView��5   	   $	��225��6   $	��450��6'   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��23* �6   �� 5      $	��77* �6   .+�5   
   �� -   5         ��Name$ btnOk��5      $��OK��6    $
��Left=�6-   $��
25,144,0,0q�6H   $	��Top=�6\   $	��175��6t   $��2��6�   6�   �� 5   
   -   5        $ 	btnCancel��5      $��Fortryd��6$   $
��Left=�66   $��113,144,0,0q�6Q   $	��Top=�6f    J� RenderTransformOrigin$ 4.127,0.115&�6~   $	��175��6�   $��1��6�   6�   �� 5   
   -   5         ��Name$ 
txtboxName��5      $
��Left=�6&   $��2,46,0,0q�6A    �� TextWrapping$
 Wrap=�6S   $	��Top=�6�   $	��286��6�   $��1��6�   ��6g   �� *Title+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $ txtboxGenre��5      $
��Left=�6'   $��2,73,0,0q�6B   $
 Wrap=�6T   $	��Top=�6�   $	��286��6�   $��1��6�   ��6h   �� *Genre+$ PropertyChanged=�6�   �� 5   
   -   5        $ txtboxDuration��5      $
��Left=�6*   $��2,99,0,0q�6E   $
 Wrap=�6W   $	��Top=�6�   $	��286��6�   $��1��6�   ��6k   �� *
Duration+$ PropertyChanged=�6�   �� 5   
   $$��Tilføj ny film til registeret��6   $
��Left=�68   $��	36,10,0,0q�6S   $	��Top=�6f   $	��150��6~   $��1��6�   �� 5   
   $
��Navn��6   $
��Left=�6   $��	25,42,0,0q�6:   $	��Top=�6M   �� 5   
   $��Genre��6   $
��Left=�6    $��	25,69,0,0q�6;   $	��Top=�6N   �� 5   
   $��Varighed��6   $
��Left=�6#   $��	25,95,0,0q�6>   $	��Top=�6Q   5      5      
   M S B A M L   `   `   `  ����P  LNavigation Drawer App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Navigation_Drawer_AppNavigation_Drawer_App  5   	   !    Navigation_Drawer_App.Login   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Navigation_Drawer_App     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Login��5	   	   $	��434��6   $	��800��6$    � WindowStartupLocation$ CenterScreen=�60    � WindowStyle$
 None=�6U    � 
ResizeMode$ NoResize=�6h   .��5
      � .+�5   
   �� $	��390��6   $	��Top=�6    �� CornerRadius$ 	0 0 180 0��66   
�������5      �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5      �� $	��350��6   ���	#FF5D5454.+�5      �� $��Assets/L2.png��6   $	��205��6/   $	��Top=�6<   $��40,100,40,100q�6T   $
��Fill=�6k    � ForceCursor . 6z   5      �� 5      $	��339��6   $��
0,0,0,-0.4q�6%   .+�5      �� $��52,100,-25.8,40q�6   $	��293��66   .+�5      �� $��Se Connecter��6    $��20,20,10,40q�64   ���	#FF2B8AF9 �� TextAlignment$ Center=�6`   $��38(�6w   $��Great Vibes)�6�   �� 5      $ 
Horizontal=�6!   $��10q�6:   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�62   $��40��6>   $��34��6I   ���#2B8AF96U   �� 5      -   5        	 ��Name$	 txtUsername��5   "   $
��10 0q�67   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Username��6E   
���   �$	��250��6�   
���   � �� 
CaretBrush �#4FB0ED �� SelectionBrush �#4FB0ED$��23��6�   5      �� 5      $ 
Horizontal=�6!   $��10q�6:   .+�5        $
 Lock=�62   $��40��6>   $��34��6I   ���#2B8AF96U   G� 5      -   5         G�Name$ txtPassword��5   &   $
��10 0q�6;   $
 Mot de passe��6I   
���   �$	��250��6�   
���   � G� 
CaretBrush �#4FB0ED G� SelectionBrush �#4FB0ED$��23��6�   5      �� 5      $��Center=�6!   $��	50,20,0,0q�6>   .+�5      �� -   5         ��Name$ 	btnSubmit��5    T   $	��231��5   !   $��40��6-    $   MaterialDesignFlatAccentBgButton#��[  69   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5      $��2q�6H   ���	#FF2B8AF9���	#FF2B8AF9
������� � ToolTip$ Login��5    D   $��	Connecter��6   $��20(�6�   5!      5"      5#      �� 5$      $��50��6   $��50,10,0,372.6q�6$   .+�5%      �� -   5        $ btnExit��5&   "   $��
5,10,4.6,0q�5%       & "MaterialDesignFloatingActionButton#��[ 6-   $ Close��5&      $��35��6I   $��40��6U    J� RenderTransformOrigin$ 0.845,0.433&�6`   ��5%   i   Z� .��5'        $ Close=�6.   
���   �$��25��6N   $��25��6Y   5(      5)      5*      5+      5,      
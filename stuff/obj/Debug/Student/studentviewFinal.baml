   M S B A M L   `   `   `  ����H  DCS317_project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CS317_project.StudentCS317_project.Student  5      ,    &CS317_project.Student.studentviewFinal   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:CS317_project.Student     5      .��5	      � ��5
   
   �� 5        �� ImageSource$)  #/CS317_project;component/img/bg.jpg��6   .+�5   
   �� -   5         ��Name$ txtQuestion��5      $
��Left=�6)   $
��Wrap=�6D   $	��Top=�6X   $��	42,71,0,0q�6p   $��98��6�   $	��476��6�   
������� J� OpacityMask 5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5      $ White��6#   $ 1Q�61   5      5      �� 5   
   -   5         ��Name$ label��5      $��Answer:��6   $
��Left=�61   $��
42,171,0,0q�6L   $	��Top=�6`   $y�Hidden=�6x   	� 5   
   -   5         	�Name$ 	radioTrue��5      $
��True��6)   $
��Left=�68   $��
42,197,0,0q�6S   $	��Top=�6g   	 	� 	GroupName$	 tf��6   $y�Hidden=�6�   	� 5   
   -   5        $ 
radioFalse��5      $��False��6*   $
��Left=�6:   $��
98,197,0,0q�6U   $	��Top=�6i   $	 tf��6�   $y�Hidden=�6�   
 J� RenderTransformOrigin$
 0.538,-0.689&�6�   	� 5   
   -   5        $ radioA1��5      $�� ��6'   $
��Left=�62   $��182,174,0,0q�6M   $	��Top=�6b   $	 mc��6z   $y�Hidden=�6�   	� 5   
   -   5        $ radioA2��5      $�� ��6'   $
��Left=�62   $��182,206,0,0q�6M   $	��Top=�6b   $	 mc��6z   $y�Hidden=�6�   	� 5   
   -   5        $ radioA3��5      $�� ��6'   $
��Left=�62   $��182,236,0,0q�6M   $	��Top=�6b   $	 mc��6z   $y�Hidden=�6�   	� 5   
   -   5        $ radioA4��5      $�� ��6'   $
��Left=�62   $��182,267,0,0q�6M   $	��Top=�6b   $	 mc��6z   $y�Hidden=�6�   �� 5   
   -	   5         ��Name$ 	txtAnswer��5      $
��Left=�6%   $��55��6@   $��
42,196,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��476��6�   $y�Hidden=�6�   �� 5   
   -
   5         ��Name$ 	btnSubmit��5      $��Submit Answer��6$   $
��Left=�6<   $��457,385,0,0q�6W   $	��Top=�6l   $	��125��6�   $��40��6�   $y�Hidden=�6�   �� 5   
   -   5         ��Name$ listQuiz��5      $
��Left=�6$   $	��110��6?   $��
42,307,0,0q�6L   $	��Top=�6`   $	��254��6x   ��5       �� 5!      .R�5"      ��  �� Orientation$ 
Horizontal=�6!   .+�5%      �� ��6$   �� *
question+5'      5(      5*      � 5+   
   -   5         �Name$ progbar1��5+      $
��Left=�6)   $��26��6D   $��	42,40,0,0q�6P   $	��Top=�6c   $	��476��6{   �� 5,   
   -   5        $ lblqs��5,      $��Click on a Question��6   $
��Left=�6=   $��
42,276,0,0q�6X   $	��Top=�6l   $	��254��6�   $��16(�6�   �� 5-   
   -   5        $ bttnexit��5-      $
��Exit��6#   $
��Left=�62   $��
507,10,0,0q�6M   $	��Top=�6a   $��75��6y   6�   5/      50      
   M S B A M L   `   `   `  ����   WPFCadastroDeClientes.Client-    'WPFCadastroDeClientes.Client.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      � -   5         �Name$ ApagarButton��5       � ColumnDefinitions 5   
   �� 5      $
��228* �6   �� 5      $
��289* �6   .+�5
   
   �� -   5         ��Name$ ClientesListBox��5
      $
��Left=�6+   $	��258��6F   $��	10,51,0,0q�6S   $	��Top=�6f   $	��117��6~   ��5   
   �� 5      .R�5      �� .+�5      �� ��6    �� *Nome+�� 5      ��6    �� *	Sobrenome+5      5      5      �� 5   
   -   5         ��Name$ CarregarButton��5      $��Carregar Clientes��6)   $
��Left=�6E   $��	10,14,0,0q�6`   $	��Top=�6s   $	��117��6�   6�   �� 5   
   $��Nome:��6   $
��Left=�6    $��	98,11,0,0q�6;   $	��Top=�6N   $��1��6f   �� 5   
   $��
Sobrenome:��6   $
��Left=�6%   $��	69,41,0,0q�6@   $	��Top=�6S   $��1��6k   �� 5   
   -   5         ��Name$ NomeTextBox��5      $
��Left=�6'   $��23��6B   $��
159,15,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��120��6�   $��1��6�   �� 5   
   -   5        $ SobrenomeTextBox��5      $
��Left=�6,   $��23��6G   $��
159,43,0,0q�6S   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   $��1��6�   �� 5   
   -   5        $ SalvarButton��5      $��Salvar��6'   $
��Left=�68   $��
159,71,0,0q�6S   $	��Top=�6g   $��75��6   $��1��6�   �� 5   
   -   5        $��Apagar��5      $
��Left=�6"   $��
153,14,0,0q�6=   $	��Top=�6Q   $��75��6i   6t   �� 5   
   -   5        $ AtualizarButton��5      $��	Atualizar��6*   $��1��6>   $
��Left=�6N   $��159,105,0,0q�6i   $	��Top=�6~   $��75��6�   6�   � 5    
   -	   5         �Name$ ProgressBar��5       $��2��6+   $
��Left=�6?   $��44��6Z   $��
168,91,0,0q�6f   $	��Top=�6z   $	��125��6�    � IsIndeterminate . 6�   5"      5#      
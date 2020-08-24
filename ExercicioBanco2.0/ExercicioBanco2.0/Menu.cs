using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Principais
{
    sealed class Menu
    {

        public void Opcoes(int opcoes)
        {
            while(opcoes != 5)
            {
                switch (opcoes)
                {
                    case 1:
                        
                        Cor.AbrirCor("ok");
                        Console.Write("Opção Escolhida: Cadastrar Cliente"); Cor.FecharCor();
                        Cadastro cadastro = new Cadastro();
                        cadastro.PedirInfoCadastro();

                        break;
                }



                break;
            }
        }
    }
}

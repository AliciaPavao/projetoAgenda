using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.VariableGlobal
{
    // Publica para todas poderem usar
    // Estatica para todos poderem usar a mesma classe
    public static class UserSession
    {
        // private só pode usar dentro da sessão publico qualquer um pode usar
        // se uma classe é estatica só existe uma
        // se ela é publica (e estatica) qualquer um pode guardar numeros ali (porem apenas 1)
        // Classe estatica não pode usar .this

        // _ antes dos nomes privados apenas por padrão não é algo realmente necessario

        private static string _usuario = null;
        private static string _senha = null;
        private static string _nome = null;

        // Encapsulei a váriavel para ter mais controle DO QUE SERÁ INSERIDO OU PEGO
        public static string usuario
        {
            get { return _usuario;}

            set 
            {
              _usuario = value;
            }
        }

        public static string nome
        {
            get { return _nome; }

            set
            {
                _nome = value;
            }
        }

        public static string senha
        {
            get { return _senha; }

            set
            {
                _senha = value;
            }
        }
    }
}

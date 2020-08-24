using System.Text;
using Manipulations;

namespace Main 
{
    class Menu
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" ______________________");
            sb.AppendLine("|   ESCOLHA A OPÇÃO:   |");
            sb.AppendLine("|______________________|");
            sb.AppendLine("|                      |");
            sb.AppendLine("| 1. Cadastrar Cliente |");
            sb.AppendLine("| 2. Sacar             |");
            sb.AppendLine("| 3. Depositar         |");
            sb.AppendLine("| 4. Mostrar Saldo     |");
            sb.AppendLine("| 5. Sair              |");
            sb.AppendLine("|______________________|");
            sb.AppendLine();
            return sb.ToString();
        }
    }
}

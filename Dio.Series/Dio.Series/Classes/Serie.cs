using Dio.Series.Enum;
using System.Text;

namespace Dio.Series.Classes
{
    
    public class Serie : EntidadeBase
    {

        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Serie(int id , Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
            this.Titulo = titulo;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Gênero: " + this.Genero);
            stringBuilder.AppendLine("Titulo: " + this.Titulo);
            stringBuilder.AppendLine("Descrição: " + this.Descricao);
            stringBuilder.AppendLine("Ano de Iniício: " + this.Ano);
            stringBuilder.AppendLine("Excluido: " + this.Excluido);
            return stringBuilder.ToString();
        }

        public string RetornarTitulo()
        {
            return this.Titulo;
        }

        public int RetornarId()
        {
            return this.Id;
        }

        public bool RetornarExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}

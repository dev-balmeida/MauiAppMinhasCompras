using SQLite;

namespace MauiAppMinhasCompras.Models
{
    public class Produto
    {
        string _descricao;
        int _quantidade;
        int _preco;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao { 
            get => _descricao;
            set
            {
                if (value == null)
                {
                    throw new Exception("Por favor, preencha a descrição");
                }
            }
        }
        public double Quantidade { 
            get => _quantidade;
            set 
            {
                if (value == 0)
                {
                    throw new Exception("Por favor, preencha a quantidade");
                }
            } 
        }
        public double Preco {  
            get => _preco;
            set 
            {
                if (value == 0)
                {
                    throw new Exception("Por favor, preencha preço");
                }
            } 
        }

        public double Total { get => Quantidade * Preco; }
    }
}

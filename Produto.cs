namespace Excel_Criar
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        
        private const string PATH = "Database/produto.csv";


        public Produto(){
            if(!System.IO.File.Exists(PATH)){
                System.IO.Directory.CreateDirectory("Database");
                System.IO.File.Create(PATH).Close();
            }
        }

        public void Cadastrar(Produto prod){
            var linha = new string[] { PrepararLinha(prod) };
            System.IO.File.AppendAllLines(PATH, linha);
        }

        // 1; Celular; 600;

        private string PrepararLinha(Produto p){
          return   $"Codigo = {p.Codigo}; Nome = {p.Nome}; Preço = {p.Preco}";
        }

    }
}
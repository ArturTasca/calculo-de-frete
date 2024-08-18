using System;

private class CalculadoraDeFrete
{
    // Variáveis para armazenar o endereço
    string logradouro;  
    int numero;         
    string cep;         
    string bairro;      
    string municipio;   
    string estado;      

    // Variáveis para armazenar os detalhes do produto
    double distanciaKm;
    double volumeM3;    
    double pesoGramas;  

    // Construtor
    public CalculadoraDeFrete(string logradouro,int numero,string cep,string bairro,string municipio,string estado,double distanciaKm,double volumeM3,double pesoGramas)
    {
        // Inicializa as variáveis com os valores fornecidos
        this.logradouro = logradouro;
        this.numero = numero;
        this.cep = cep;
        this.bairro = bairro;
        this.municipio = municipio;
        this.estado = estado;
        this.distanciaKm = distanciaKm;
        this.volumeM3 = volumeM3;
        this.pesoGramas = pesoGramas;
    }

    // Método para calcular o frete
    public void CalcularFrete()
    {
        string endereco = $"{logradouro},{numero},{bairro},{municipio} - {estado},CEP: {cep}";
        Console.WriteLine("Endereço: " + endereco);

        double custoDistancia = distanciaKm * 1.20; 
        double custoVolume = volumeM3 * 5.45;       
        double custoPeso = pesoGramas * 0.30;       

        double custoTotal = custoDistancia + custoVolume + custoPeso;

        Console.WriteLine($"Custo do frete: R$ {custoTotal:F2}");
    }

        public static void Main(string[] args)
    {
            CalculadoraDeFrete calculadoraDeFrete = new CalculadoraDeFrete(
            "Rua das Flores",   // Logradouro
            123,                // Número
            "12345-678",        // CEP
            "Centro",           // Bairro
            "São Paulo",        // Município
            "SP",               // Estado
            150.0,              // Distância em km
            2.5,                // Volume em m³
            2000.0              // Peso em gramas
        );

            calculadoraDeFrete.CalcularFrete();
    }
}

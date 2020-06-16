using System;

namespace Aula18Dojo1
{
    //
    //
    //
    //
    
    public class Jogador
    {
        public string Nome { get; set; }
        public string Posicao { get; set; }
        public DateTime Nascimento { get; set; }
        public float Altura { get; set; }
        public float Peso {get; set;}
        public string Nacionalidade { get; set; }


        public string MostrarDados(){
            return $"Nome: {Nome}\nPosição do jogador: {Posicao}\nData de nascimento: {Nascimento}\nAltura: {Altura}\nPeso: {Peso}\nNacionalidade: {Nacionalidade}";
        }

        public int idade { get; set; }
        public int idadeRest { get; set; }

        public int CalcularIdade(){
            int anoNasct = Int32.Parse(Nascimento.ToString().Split('/', ' ')[2]);
            int anoAtual = Int32.Parse(DateTime.Now.ToString().Split('/', ' ')[2]);

            idade = anoAtual - anoNasct;
            idadeRest = 35 - idade;

            return idade;
            
        }
        public string CalcularAposentadoria(){
            //Atacante 35
            //Meio campo 38
            //Defesa 40

            string aposentadoria = "";

            if(Posicao == "Atacante" && idade >= 35){

                aposentadoria = "Você pode se aposentar.";
                
            }else if(Posicao == "Meio Campo" && idade >= 38){

                aposentadoria = "Você pode se aposentar.";
                
            }else if(Posicao == "Defesa" && idade >= 40){
                aposentadoria = "Você pode se aposentar.";

            }else{
                aposentadoria = $"Você nao pode se aposentar, falta {idadeRest} ano(s).";
            }
            return aposentadoria;
            
        }
    }
}
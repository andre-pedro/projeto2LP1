using System;
using System.Collections.Generic;
using System.IO;

namespace Projeto2_LP1
{

    /// <summary>
    /// Classe responsavél por salvar o nome e respectivos pontos que o jogador
    /// consegui obter durante o jogo. Esta classe ainda seleciona o top 10 dos 
    /// pontos, ou seja, permite seleciona o top 10, descartando os jogadores que
    /// obtiveram pior pontuação e substituindo por novos jogadores com uma pontuação
    /// mais elevada.
    /// </summary>
    public class HighScoresManager
    {
        /// <summary>
        /// Cria uma Lista que irá guardar o nome e pontuação do jogador.
        /// </summary>
        private List<Tuple<string, float>> highscores;

        /// <summary>
        /// Cria uma variável que guarda o nome do ficheiro.
        /// </summary>
        private string filename = "";

        /// <summary>
        /// Constructor necessário para inicializar instâncias desta classe.
        /// </summary>
        /// <param name="filename">Nome dado ao ficheiro .txt que têm os 
        /// highscores do jogo.</param>
        public HighScoresManager(string filename = "HighScores.txt")
        {
            ///Inicializa o ficheiro com o nome do ficheiro fornecido no 
            ///constructor.
            this.filename = filename;

            ///Se o ficheiro escolhido não existir, cria uma nova lista que contêm
            ///o nome e a pontuação do jogador.
            if (!File.Exists(filename))
            {
                highscores = new List<Tuple<string, float>>(10);
            }
            
            ///Se o ficherio existe irá efectuar o seguinte código.
            else
            {
                
                ///inicializa a lista.
                highscores = new List<Tuple<string, float>>(10);
                
                ///Lê todas as linhas do ficheiro obtido.
                string[] text = File.ReadAllLines(filename);

                ///Pecorre todas as linhas do ficheiro.
                for (int i = 1; i < text.Length; i++)
                {
                    
                    ///Separa as linhas de acordo com o formato indicado.
                    string[] subStrings = text[i].Split(':');

                    ///Se o formato pedido estiver incorrecto ou a substring não
                    ///for possível converter em float.
                    if (subStrings.Length != 2 ||
                        !Single.TryParse(subStrings[1], out float score))
                    {
                       
                        ///Envia uma mensagem de erro ao utilizador.
                        throw new InvalidOperationException($"The format of " +
                            $"the file '{filename}' is not correct.");
                    }

                    ///Salva o nome da primeira substring.
                    string name = subStrings[0];

                    ///Adiciona a nova melhor pontuação a lista
                    highscores.Add(new Tuple<string, float>(name, score));
                }

                ///Ordena a lista de forma descendente. 
                SortList();
            }
        }

        /// <summary>
        /// Este metódo têm como objectivo adicionar uma nova pontuação ao ficheiro
        /// .txt sempre que alguem obteve uma pontuação sufecientemente elevada 
        /// para se encontrar no top10 da lista.
        /// </summary>
        /// <param name="name">O nome que o jogador irá escrever para aparecer
        /// no ficheiro .txt.</param>
        /// <param name="score">É passado a pontuação que o jogador obteve e que 
        /// o permitiu "entrar" na tabela do top10.</param>
        public void AddScore(string name, float score)
        {
            ///Cria e instância um novo objecto que guarda a nova pontuação.
            Tuple<string, float> newScore = new Tuple<string, float>(name, score);

            /// Adiciona o nova melhor pontuação a lista.
            highscores.Add(newScore);

            ///Ordena a lista de forma descendente.
            SortList();

            ///Verifica se a lista possui mais que dez elementos
            if (highscores.Count > 10)
            {
                ///remove o ultimo elemento pois deixou de pertencer ao top10-
                highscores.RemoveAt(highscores.Count - 1);
            }
        }

        // Method to save highscores to file
        public void Save()
        {
            // Create variable to hold all text from list
            string text = "Name:Score\n";
            // For each element of the list
            foreach (Tuple<string, float> highscore in highscores)
            {
                // Add text with Name and score
                text += $"{highscore.Item1}:{highscore.Item2}\n";
            }

            // Write all the highscores on the specified file
            File.WriteAllText(filename, text);
        }

        /// <summary>
        /// Método que ira retornar todas as pontuações da lista.
        /// </summary>
        /// <returns>Como o método possui um "yield" permite retornar todas as 
        /// pontuações que se encontram na lista.</returns>
        public IEnumerable<Tuple<string, float>> GetScores()
        {
            ///Pecorre todas as pontuações na lista.
            foreach (Tuple<string, float> highscore in highscores)
            {
                ///Retorna todas as pontuações que encontrar na lista.
                yield return highscore;
            }
        }

        /// <summary>
        /// Método que é utilizado para ordenar a lista das pontuações.
        /// </summary>
        private void SortList()
        {
            ///Ordena os elementos da lista de forma descendente
            for (int i = 0; i <= highscores.Count - 1; i++)
            {
                for (int j = 0; j < highscores.Count - 1; j++)
                {
                    ///Utiliza o algoritmo Bubble Sort para ordenar a lista.
                    if (highscores[j].Item2 < highscores[i].Item2)
                    {
                        Tuple<string, float> temp = highscores[i];
                        highscores[i] = highscores[j];
                        highscores[j] = temp;
                    }
                }
            }
        }
    }
}
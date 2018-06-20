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

                    // If format is incorrect or the second subString cannot be
                    // converted to float
                    if (subStrings.Length != 2 ||
                        !Single.TryParse(subStrings[1], out float score))
                    {
                        // Send Error message
                        throw new InvalidOperationException($"The format of " +
                            $"the file '{filename}' is not correct.");
                    }

                    // Save name from the first subString
                    string name = subStrings[0];

                    // Add highscore to list
                    highscores.Add(new Tuple<string, float>(name, score));
                }

                // Sort the elements of the list in descending order
                SortList();
            }
        }

        // Method that Adds a new Highscore
        public void AddScore(string name, float score)
        {
            // Create and instantiate a new object to hold the new highscore
            Tuple<string, float> newScore = new Tuple<string, float>(name, score);

            // Add highscore to list
            highscores.Add(newScore);

            // Sort the elements of the list in descending order
            SortList();

            // If list has more than 10 elements
            if (highscores.Count > 10)
            {
                // Remove last item on list
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

        // Method that returns all highscores from list
        public IEnumerable<Tuple<string, float>> GetScores()
        {
            // For each highscore in list
            foreach (Tuple<string, float> highscore in highscores)
            {
                // Return the current highscore
                yield return highscore;
            }
        }

        // Method to sort the list
        private void SortList()
        {
            // Sort the elements of the list in a descending order
            for (int i = 0; i <= highscores.Count - 1; i++)
            {
                for (int j = 0; j < highscores.Count - 1; j++)
                {
                    // Use Bubble Sort to sort the list
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
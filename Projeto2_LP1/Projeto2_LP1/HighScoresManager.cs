﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Projeto2_LP1
{
    public class HighScoresManager
    {
        // Create a List to hold highscores
        private List<Tuple<string, float>> highscores;

        // Create variable to hold the filename
        private string filename = "";

        // Constructor to initialise List
        public HighScoresManager(string filename = "HighScores.txt")
        {
            // Initialise filename with filename given
            this.filename = filename;

            // If File does not exist, initialise empty list
            if (!File.Exists(filename))
            {
                highscores = new List<Tuple<string, float>>(10);
            }
            // If file exists
            else
            {
                // Initialise List
                highscores = new List<Tuple<string, float>>(10);
                // Read All Lines from file
                string[] text = File.ReadAllLines(filename);

                // Cycle through all the lines
                for (int i = 1; i < text.Length; i++)
                {
                    // Separate lines according to accepted format
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
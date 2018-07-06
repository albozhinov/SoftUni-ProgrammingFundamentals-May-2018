using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.HandsOfCards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {
            var handsOfCards = new Dictionary<string, Dictionary<string, int>>();

            List<string> input = Console.ReadLine().Split(new char[] { ':', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (input[0] != "JOKER")
            {
                string nameOfPlayer = input[0];

                if (!handsOfCards.ContainsKey(input[0]))
                {
                    handsOfCards.Add(input[0], new Dictionary<string, int>());
                }


                for (int i = 1; i < input.Count; i++)
                {
                    string card = input[i];

                    if (!handsOfCards[nameOfPlayer].ContainsKey(card))
                    {
                        int powerOfCard = CalcCardPower(card);

                        handsOfCards[nameOfPlayer].Add(card, powerOfCard);
                    }
                }

                input = Console.ReadLine().Split(new char[] { ':', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (var outerPair in handsOfCards)
            {

                int sum = 0;
                foreach (var innerPair in outerPair.Value)
                {
                    sum += innerPair.Value;
                }
                Console.Write($"{outerPair.Key}: {sum}");
                Console.WriteLine();
            }
        }

        static int CalcCardPower(string card)
        {

            string cardType = card[card.Length - 1].ToString();
            string cardValue;
            int multiplier = 0;
            int value = 0;

            switch (cardType)
            {
                case "S":
                    multiplier = 4;
                    break;
                case "H":
                    multiplier = 3;
                    break;
                case "D":
                    multiplier = 2;
                    break;
                case "C":
                    multiplier = 1;
                    break;
            }
            cardValue = card.Remove(card.Length - 1).Trim();
            switch (cardValue)
            {
                case "J":
                    value = 11;
                    break;
                case "Q":
                    value = 12;
                    break;
                case "K":
                    value = 13;
                    break;
                case "A":
                    value = 14;
                    break;
                default:
                    value = int.Parse(cardValue);
                    break;
            }

            return multiplier * value;
        }
    }
}

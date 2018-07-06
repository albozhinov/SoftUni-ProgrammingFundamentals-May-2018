using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace P04.Roli_TheCoder
{
    class Program
    {
        static void Main(string[] args)
        {

            var eventIDtoNames = new Dictionary<int, string>();
            var eventParticipants = new Dictionary<int, List<string>>();


            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "Time for Code")
                {
                    break;
                }
                
                var eventInfo = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var idNumber = 0;
                var eventName = eventInfo[1];
                if (!int.TryParse(eventInfo[0], out idNumber))
                {
                    continue;
                }
                if (!eventName.StartsWith("#"))
                {
                    continue;
                }
                eventName = eventName.Trim('#');

                var members = new List<string>();

                for (int i = 2; i < eventInfo.Count; i++)
                {
                    members.Add(eventInfo[i]);
                }

                if (!eventIDtoNames.ContainsKey(idNumber))
                {
                    eventIDtoNames.Add(idNumber, eventName);
                    
                    eventParticipants.Add(idNumber, members);
                }
                else
                {
                    if (eventIDtoNames[idNumber].Contains(eventName))
                    {
                        eventParticipants[idNumber].AddRange(members);
                        eventParticipants[idNumber].Distinct();
                    }                
                    
                }                
            }
            var events = eventParticipants.OrderByDescending(kvp => kvp.Value.Count).ThenBy(kvp => eventIDtoNames[kvp.Key]);

            foreach (var ev in events)
            {
                var evId = ev.Key;
                var evName = eventIDtoNames[evId];
                var participant = eventParticipants[evId];
                var sortedParticipant = participant.Distinct().OrderBy(p => p);

                Console.WriteLine($"{evName} - {sortedParticipant.Count()}");

                foreach (var item in sortedParticipant)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }   
}

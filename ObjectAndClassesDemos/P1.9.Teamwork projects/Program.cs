using System;
using System.Collections.Generic;
using System.Linq;

namespace P1._9.Teamwork_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();


            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split('-').ToArray();
                string creatorName = inputLine[0];
                string teamName = inputLine[1];

                if (teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(y => y.CreatorName == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");

                }
                else
                {
                    Team currTeam = new Team();
                    currTeam.Name = teamName;
                    currTeam.CreatorName = creatorName;
                    currTeam.Members = new List<string>();
                    teams.Add(currTeam);
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                }
            }

            string inputMembers = Console.ReadLine();
            while (inputMembers != "end of assignment")
            {
                var joinUsers = inputMembers.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var teamName = joinUsers[1];
                var memberName = joinUsers[0];
                Team currTeam = null;

                if (!teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(x => x.CreatorName == memberName) || teams.Any(y => y.Members.Contains(memberName)))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                }
                else
                {
                    currTeam = teams.First(x => x.Name == teamName);
                    currTeam.Members.Add(memberName);
                }
                inputMembers = Console.ReadLine();
            }

            foreach (var item in teams.Where(m => m.Members.Count != 0).OrderByDescending(x => x.Members.Count).ThenBy(r => r.Name))
            {
                Console.WriteLine($"{item.Name}");
                Console.WriteLine($"- {item.CreatorName}");
                foreach (var user in item.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {user}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var item in teams.Where(x => x.Members.Count == 0).OrderBy(y => y.Name))
            {
                Console.WriteLine($"{item.Name}");
            }
        }
    }
    class Team
    {
        public string Name { get; set; }

        public List<string> Members { get; set; }

        public string CreatorName { get; set; }
    }
}

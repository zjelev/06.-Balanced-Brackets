using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Teamwork_projects
{
    class Program
    {
        static void Main()
        {
            int countTeams = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < countTeams; i++)
            {
                string[] createTeam = Console.ReadLine().Split("-");

                string teamName = createTeam[1];
                string creator = createTeam[0];
                bool teamNameExists = false;
                bool creatorExists = false;

                Team team = new Team(teamName, creator);

                foreach (var item in teams)
                {
                    if (item.Name == teamName)
                    {
                        teamNameExists = true;
                        break;
                    }
                }

                foreach (var item in teams)
                {
                    if (item.Creator == creator)
                    {
                        creatorExists = true;
                        break;
                    }
                }

                if (teamNameExists)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (creatorExists)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
                
            }

            string userAdd;

            while ((userAdd = Console.ReadLine()) != "end of assignment")
            {
                string[] userAddSplitted = userAdd.Split("->");

                string teamName = userAddSplitted[1];
                string userName = userAddSplitted[0];

                bool existingTeam = false;
                bool existingUser = false;

                foreach (var item in teams)
                {
                    if (item.Name == teamName)
                    {
                        existingTeam = true;
                        break;
                    }
                }

                foreach (var item in teams)
                {
                    if (existingUser)
                    {
                        break;
                    }
                    foreach (var user in item.Users)
                    {
                        if (user == userName)
                        {
                            existingUser = true;
                            break;
                        }
                    }
                }

                foreach (var item in teams)
                {
                    if (item.Creator == userName)
                    {
                        existingUser = true;
                        break;
                    }
                }

                if (!existingTeam)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (existingUser)
                {
                    Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                }
                else
                {
                    int index = teams.FindIndex(x => x.Name == teamName);
                    teams[index].Users.Add(userName);
                }
            }

            List<string> removedTeams = new List<string>();

            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].Users.Count == 0)
                {
                    removedTeams.Add(teams[i].Name);
                    teams.Remove(teams[i]);
                    i--;
                }
            }

            teams = teams.OrderByDescending(x => x.Users.Count).ThenBy(x => x.Name).ToList();

            foreach (var team in teams)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                //team.Users.Sort();
                team.Users = team.Users.OrderBy(x => x).ToList();
                foreach (var user in team.Users)
                {
                    Console.WriteLine($"-- {user}");
                }
            }

            Console.WriteLine("Teams to disband:");
            if (removedTeams.Count > 0)
            {
                removedTeams.Sort();
                foreach (var item in removedTeams)
                {
                    Console.WriteLine(item);
                }
            }
            
        }
    }

    class Team
    {
        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Users { get; set; }

        public Team(string name, string creator)
        {
            this.Name = name;
            this.Creator = creator;
            this.Users = new List<string>();
        }

    }
}

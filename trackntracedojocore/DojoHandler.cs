using System;
using System.Collections.Generic;
using System.Linq;

namespace TrackNTraceDojo
{
    public class DojoHandler
    {
        private int RotationTime { get; set; }
        private int CommitTime { get; set; }
        private List<string> Names { get; set; }

        public List<string> GetNames() => Names;

        private List<DojoRound> DojoRounds { get; set; }

        public DojoHandler()
        {
            DojoRounds = new List<DojoRound>();
        }

        public void SetRotationTime(int minutes)
        {
            RotationTime = minutes;
        }
        public void SetCommitTime(int minutes)
        {
            CommitTime = minutes;
        }

        public int GetRotationTime()
        {
            return RotationTime;
        }
        
        public int GetCommitTime()
        {
            return CommitTime;
        }

        public void SetRotationNames(List<string> names)
        {
            Names = names;
        }



        public void CreateRound(string driver, string navigator, DateTime start, DateTime end)
        {
            DojoRounds.Add(new DojoRound()
            {
                Driver = driver,
                Navigator = navigator,
                Start = start,
                End = end
            });
        }


        public List<DojoRound> GetRounds()
        {
            return DojoRounds;
        }

        public void CreateDojo(List<string> names, int rotationTimeInMinutes, int commitTimeInMinutes)
        {
            throw new NotImplementedException();
        }
    }

    public class DojoRound
    {
        public string Driver { get; set; }
        public string Navigator { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }

    public class RandomNames
    {
        public Guid Id;
        public string Name;
    }

    public static class Sort
    {
        public static List<string> Randomize(List<string> namesList)
        {
            List<string> listNamesOrdered;
            do
            {
                var names = new List<RandomNames>();
                listNamesOrdered = namesList.OrderBy(i => Guid.NewGuid()).Select(x => x).ToList();
            } while (listNamesOrdered.Equals(namesList));
            
            return listNamesOrdered;
        }
    }
    
    
}
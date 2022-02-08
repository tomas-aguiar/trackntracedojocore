using System;
using System.Collections.Generic;
using System.Linq;
using TrackNTraceDojo;
using Xunit;

namespace TrackNTraceDojoTests
{
    public class DojoHandlerTest
    {
        private readonly DojoHandler _dojoHandlerInstance;

        public DojoHandlerTest()
        {
            _dojoHandlerInstance = new DojoHandler();
        }

        [Fact]
        public void GetListOfRandomNames()
        {
            var names = new List<string>
            {
                "name1",
                "name2",
                "name3"
            };
            var namesList = Sort.Randomize(names);

            Assert.NotEqual(names, namesList);
        }

        [Fact]
        public void GetRotationTime()
        {
            var dojoHandlerInstance = new DojoHandler();
            dojoHandlerInstance.SetRotationTime(5);
            var time = dojoHandlerInstance.GetRotationTime();
            Assert.True(time == 5);
        }

        [Fact]
        public void GetCommitTime()
        {
            var dojoHandlerInstance = new DojoHandler();
            dojoHandlerInstance.SetCommitTime(2);
            var time = dojoHandlerInstance.GetCommitTime();
            Assert.True(time == 2);
        }

        [Fact]
        public void SetNamesForRotation()
        {
            var names = new List<string>
            {
                "name1",
                "name2",
                "name3"
            };

            _dojoHandlerInstance.SetRotationNames(names);
            var rotationList = _dojoHandlerInstance.GetNames();

            Assert.Equal(names, rotationList);
            Assert.Equal(names.Count, rotationList.Count);
        }

        [Fact]
        public void CreateDojoRound()
        {
            const string navigator = "some-one";
            const string driver = "some-driver";
            var start = DateTime.Now;
            const int rotationTime = 5;
            var end = start.AddMinutes(rotationTime);

            _dojoHandlerInstance.CreateRound(driver, navigator, start, end);

            var recordList = _dojoHandlerInstance.GetRounds();

            Assert.Equal(navigator, recordList.First().Navigator);
        }


        [Fact]
        public void CreateDojo()
        {
            List<string> names = new List<string>();
            names.Add("Lucas");
            names.Add("Saulo");
            const int rotationTime = 5;
            const int commitTime = 2;

            _dojoHandlerInstance.CreateDojo(names, rotationTime, commitTime);





        }
    }
}
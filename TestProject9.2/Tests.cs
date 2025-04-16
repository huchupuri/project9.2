using System;
using EventManagementApp;
namespace TestProject9._2
{
    [TestClass]
    public sealed class Tests
    {
        private Event event1;
        [TestInitialize]
        public void CreateEvent()
        { 
           event1 = new Event();
        }
        [TestMethod]
        public void Event_Title_ThrowsExceptionIfTitleFirstLetterIsSpacebar()
        {
            Assert.ThrowsException<ArgumentException>(() => event1.title = " Пробежка по горам");
        }
        [TestMethod]
        public void Event_Title_ThrowsExceptionIfTitleIsASingleSpacebar()
        {
            Assert.ThrowsException<ArgumentException>(() => event1.title = " ");
        }
        [TestMethod]
        public void Event_Title_ThrowsExceptionIfTitleGoesToTheNewLine()
        {
            Assert.ThrowsException<ArgumentException>(() => event1.title = $"Весёлые\nГонки");
        }
        [TestMethod]
        public void Event_Title_ThrowsExceptionIfTitleIsFiftyCharsLong()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => event1.title = new string('Р', 50));
        }
        [TestMethod]
        public void Event_Title()
        {
            event1.title = "Охота";
            Assert.AreEqual("Охота", event1.title);
        }

        [TestMethod]
        public void Event_Place_ThrowsExceptionIfPlaceIsFiftyCharsLong()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => event1.place = new string('Р', 50));
        }
        [TestMethod]
        public void Event_Place_ThrowsExceptionIfPlaceFirstLetterIsSpacebar()
        {
            Assert.ThrowsException<ArgumentException>(() => event1.place = " Пробежка по горам");
        }
        [TestMethod]
        public void Event_Place_ThrowsExceptionIfPlaceIsASingleSpacebar()
        {
            Assert.ThrowsException<ArgumentException>(() => event1.title = " ");
        }
        [TestMethod]
        public void Event_Place()
        {
            event1.place = "Лес";
            Assert.AreEqual("Лес", event1.place);
        }
        [TestMethod]
        public void Event_Participants_ThrowsExceptionIfFirstLetterIsSpacebar()
        {
            Assert.ThrowsException<ArgumentException>(() => event1.participants = " Пробежка по горам");
        }
        [TestMethod]
        public void Event_Place_ThrowsExceptionIfParticipantsIsASingleSpacebar()
        {
            Assert.ThrowsException<ArgumentException>(() => event1.participants = " ");
        }
        [TestMethod]
        public void Event_Participants_ThrowsExceptionIfContainsNums()
        {
            Assert.ThrowsException<ArgumentException>(() => event1.participants = "124");
        }
        [TestMethod]
        public void Event_Participants()
        {
            event1.participants = "Алексей Габов";
            Assert.AreEqual("Алексей Габов", event1.participants);
        }
        [TestMethod]
        public void Event_Discription_ThrowsExceptionIfDiscriptionIsFiveHundredCharsLong()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => event1.description = new string('Р', 500));
        }
        [TestMethod]
        public void Event_Discription()
        {
            event1.description = "Очень весёлое приключение";
            Assert.AreEqual("Очень весёлое приключение", event1.description);
        }
    }
}

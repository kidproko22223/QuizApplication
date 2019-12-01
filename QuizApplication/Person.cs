using System.Linq;

namespace QuizApplication
{
    public class Person
    {
        public Person()
        {
            Name = "";
            Time = 0;
            Age = 18;
            IsMale = true;
        }

        public string Name { get; set; }
        public float Accuracy { get; set; }
        public int Time { get; set; }
        public int Age { get; set; }
        public bool IsMale { get; set; }
        public string TimeForHumans
        {
            get
            {
                return ControlMethods.GetTimeInHumanLanguage(Time);
            }
        }
        public string Level
        {
            get
            {
                return ControlMethods.GetLevelString(Accuracy);
            }
        }
        public string Comment
        {
            get { return DataLayer.GetComment(Accuracy); }
        }
        public string FirstName
        {
            get
            {
                if (Name.Contains(' '))
                {
                    return Name.Split(' ')[0];
                }
                else
                    return Name;
            }
        }
    }
}
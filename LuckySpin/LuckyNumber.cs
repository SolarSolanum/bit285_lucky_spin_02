using System;

namespace LuckySpin
{

    public class LuckyNumber
    {
        Random random = new Random();
        private int luck=7;

        // Luck Property uses a private instance variable
        public int Luck
        {
            get { return luck; }
            set { luck = value; }
        }
        //the Output Property returns an HTML string generated using random numbers
        public string Output {
            get
            {
                //Three random numbers
                int a = random.Next(0, 10);
                int b = random.Next(0, 10);
                int c = random.Next(0, 10);
                
                //TODO: Use the parameter value "luck" instead of the fixed number 7
                string image = (a == Luck || b == Luck || c == Luck) ?
                        "<img src='http://faculty.cascadia.edu/brianb/images/LuckySevenExercise.jpg'/>" :
                        //Notice the ternary operator ?: is used to assign a value to the image variable depending on the condition
                        ""; //empty string if none of the values match

                //TODO: Modify the output String.Format template to include the luck value in the <h1>
                string output = "<button onclick='history.go(0)'>Spin</button>" +
                        String.Format(
                        "<div>{0}</div><div>{1}</div><div>{2}</div>" +
                        "<h1>Lucky Number </h1>{3}", a, b, c, image);
                return output;
            }
        }
    }
}

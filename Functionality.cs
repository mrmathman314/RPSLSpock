using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSpock
{
    public class Functionality
    {
        public enum Choices
        {
            Rock,
            Paper,
            Scissors,
            Lizard,
            Spock,
            Fail
        };

        public enum Outcome
        {
            Win,
            Lose,
            Tie
        };

        public Functionality()
        {

        }

        /// <summary>
        /// Clears Frame
        /// </summary>
        public void Frame_Clear()
        {

        }

        /// <summary>
        /// Gets Computer Choice
        /// </summary>
        /// <returns></returns>
        public Choices AISelection()
        {
            Random random = new Random();
            return GetChoice(random.Next(1, 5));
        }

        /// <summary>
        /// Gets Human Choice
        /// </summary>
        /// <param name="selected"></param>
        /// <returns></returns>
        public Choices GetChoice(int selected)
        {
            switch (selected)
            {
                case 1:
                    return Choices.Rock;
                case 2:
                    return Choices.Paper;
                case 3:
                    return Choices.Scissors;
                case 4:
                    return Choices.Lizard;
                case 5:
                    return Choices.Spock;
            }
            return Choices.Fail;
        }

        public Outcome CheckWinner(Choices ai, Choices human)
        {
            switch (ai)
            {
                case (Choices.Rock):
                    switch (human)
                    {
                        case Choices.Paper:
                        case Choices.Spock:
                            return Outcome.Win;
                        case Choices.Rock:
                            return Outcome.Tie;
                        default:
                            return Outcome.Lose;
                    }
                case (Choices.Paper):
                    switch (human)
                    {
                        case Choices.Scissors:
                        case Choices.Lizard:
                            return Outcome.Win;
                        case Choices.Paper:
                            return Outcome.Tie;
                        default:
                            return Outcome.Lose;
                    }
                case (Choices.Scissors):
                    switch (human)
                    {
                        case Choices.Rock:
                        case Choices.Spock:
                            return Outcome.Win;
                        case Choices.Scissors:
                            return Outcome.Tie;
                        default:
                            return Outcome.Lose;
                    }
                case (Choices.Lizard):
                    switch (human)
                    {
                        case Choices.Scissors:
                        case Choices.Rock:
                            return Outcome.Win;
                        case Choices.Lizard:
                            return Outcome.Tie;
                        default:
                            return Outcome.Lose;
                    }
                case (Choices.Spock):
                    switch (human)
                    {
                        case Choices.Lizard:
                        case Choices.Paper:
                            return Outcome.Win;
                        case Choices.Spock:
                            return Outcome.Tie;
                        default:
                            return Outcome.Lose;

                    }
                default:
                    return Outcome.Tie;
            }
        }
    }
}

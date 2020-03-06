using System;

namespace TennisSimplified
{
    // Implement simplified tennis scoring system where one set is
    // match.
    // 1. A game is won by the first player to have won at least
    //    four points in total and at least two points more
    //    than the opponent.
    // 2. If at least three points have been scored by each player,
    //    and the scores are equal, the score is “deuce”.
    // 3. If at least three points have been scored by each side
    //    and a player has one more point than his opponent,
    //    the score of the game is “advantage” for the player
    //    in the lead.
    // 3. If at least three points have been scored by each side
    //    and a player has two more points than his opponent,
    //    then this player is a winner 
    // 4. After each point is scored result should be returned as string 
    //    in format " 0 - 0 ", "15 - 0 ", "30 - 40", "Adv    ", "    Adv"
    //    " Deuce ", "Won    ", "    Won" (7 chars in total for all cases
    public class Program
    {
        private static void Main(string[] args)
        {
	        var tennisScoringSystem = new TennisScoringSystem();
	        tennisScoringSystem.FirstPlayerScored(); 
	        Console.WriteLine(tennisScoringSystem.GetResult()); // should print "15 - 0 "
	        tennisScoringSystem.SecondPlayerScored();
            Console.WriteLine(tennisScoringSystem.GetResult()); // should print "15 - 15"
            tennisScoringSystem.FirstPlayerScored();
            Console.WriteLine(tennisScoringSystem.GetResult()); // should print "30 - 15"
            tennisScoringSystem.FirstPlayerScored();
            Console.WriteLine(tennisScoringSystem.GetResult()); // should print "40 - 15"
            tennisScoringSystem.SecondPlayerScored();
            Console.WriteLine(tennisScoringSystem.GetResult()); // should print "40 - 30"
            tennisScoringSystem.SecondPlayerScored();
            Console.WriteLine(tennisScoringSystem.GetResult()); // should print " Deuce "
            tennisScoringSystem.FirstPlayerScored();
            Console.WriteLine(tennisScoringSystem.GetResult()); // should print "Adv    "
            tennisScoringSystem.FirstPlayerScored();
            Console.WriteLine(tennisScoringSystem.GetResult()); // should print "Won    "
        }
    }
}
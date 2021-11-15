using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTourChallenge {
    public class KnightsTourChallengeProgram {
        //Possible Moves that the knight can make. 
        public static List<List<int>> possibleMoves = new List<List<int>>() {
            new List<int>() {2,1},
            new List<int>() {1,2},
            new List<int>() {-1,2},
            new List<int>() {-2,1},
            new List<int>() {-2,-1},
            new List<int>() {-1,-2},
            new List<int>() {1,-2},
            new List<int>() {2,-1}
        };

        //Chess Board Squares - 0 indicates not touched, other numbers indicate what order they were touched. 
        public List<List<int>> chessBoardSquares = new List<List<int>>() { };

        //Knights current position
        public List<int> knightsPosition = new List<int> { 0, 0 };

        //Number of moves made by the knight
        public int knightMoves = 0;

        public void initialiseChessboard() {
            chessBoardSquares.AddRange(Enumerable.Repeat(new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 }, 8));
        }
        /// <summary>
        /// Determines if the square has already been used, by checking the integer value of the chess square. 
        /// </summary>
        /// <param name="move">the two index coorodinates from the possible move</param>
        /// <returns>true if not touched, false if touched.</returns>
        public bool squareIsClear(List<int> coords)
        {
            //check the value at coords position, too see if higher than 0. 
            return false;
        }

        /// <summary>
        /// Determines wheter the square exists for the knight to make the move. 
        /// </summary>
        /// <param name="coords">the two index coorodinates from the possible move</param>
        /// <returns>True if the knight can make the move. False if the move cannot be made.</returns>
        public bool inParameterCheck(List<int> coords)
        {
            //Complete the check, if higher or lower, return false. 
            return false;
        }

        /// <summary>
        /// Determines the new coordinates of the knight based on its current position and the attempted move. 
        /// </summary>
        /// <param name="move">the attempted move by the knight.</param>
        /// <returns>new knights position</returns>
        public List<int> getCoords(List<int> move)
        {
            //Add the move coorinates to the knights coordinates. 
            return new List<int> { 0, 0 };

        }

        /// <summary>
        /// Moves the knight to the new position. 
        /// </summary>
        /// <param name="coords">the coordinates to move the knight to.</param>
        public void moveKnight(List<int> coords)
        {
            //change the coordinates of the Knights Position.

            //Increment the move counter and modify the squares value to represent what number move was made. 
        }

        /// <summary>
        /// Runs through all possible moves from the specified position.
        /// </summary>
        /// <returns></returns>
        public List<bool> checkPossibleMoves(List<int> coords) {
            var possibleMoves = new List<bool>();
            //run a for loop on each position it can move too from the specified coords. 


            return possibleMoves;
        }


    }
}

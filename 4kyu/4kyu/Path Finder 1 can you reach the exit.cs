



//Task
//You are at position [0, 0] in maze NxN and you can only move in one of the four cardinal directions (i.e. North, East, South, West). Return true if you can reach position[N - 1, N - 1] or false otherwise.

//Empty positions are marked ..
//Walls are marked W.
//Start and exit positions are empty in all test cases.



using System.Linq;

public class Finder
{
    private static bool PathFinder(int[][] maze, int x = 0, int y = 0) =>

        (x >= 0 && x < maze[0].Length) &&
        (y >= 0 && y < maze.Length) &&
        (maze[y][x] == 0) && (
            (x + 1 == maze[0].Length && y + 1 == maze.Length) ||
            (maze[y][x] = -1) == -1 && (
                PathFinder(maze, x + 1, y) ||
                PathFinder(maze, x - 1, y) ||
                PathFinder(maze, x, y + 1) ||
                PathFinder(maze, x, y - 1)));

    public static bool PathFinder(string maze) =>

        PathFinder(maze.Split('\n').Select(
            line => line.Select(c => '.' - c).ToArray()
        ).ToArray());
}
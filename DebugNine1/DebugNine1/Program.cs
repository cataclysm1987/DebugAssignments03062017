// Creates a HomeworkAssignment class
// instantiates two objects
// and prompts the user for information about two courses

using System;
using static System.Console;
class DebugNine1
{
    static void Main()
    {
        HomeworkAssignment course1 = new HomeworkAssignment();
        HomeworkAssignment course2 = new HomeworkAssignment();
        string entryString = null;
        int exercises;

        // Get info for first class
        Write("What class do you have homework for? ");
        var entry = ReadLine();
        course1.ClassName = entry;
        Write("How many exercises must you complete? ");
        entryString = ReadLine();
        int.TryParse(entryString, out exercises);
        course1.NumberOfExercises = exercises;

        // Get info for another class
        Write("What class do you have homework for? ");
        entryString = ReadLine();
        course2.ClassName = entryString;
        Write("How many exercises must you complete? ");
        entryString = ReadLine();
        int.TryParse(entryString, out exercises);
        course2.NumberOfExercises = exercises;

        course1.CalcCompletionTime();
        course2.CalcCompletionTime();

        WriteLine("You have {0} minutes of homework for {1}",
              course1.timeToComplete, course1.ClassName);
        WriteLine("and {0} minutes of homework for {1}",
              course2.timeToComplete, course2.ClassName);
    }
}
class HomeworkAssignment
{
    
    public int timeToComplete;
    public int NumberOfExercises { get; set; }
    public string ClassName { get; set; }

    // 10 minutes to complete each exercise
    private const int TIME_PER_EXERCISE = 10;

    public void CalcCompletionTime()
    {
        timeToComplete = NumberOfExercises * TIME_PER_EXERCISE;
    }
};



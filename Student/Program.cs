using System;

class Student
{
    public string Name { get; }
    public int koreanScore;
    public int englishscore;
    public int mathscore;

    public int KoreaScore
    {
        get { return koreanScore; }
        set 
        {
            if (value > 100)
            {
                value = 100;
            }
            else if (value < 0)
            {
                value = 0;
            }
        }
    }
    public int EnglishScore
    {
        get { return englishscore; }
        set
        {
            if (value > 100)
            {
                value = 100;
            }
            else if (value < 0)
            {
                value = 0;
            }
        }
    }
    public int MathScore
    {
        get { return mathscore; }
        set
        {
            if (value > 100)
            {
                value = 100;
            }
            else if (value < 0)
            {
                value = 0;
            }
        }
    }



}
﻿namespace LearningDotnetConcepts
{
    public class TuplesAndAnonymousTypes
    {
       public  static void main(string[] args)
        {
            var person=Tuple.Create("Mohamed Saleem", 33, 9578795653);
            Console.WriteLine(person.Item1);
        }

    }
}
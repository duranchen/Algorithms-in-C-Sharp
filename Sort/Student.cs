using System;

namespace Algorithms.Sort
{
    class Student : IComparable
    {
        string name;
        int score;

        public Student(string n, int s)
        {
            name = n;
            score = s;
        }

        public int CompareTo(object obj)
        {
            Student s = (Student)obj;

            if (score == s.score)
            {
                return name.CompareTo(s.name);
            }
            else
            {
                return score.CompareTo(s.score);
            }
        }

        public override string ToString()
        {
            return name + " " + score;
        }

    }
}

﻿
namespace ChallengeApp7.Tests
{
    internal class Employee
    {
        private string v1;
        private string v2;

        public Employee(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public int Result { get; internal set; }

        internal void AddScore(int v)
        {
            throw new NotImplementedException();
        }
    }
}
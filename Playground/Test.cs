using System;

namespace Playground
{
    public class Test
    {
        private int test;
        private string name;


        public Test(int test, string name)
        {
            this.test = test;
            this.name = name;
        }

        public int Test1
        {
            get => test;
            set => test = value;
        }

        public string Name
        {
            get => name;
            set => name = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}
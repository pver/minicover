﻿using System.Threading.Tasks;

namespace Sample
{
    public class AnotherClass
    {
        private int _someProperty = 7;

        public int SomeProperty
        {
            get
            {
                return _someProperty;
            }
            set
            {
                _someProperty = value;
            }
        }

        public int SomeMethod()
        {
            return SomeProperty * 2;
        }

        public void AnotherMethod()
        {
            for (var i = 0; i < 50000; i++)
            {
                SomeMethod();
            }
        }

        public Task AMethodAsync()
        {
            return Task.FromResult(1);
        }

        public void AMethodNotAsync()
        {
            SomeProperty++;
        }
    }
}

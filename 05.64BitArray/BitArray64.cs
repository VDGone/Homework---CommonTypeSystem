namespace _05._64BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    class BitArray64 : IEnumerable<int>, IComparable
    {
        private ulong someValue;

        public BitArray64(ulong someValue)
        {
            this.SomeValue = someValue;
        }

        public ulong SomeValue
        {
            get { return this.someValue; }
            private set { this.someValue = value; }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid position.");
                }

                return ((int)(this.SomeValue >> index) & 1);
            }
            set
            {
                if (index < 0 || index >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid position.");
                }

                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Invalid bit value.");
                }

                if (((int)(this.SomeValue >> index) & 1) != value)
                {
                    this.SomeValue ^= (1ul << index);
                }
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int CompareTo(object obj)
        {
            return this.SomeValue.CompareTo((obj as BitArray64).SomeValue);
        }

        public override int GetHashCode()
        {
            return this.SomeValue.GetHashCode() ^ this.SomeValue.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.SomeValue.Equals((obj as BitArray64).SomeValue);
        }

        public static bool operator ==(BitArray64 bitArrOne, BitArray64 bitArrTwo)
        {
            return (bitArrOne.Equals(bitArrTwo));
        }

        public static bool operator !=(BitArray64 bitArrOne, BitArray64 bitArrTwo)
        {
            return !(bitArrOne.Equals(bitArrTwo));
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < 64; i++)
            {
                result.Insert(0, ((this.SomeValue >> i) & 1));
            }

            return result.ToString();
        }
    }
}

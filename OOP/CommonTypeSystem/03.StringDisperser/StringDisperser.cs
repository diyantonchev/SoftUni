namespace _03.StringDisperser
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable
    {
        public StringDisperser(params string[] strings)
        {
            this.Strings = new List<string>(strings);
        }

        public List<string> Strings { get; set; }

        public object Clone()
        {
            return new StringDisperser(this.Strings.ToArray());
        }

        public int CompareTo(StringDisperser other)
        {
            return (string.Compare(this.ToString(), other.ToString(), StringComparison.InvariantCulture));
        }

        public IEnumerator GetEnumerator()
        {
            var totalString = this.ToString();

            for (int i = 0; i < totalString.Length; i++)
            {
                yield return totalString[i];
            }
        }

        public override bool Equals(object obj)
        {
            var otherDisperser = obj as StringDisperser;

            if (otherDisperser == null)
            {
                return false;
            }

            if (this.Strings.Count.CompareTo(otherDisperser.Strings.Count) != 0)
            {
                return false;
            }

            bool isEqual = true;
            for (int i = 0; i < this.Strings.Count; i++)
            {
                if (this.Strings[i] != otherDisperser.Strings[i])
                {
                    isEqual = false;
                    break;
                }
            }
            return isEqual;
        }

        public override int GetHashCode()
        {
            var hashCode = this.Strings.GetHashCode();

            foreach (var str in this.Strings)
            {
                hashCode ^= str.GetHashCode();
            }
            return hashCode;
        }

        public static bool operator ==(StringDisperser str1, StringDisperser str2)
        {
            return Equals(str1, str2);
        }

        public static bool operator !=(StringDisperser str1, StringDisperser str2)
        {
            return !(Equals(str1, str2));
        }

        public override string ToString()
        {
            var stringDisperser = new StringBuilder();

            foreach (var str in this.Strings)
            {
                stringDisperser.Append(str);
            }
            return stringDisperser.ToString();
        }
    }
}
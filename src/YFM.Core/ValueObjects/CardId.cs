using System;

namespace YFM.Core.ValueObjects
{
    public struct CardId : IEquatable<CardId>
    {
        public int Value { get; }

        public CardId(int value)
        {
            Value = value;
        }

        public bool Equals(CardId other)
        {
            return Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            return obj is CardId other && Equals(other);
        }

        public override int GetHashCode()
        {
            return Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator int(CardId id)
        {
            return id.Value;
        }

        public static explicit operator CardId(int id)
        {
            return new CardId(id);
        }
    }
}

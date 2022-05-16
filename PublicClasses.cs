namespace NewFeaturesApp
{
    public class Genre
    {
        readonly string _value;
        public Genre(string value)
        { this._value = value; }
        public static implicit operator string(Genre d)
        { return d._value; }
        public static implicit operator Genre(string d)
        { return new Genre(d); }
    }
    public class Year
    {
        readonly uint _value;
        public Year(uint value)
        { this._value = value; }
        public static implicit operator uint(Year d)
        { return d._value; }
        public static implicit operator Year(uint d)
        { return new Year(d); }
    }
    public class Label
    {
        readonly string _value;
        public Label(string value)
        { this._value = value; }
        public static implicit operator string(Label d)
        { return d._value; }
        public static implicit operator Label(string d)
        { return new Label(d); }
    }
}

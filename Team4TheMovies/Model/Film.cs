using System;

public class Film
{
	private string name;

	public string Name
	{
		get { return name; }
		set { name = value; }
	}
	private DateTime duration;

	public DateTime Duration
	{
		get { return duration; }
		set { duration = value; }
	}
	private string genre;

	public string Genre
	{
		get { return genre; }
		set { genre = value; }
	}

    public Film(string name, string duration, string genre)
    {
		string durationFormat = "HH:mm";
		Duration = DateTime.ParseExact(duration, durationFormat, null);
    }
}

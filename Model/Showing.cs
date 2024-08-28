using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using theMovies;

namespace TheMoviesNy.Model
{
    public class Showing
    {
        private Film film;
        private DateTime timeAndDate;
        private DateOnly date;
        private TimeOnly timeStart;
        private TimeOnly timeEnd;
        private string room;
        private TimeSpan duration;
        private string mail;
        private string phone;

        public Showing(Film film, DateOnly date, TimeOnly timeStart, string? room, string mail, string phone) 
        {
            this.film = film;
            this.date = date;
            this.timeStart = timeStart;
            timeAndDate = new DateTime(date, timeStart);
            duration = film.Duration.Add(new TimeSpan(0,30,0));
            timeEnd = timeStart.Add(duration);
            this.room = room;
            this.mail = mail;
            this.phone = phone;
        }

        public Showing(Film film, string date, string timeStart, string? room, string mail, string phone)
        {
            this.film = film;
            this.date = dateOnlyFromString(date);
            this.timeStart = timeOnlyFromString(timeStart);
            timeAndDate = new DateTime(this.date, this.timeStart);
            duration = film.Duration.Add(new TimeSpan(0, 30, 0));
            timeEnd = this.timeStart.Add(this.duration);
            this.room = room;
            this.mail = mail;
            this.phone = phone;
        }
        public override string ToString()
        {
            return timeAndDateToString() + ";" + film.ToString() + ";" + mail + ";" + phone;
        }
        public string timeAndDateToString() 
        {
            string timeAndDateFormat = "yyyy/mm/dd HH:mm";
            return timeAndDate.ToString(timeAndDateFormat);
        }
        public DateOnly dateOnlyFromString(string dateOnly)
        {
            //string dateFormat = "yyyy-mm-dd";
            return DateOnly.Parse(dateOnly);
        }
        public TimeOnly timeOnlyFromString(string timeOnly)
        {
            string timeFormat = "HH:mm";
            return TimeOnly.ParseExact(timeOnly, timeFormat, null);
        }
        public DateTime dateTimeFromString(string dateTime)
        {
            string dateTimeFormat = "yyyy/mm/dd";
            return DateTime.ParseExact(dateTime, dateTimeFormat, null);
        }
    }
}

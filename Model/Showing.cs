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

        public Showing(Film film, DateOnly date, TimeOnly timeStart, string room) 
        {
            this.film = film;
            this.date = date;
            this.timeStart = timeStart;
            timeAndDate = new DateTime(date, timeStart);
            duration = film.Duration;
            timeEnd = timeStart.Add(duration);
            this.room = room;
            
        }
        public override string ToString() 
        { 
            throw new NotImplementedException();
        }

    }
}

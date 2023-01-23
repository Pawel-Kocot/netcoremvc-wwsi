using FilmDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FilmDB.Logic
{
    public class FilmManager
    {
        public FilmManager AddFilm(FilmModel filmModel)
        {
            using (var context = new FilmContext())
            {
                try
                {
                    context.Add(filmModel);
                    context.SaveChanges();
                }
                catch (System.Exception e)
                {
                    filmModel.Id = 0;
                    context.Add(filmModel);
                    context.SaveChanges();
                }
            }
            return this;
        }

        public FilmManager RemoveFilm(int id)
        {
            FilmModel filmModelToDelete;
            using(var context = new FilmContext())
            {
                filmModelToDelete = context.Films.Single(x => x.Id == id);
                context.Films.Remove(filmModelToDelete);
                context.SaveChanges();
            }
            return this;
        }

        public FilmManager UpdateFilm(FilmModel filmModel)
        {
            using (var context = new FilmContext())
            {
                context.Films.Update(filmModel);
                context.SaveChanges();
            }
            return this;
        }

        public FilmManager ChangeTitle(int id, string newTitle)
        {
            using (var context = new FilmContext())
            {
                var filmModel = context.Films.Single(x => x.Id == id);
                if (string.IsNullOrEmpty(newTitle))
                {
                    newTitle = "Brak Tytułu";
                }
                filmModel.Name = newTitle;
                this.UpdateFilm(filmModel);
            }
            return this;
        }

        public FilmModel GetFilm(int id)
        {
            using (var context = new FilmContext())
            {
                var film = context.Films.Single(x => x.Id == id);
                return film;
            }
        }

        public List<FilmModel> GetFilms()
        {
            using (var context = new FilmContext())
            {
                var film = context.Films.ToList();
                return film;
            }
        }
    }
}

using DaylyHelper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaylyHelper.Data.Services
{
    public class DaylyHelperData : IDayHelperData
    {
        private readonly DayHelperDbContext db;

        public DaylyHelperData(DayHelperDbContext db)
        {
            this.db = db;
        }
        public void AddNote(int id,Note note)
        {
            var current = GetProject(id);
            current.Notes.Add(note);
            Modifie(current);
            db.SaveChanges();
        }

        public void AddProject(Project project)
        {
            db.Projects.Add(project);
            db.SaveChanges();
        }

        public void DeleteNote(int id)
        {
            var note = db.Notes.Find(id);
            db.Notes.Remove(note);
            db.SaveChanges();
        }

        public void DeleteProject(int id)
        {
            var project = db.Projects.Find(id);
            db.Entry(project).Collection(n => n.Notes).Load();
            var projectNotes = project.Notes;
            db.Notes.RemoveRange(projectNotes);
            db.Projects.Remove(project);
            db.SaveChanges();
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return db.Projects.OrderBy(n => n.Title);
        }

        public Project GetProject(int id)
        {
            var project = db.Projects.Find(id);
            db.Entry(project).Collection(n => n.Notes).Load();
            return project;
        }

        public void Modifie(Project project)
        {
            var current = GetProject(project.Id);
            current.Modified = DateTime.Now.Date;
            db.SaveChanges();
        }

        public IEnumerable<Note> ProjectNotes(int id)
        {
            var model = GetProject(id);
            return model.Notes;
        }

        public void Update(Project project)
        {
            var current = GetProject(project.Id);
            if(current!=null)
            {
                current.Title = project.Title;
                current.Description = project.Description;
                current.Done = project.Done;
            }
                Modifie(current);
            db.SaveChanges();
        }

    }
}

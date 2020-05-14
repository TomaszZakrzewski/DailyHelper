using DaylyHelper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaylyHelper.Data.Services
{
    public interface IDayHelperData
    {
        void AddProject(Project project);
        Project GetProject(int id);
        IEnumerable<Project> GetAllProjects();
        void AddNote(int id,Note note);
        void Update(Project project);
        void Modifie(Project project);
        IEnumerable<Note> ProjectNotes(int id);
        void DeleteProject(int id);
        void DeleteNote(int id);
    }
}

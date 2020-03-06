using Repository.Contracts;
using Repository.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDbContext _context;
        private ITeacherRepository _teacher;
        private IStudentRepository _student;
        private IParentRepository _parent;
        private IClassRepository _class;
        private IProfileRepository _profile;
        private IStudentClassGrade _studentClassGrades;
        public ITeacherRepository Teachers
        {
            get
            {
                if (_teacher == null)
                {
                    _teacher = new TeacherRepository(_context);
                }
                return _teacher;
            }
        }
        public IStudentRepository Students
        {
            get
            {
                if (_student == null)
                {
                    _student = new StudentRepository(_context);
                }
                return _student;
            }
        }
        public IParentRepository Parents
        {
            get
            {
                if (_parent == null)
                {
                    _parent = new ParentRepository(_context);
                }
                return _parent;
            }
        }
        public IClassRepository Classes
        {
            get
            {
                if (_class == null)
                {
                    _class = new ClassRepository(_context);
                }
                return _class;
            }
        }
        public IProfileRepository Profiles
        {
            get
            {
                if (_profile == null)
                {
                    _profile = new ProfileRepository(_context);
                }
                return _profile;
            }
        }
        public IStudentClassGrade StudentClassGrades
        {
            get
            {
                if (_studentClassGrades == null)
                {
                    _studentClassGrades = new StudentClassGradesRepository(_context);
                }
                return _studentClassGrades;
            }
        }
        public RepositoryWrapper(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

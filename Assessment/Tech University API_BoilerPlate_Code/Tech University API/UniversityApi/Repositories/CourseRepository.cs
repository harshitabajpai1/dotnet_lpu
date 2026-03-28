using Microsoft.EntityFrameworkCore;
using UniversityApi.Data;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Repositories
{
    public class CourseRepository : ICourse
    {
        // Implement your code here
        private readonly UniversityContext _context;

        public CourseRepository(UniversityContext context)
        {
            _context = context;
        }

        public bool UpdateCourse(Course course)
        {
            var existingCourse = _context.Courses.FirstOrDefault(c => c.CourseId == course.CourseId);

            if (existingCourse == null)
            {
                return false;
            }

            existingCourse.Title = course.Title;
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<Course> GetCoursesWithEnrollmentsAboveGrade(int grade)
        {
            return _context.Courses
                .Include(c => c.Enrollments)
                .Where(c => c.Enrollments.Any(e => e.Grade > grade))
                .ToList();
        }

        public IEnumerable<Course> GetCoursesByInstructorName(string instructorName)
        {
            return _context.InstructorCourses
                .Include(ic => ic.Instructor)
                .Include(ic => ic.Course)
                .Where(ic => ic.Instructor.Name == instructorName)
                .Select(ic => ic.Course)
                .Distinct()
                .ToList();
        }
    }
}
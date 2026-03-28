using Microsoft.EntityFrameworkCore;
using UniversityApi.Data;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Repositories
{
    public class InstructorRepository : IInstructor
    {
        // Implement your code here
        private readonly UniversityContext _context;

        public InstructorRepository(UniversityContext context)
        {
            _context = context;
        }

        public bool AddInstructor(Instructor instructor)
        {
            var existingInstructor = _context.Instructors
                .FirstOrDefault(i => i.InstructorId == instructor.InstructorId);

            if (existingInstructor != null)
            {
                return false;
            }

            _context.Instructors.Add(instructor);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<Instructor> GetInstructorsWithCourseCountAbove(int count)
        {
            return _context.Instructors
                .Include(i => i.InstructorCourses)
                .Where(i => i.InstructorCourses.Count > count)
                .ToList();
        }

        public IEnumerable<Instructor> GetInstructorsWithMostEnrollments()
        {
            var instructorEnrollmentCounts = _context.Instructors
                .Include(i => i.InstructorCourses)
                    .ThenInclude(ic => ic.Course)
                        .ThenInclude(c => c.Enrollments)
                .Select(i => new
                {
                    Instructor = i,
                    EnrollmentCount = i.InstructorCourses
                        .SelectMany(ic => ic.Course.Enrollments)
                        .Count()
                })
                .ToList();

            if (!instructorEnrollmentCounts.Any())
            {
                return new List<Instructor>();
            }

            var maxEnrollmentCount = instructorEnrollmentCounts.Max(x => x.EnrollmentCount);

            return instructorEnrollmentCounts
                .Where(x => x.EnrollmentCount == maxEnrollmentCount)
                .Select(x => x.Instructor)
                .ToList();
        }
    }
}

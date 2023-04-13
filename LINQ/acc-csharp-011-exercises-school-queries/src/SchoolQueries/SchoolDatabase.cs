namespace SchoolQueries;

public class SchoolDatabase : ISchoolDatabase
{
    public Student[] Students { get; set; }
    public Project[] Projects { get; set; }
    public ProjectGrade[] ProjectGrades { get; set; }

    public Student[] GetStudentsByName(string name)
    {
        // var studentByName = from student in Students
        //                     where student.Name == name
        //                     select student;
        // return studentByName.ToArray();
        return Students.Where(student => student.Name == name).ToArray();
    }

    public Student[] GetStudentsWithAverageGradeInProjectAbove(int gradeInput)
    {
        // var studentGradeAverage = from item in ProjectGrades
        //                         where item.Grades.Average() > gradeInput

        //                         from student in Students
        //                         where student.Id == item.StudentId
        //                         select student;
        // return studentGradeAverage.ToArray();

        return ProjectGrades.Where(item => item.Grades.Average() > gradeInput)
                            .Join(Students, item => item.StudentId, student => student.Id, (item, student) => student)
                            .ToArray();
    }

    public Project[] GetProjectsWithMinimumGradeInProjectBelow(int gradeInput)
    {
        // var projectMinGrade = from item in ProjectGrades
        //                               where item.Grades.Min() < gradeInput

        //                               from project in Projects
        //                               where project.Id == item.ProjectId
        //                               select project;
        // return projectMinGrade.ToArray();

        return ProjectGrades.Where(item => item.Grades.Min() < gradeInput)
                            .Join(Projects, item => item.ProjectId, project => project.Id, (item, project) => project)
                            .ToArray();
    }

    public Student[] GetStudentsDoneProject(string projectName)
    {
        // var studentProject = from item in ProjectGrades
        //                          join student in Students on item.StudentId equals student.Id
        //                          join project in Projects on item.ProjectId equals project.Id
        //                          where project.Name == projectName
        //                          select student;
        // return studentProject.ToArray();

        return ProjectGrades.Join(Students, item => item.StudentId, student => student.Id, (item, student) => new { item, student })
                            .Join(Projects, item => item.item.ProjectId, project => project.Id, (item, project) => new { item, project })
                            .Where(item => item.project.Name == projectName)
                            .Select(item => item.item.student)
                            .ToArray();
    }
}
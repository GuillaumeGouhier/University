
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Study {

    public Study(String name) {
        this.name = name;
        students = new List<Student>();
        subjects = new HashSet<Subject>();
    }

    private String name;
    private List<Student> students;
    private HashSet<Subject> subjects;

    public String getName()
    {
        return this.name;
    }

    public void setName(String name)
    {
        this.name = name;
    }

    public List<Student> getStudents()
    {
        return this.students;
    }

    public void setStudents(List<Student> students)
    {
        this.students = students;
    }

    public HashSet<Subject> getSubjects()
    {
        return this.subjects;
    }

    public void setSubjects(HashSet<Subject> subjects)
    {
        this.subjects = subjects;
    }


    /// <summary>
    /// @return
    /// </summary>
    public void addSubject(Subject toAdd) {
        // TODO implement here
        subjects.Add(toAdd);
    }

    /// <summary>
    /// @return
    /// </summary>
    public void deleteSubject(Subject toDel) {
        // TODO implement here
        subjects.Remove(toDel);
    }

    public void addStudent(Student toAdd){
        students.Add(toAdd);
        toAdd.setStudy(this);
    }

    public void deleteStudent(Student toDel){
        students.Remove(toDel);
    }

}
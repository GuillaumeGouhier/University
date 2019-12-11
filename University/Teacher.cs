
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Teacher : People {

    public Teacher(String name, String firstName, DateTime birthdate): base(name, firstName, birthdate) {
    }

    private HashSet<String> possibleSubjects;
    private Subject teacher;

    public void addNote() {
        // TODO implement here
    }

    public void getNotes() {
        // TODO implement here
    }

}
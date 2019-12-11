
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Student : People {

    private Study study;

    public Study getStudy()
    {
        return this.study;
    }

    public void setStudy(Study study)
    {
        this.study = study;
    }

    public Student(String name, String firstName, DateTime birthdate) : base(name, firstName, birthdate) 
    {
        
    }

    public List<Note> getHisNotes() {
        return new List<Note>();
    }

    public void getMean(){
        List<Double> means = getMeanBySubject();
        Double acc = 0;
        int total = 0;
        foreach(Double item in means){
            acc += item;
            total++;
        }

        Console.WriteLine((double)acc/total);
    }

    public List<Double> getMeanBySubject(){
        List<Double> result = new List<Double>();
         foreach(Subject item in getStudy().getSubjects()){
            result.Add(item.getStudMean(name));
        }

        return result;
    }

}
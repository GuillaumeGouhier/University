
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Subject {

    public Subject(String name, int hours, int coeff, String content, Teacher teacher) {
        this.name = name;
        this.hours = hours;
        this.coeff = coeff;
        this.content = content;
        this.teacher = teacher;
        this.evaluations = new List<Eval>();
    }

    private String name;
    private int hours;
    private int coeff;
    private String content;
    private Teacher teacher;
    private List<Eval> evaluations;

    public List<Eval> getEvaluations()
    {
        return this.evaluations;
    }

    public void setEvaluations(List<Eval> evaluations)
    {
        this.evaluations = evaluations;
    }


    public String getName()
    {
        return this.name;
    }

    public void setName(String name)
    {
        this.name = name;
    }

    public int getHours()
    {
        return this.hours;
    }

    public void setHours(int hours)
    {
        this.hours = hours;
    }

    public int getCoeff()
    {
        return this.coeff;
    }

    public void setCoeff(int coeff)
    {
        this.coeff = coeff;
    }

    public String getContent()
    {
        return this.content;
    }

    public void setContent(String content)
    {
        this.content = content;
    }

    public Teacher getTeacher()
    {
        return this.teacher;
    }

    public void setTeacher(Teacher teacher)
    {
        this.teacher = teacher;
    }


    public void addEval(Eval toAdd){
        evaluations.Add(toAdd);
    }

    public double getStudMean(String studName){
        int acc = 0;
        int total = -1;

        foreach(Eval item in evaluations){
            acc += item.getStudentNote(studName).getValue() * item.getCoeff();
            total += item.getCoeff();
        }
        double result = (double)acc / (total+1);    
        if(total > -1) return result;
        return -1;
    }


}
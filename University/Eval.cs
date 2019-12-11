using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Eval{

    private String name;
    List<Note> notes;
    int maxValue;
    int minValue;
    int coeff;

    public int getCoeff()
    {
        return this.coeff;
    }

    public void setCoeff(int coeff)
    {
        this.coeff = coeff;
    }


    public String getName()
    {
        return this.name;
    }

    public void setName(String name)
    {
        this.name = name;
    }

    public List<Note> getNotes()
    {
        return this.notes;
    }

    public void setNotes(List<Note> notes)
    {
        this.notes = notes;
    }

    public int getMaxValue()
    {
        return this.maxValue;
    }

    public void setMaxValue(int maxValue)
    {
        this.maxValue = maxValue;
    }

    public int getMinValue()
    {
        return this.minValue;
    }

    public void setMinValue(int minValue)
    {
        this.minValue = minValue;
    }


    public Eval(string name, int minValue = 0, int maxValue = 20, int coeff = 1){
        this.name = name;
        this.maxValue = maxValue;
        this.minValue = minValue;
        notes = new List<Note>();
        this.coeff = coeff;
    }

    public void addNote(Note toAdd){
        notes.Add(toAdd);
    }

    //queries in List
    public List<Note> sortByNote(bool ascending){
        return notes.OrderBy(item => item.getValue()).ToList();
    }

    public List<Note> sortByName(bool ascending){
        return notes.OrderBy(item => item.getStudentName()).ToList();

    }

    public Note getStudentNote(string studentName){
        Note result = notes.Find(x => x.getStudentName() == studentName);
        return result;
    }
}
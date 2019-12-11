
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Note {

    private String studentName;
    private int value;
    private DateTime date;
    private String comment;

    public String getStudentName()
    {
        return this.studentName;
    }

    public void setStudentName(String studentName)
    {
        this.studentName = studentName;
    }

    public int getValue()
    {
        return this.value;
    }

    public void setValue(int value)
    {
        this.value = value;
    }

    public DateTime getDate()
    {
        return this.date;
    }

    public void setDate(DateTime date)
    {
        this.date = date;
    }

    public String getComment()
    {
        return this.comment;
    }

    public void setComment(String comment)
    {
        this.comment = comment;
    }

    public Note(String studentName, int value, String comment = "") {
        this.studentName = studentName;
        this.value = value;
        this.date = date;
        this.comment = comment;
    }

}
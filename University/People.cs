
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class People {

    public People(String name, String firstName, DateTime birthdate) {
        this.name = name;
        this.firstName = firstName;
        this.birthdate = birthdate;
    }

    protected String name;

    protected String firstName;

    protected DateTime birthdate;

    public String getName()
    {
        return this.name;
    }

    public void setName(String name)
    {
        this.name = name;
    }

    public String getFirstName()
    {
        return this.firstName;
    }

    public void setFirstName(String firstName)
    {
        this.firstName = firstName;
    }

    public DateTime getBirthdate()
    {
        return this.birthdate;
    }

    public void setBirthdate(DateTime birthdate)
    {
        this.birthdate = birthdate;
    }


    /// <summary>
    /// @return
    /// </summary>
    public int getAge() {

        var today = DateTime.Today;
        var age = today.Year - birthdate.Year;
        if (birthdate.Date > today.AddYears(-age)) age--;

        return age;
    }

}
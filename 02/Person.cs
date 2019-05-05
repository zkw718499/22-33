using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Person : IComparable<Person> {

    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }


    public int CompareTo(Person other)
    {
        if(this.Age > other.Age)
        {
            Debug.Log(this.Name + "的年龄大");
            return 1;
        }

        if(this.Age < other.Age)
        {
            Debug.Log(other.Name + "的年龄大");
            return -1;
        }

        Debug.Log("两个对象的年龄一样大");
        return 0;
    }
}

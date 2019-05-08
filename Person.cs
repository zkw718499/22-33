using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//人物信息（临时工作保存）
public class Person : IComparable<Person> {
	//合并后的第一次修改
	//合并后的第二次修改
    private string name;
    private int age;
	private string address;
	private int height;
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

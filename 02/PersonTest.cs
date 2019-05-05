using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonTest : MonoBehaviour {

    private List<Person> personList = new List<Person>();

	void Start () {
        Person p1 = new Person();
        p1.Name = "Monkey";
        p1.Age = 15;
        
        Person p2 = new Person();
        p2.Name = "擅码网";
        p2.Age = 3;

        Person p3 = new Person();
        p3.Name = "李开坤";
        p3.Age = 28;

        //Debug.Log(p1.CompareTo(p2));

        personList.Add(p1);
        personList.Add(p2);
        personList.Add(p3);

        personList.Sort();

        for (int i = 0; i < personList.Count; i++)
        {
            Debug.Log(personList[i].Name);
        }
	}

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(new Vector3(0, 0, 0), new Vector3(0, 0, 10));
        Gizmos.DrawCube(new Vector3(5, 5, 5), Vector3.one);
    }
}

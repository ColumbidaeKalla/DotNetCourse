namespace DotNetCourse.src.SessionThree.AppClass;
using System;

public class StudentIndexer {
    public readonly string[] NameList;

    public StudentIndexer(int maxSize) {
        NameList = new string[maxSize];
    }

    //Defining an indexer - <modifier> <return type> this [arhument list]
    public string this[int index] {
        get => NameList[index];
        set => NameList[index] = value;
    }
}
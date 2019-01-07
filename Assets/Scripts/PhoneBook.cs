using System;
using System.Collections;
using System.Collections.Generic;

public class PhoneBook : JsonObject
{
    public Dictionary<string, Group> groups = new Dictionary<string, Group>();

    public void AddGroup(Group group)
    {
        groups.Add(group.name, group);
    }
}

public class Group
{
    public string name = string.Empty;
    public Dictionary<string, Person> members = new Dictionary<string, Person>();

    public Group()
    {
    }

    public Group(string name)
    {
        this.name = name;
    }

    public void AddContact(Person contact)
    {
        members.Add(contact.name, contact);
    }
}

public class Person
{
    public string name = String.Empty;
    public ushort age = 0;
    public string phoneNumber = String.Empty;

    public Person()
    {

    }

    public Person(string name, ushort age, string phoneNumber)
    {
        this.name = name;
        this.age = age;
        this.phoneNumber = phoneNumber;
    }
}


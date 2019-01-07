using UnityEngine;
using System.Collections;
using System.IO;

public class SampleScene : MonoBehaviour
{
    void Start()
    {
        PhoneBook pb = new PhoneBook();

        Group school = new Group("MIT");
        Group harvard = new Group("Harvard");

        Person nayoung = new Person("nayoung", 21, "010-0000-000");
        Person sohee = new Person("sohee", 22, "010-0000-000");
        Person hyosung = new Person("hyosung", 20, "010-0000-000");

        school.AddContact(nayoung);
        school.AddContact(sohee);
        school.AddContact(hyosung);

        Person dog = new Person("dog", 21, "010-0000-000");
        Person pig = new Person("pig", 22, "010-0000-000");
        Person cow = new Person("cow", 20, "010-0000-000");

        harvard.AddContact(dog);
        harvard.AddContact(pig);
        harvard.AddContact(cow);

        pb.groups.Add(school.name, school);
        pb.groups.Add(harvard.name, harvard);

        string jsonData = pb.ToJson();
        string filePath = Path.Combine(Application.streamingAssetsPath, string.Format("{0}.json", "phonebook"));
        Debug.LogFormat("Local Client Save : {0} // {1}", filePath, jsonData);
        File.WriteAllText(filePath, jsonData);

        string readJson = File.ReadAllText(filePath);
        PhoneBook copypb = JsonObject.Parse<PhoneBook>(readJson);

        Debug.LogFormat("copy pb toJson : {0}", copypb.ToJson());
    }
}

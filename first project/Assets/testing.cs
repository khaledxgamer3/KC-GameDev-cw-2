using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         string hero__name = "name:ben_10";
        int hero_Height = 172;
        int hero_age = 12;
        string hero_superpower = "power:genetic change";

        string villian_name = "name:zombozo";
        int villain_Height = 170;
        int villain_age = 20;
        string villain_superpower = "power:Illusion Generation";

        int age_difference = villain_age - hero_age;

        print(hero__name);
        print(hero_Height + 5);
        print(hero_age);
        print(hero_superpower);

        print(villian_name);
        print(villain_Height);
        print(villain_age);
        print(villain_superpower = "power:none");
        print(age_difference);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

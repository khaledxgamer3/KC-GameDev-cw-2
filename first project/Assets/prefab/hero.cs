using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string hero__name = "ben_10";
        int hero_Height = 172;
        int hero_age = 12;
        string hero_superpower = "shooting_Fire_balls";

        string villian_name = "zombozo";
        int villain_Height = 170;
        int villain_age = 20;
        string villain_superpower = "Illusion Generation";

        int age_difference = villain_age - hero_age;

        print(hero__name);
        print(hero_Height);
        print(hero_age);
        print(hero_superpower);

        print(villian_name);
        print(villain_Height);
        print(villain_age);
        print(villain_superpower);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

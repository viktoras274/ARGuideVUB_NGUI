using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownOptions : MonoBehaviour
{
    List<string> names = new List<string>() { "Indoors Navigation Mode", 
                                              "Cafeteria - D",
                                              "Cafeteria - G",
                                              "Cafeteria - I",
                                              "Cafeteria - K",
                                              "Building D - Cafeteria",
                                              "Building D - I",
                                              "Building D - G",
                                              "Building D - K",
                                              "Building G - Cafeteria",
                                              "Building G - D",
                                              "Building G - I",
                                              "Building G - K",
                                              "Building I - Cafeteria",
                                              "Building I - D",
                                              "Building I - G",
                                              "Building I - K",
                                              "Building K - Cafeteria",
                                              "Building K - D",
                                              "Building K - G",
                                              "Building K - I"
                                              };


    public Dropdown dropdown;

    //REFERENCE!!!
    private void Start()
    {
        PopulateList();
    }

    void PopulateList()
    {

        dropdown.AddOptions(names);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ARLocation.Utils;
using ARLocation;

public class RouteController : MonoBehaviour
{
    // Mapbox Custom Routes
    public GameObject Caf_DRoute;
    public GameObject Caf_GRoute;
    public GameObject Caf_IRoute;
    public GameObject Caf_KRoute;

    public GameObject D_CafRoute;
    public GameObject D_IRoute;
    public GameObject D_GRoute;
    public GameObject D_KRoute;

    public GameObject G_CafRoute;
    public GameObject G_DRoute;
    public GameObject G_IRoute;
    public GameObject G_KRoute;

    public GameObject I_CafRoute;
    public GameObject I_DRoute;
    public GameObject I_GRoute;
    public GameObject I_KRoute;

    public GameObject K_CafRoute;
    public GameObject K_DRoute;
    public GameObject K_IRoute;
    public GameObject K_GRoute;



    // GPS Stage Objects
    public GameObject Caf_DGps;
    public GameObject Caf_GGps;
    public GameObject Caf_IGps;
    public GameObject Caf_KGps;

    public GameObject D_CafGps;
    public GameObject D_IGps;
    public GameObject D_GGps;
    public GameObject D_KGps;

    public GameObject G_CafGps;
    public GameObject G_DGps;
    public GameObject G_IGps;
    public GameObject G_KGps;

    public GameObject I_CafGps;
    public GameObject I_DGps;
    public GameObject I_GGps;
    public GameObject I_KGps;

    public GameObject K_CafGps;
    public GameObject K_DGps;
    public GameObject K_IGps;
    public GameObject K_GGps;


    public void DropDownHandler(int value)
    {

        if (value == 0)
        {
            /*Based on the value, which represents the enumeration of the Dropdown list 
             * options, we set the corresponding Route to Active or not Active.*/
            Caf_DRoute.SetActive(false);
            Caf_GRoute.SetActive(false);
            Caf_IRoute.SetActive(false);
            Caf_KRoute.SetActive(false);

            D_CafRoute.SetActive(false);
            D_IRoute.SetActive(false);
            D_GRoute.SetActive(false);
            D_KRoute.SetActive(false);

            G_CafRoute.SetActive(false);
            G_DRoute.SetActive(false);
            G_IRoute.SetActive(false);
            G_KRoute.SetActive(false);

            I_CafRoute.SetActive(false);
            I_DRoute.SetActive(false);
            I_GRoute.SetActive(false);
            I_KRoute.SetActive(false);

            K_CafRoute.SetActive(false);
            K_DRoute.SetActive(false);
            K_IRoute.SetActive(false);
            K_GRoute.SetActive(false);

            /*ARLocation.PlaceAtLocations script creates a List of clones of a Prefab 
             * GameObject to place in the given coordinates, thus in order to deactivate 
             * the GameObjects of the non selected Route we need to iterate through the 
             * instances of each "GPS Stage Object" GameObject and call on each one the 
             * "HideGameObject()" method, which deactivates the MeshRenderer of each 
             * instance. Respectivelly we call the "ShowGameObject()" method for the 
             * selected Route. */
            foreach (var go1 in Caf_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                //REFERENCE AR+GPS PACKAGE!!!
                Misc.HideGameObject(go1);
            }

            foreach(var go2 in Caf_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go2);
            }

            foreach(var go3 in Caf_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go3);
            }

            foreach(var go4 in Caf_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go4);
            }

            foreach (var go5 in D_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go5);
            }

            foreach (var go6 in D_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go6);
            }

            foreach (var go7 in D_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go7);
            }

            foreach (var go8 in D_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go8);
            }

            foreach (var go9 in G_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go9);
            }

            foreach (var go10 in G_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go10);
            }

            foreach (var go11 in G_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go11);
            }

            foreach (var go12 in G_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go12);
            }

            foreach (var go13 in I_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go13);
            }

            foreach (var go14 in I_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go14);
            }

            foreach (var go15 in I_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go15);
            }

            foreach (var go16 in I_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go16);
            }

            foreach (var go17 in K_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go17);
            }

            foreach (var go18 in K_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go18);
            }

            foreach (var go19 in K_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go19);
            }

            foreach (var go20 in K_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go20);
            }
        }

        if (value == 1)
        {
            /*Based on the value, which represents the enumeration of the Dropdown list 
             * options, we set the corresponding Route to Active or not Active.*/
            Caf_DRoute.SetActive(true);
            Caf_GRoute.SetActive(false);
            Caf_IRoute.SetActive(false);
            Caf_KRoute.SetActive(false);

            D_CafRoute.SetActive(false);
            D_IRoute.SetActive(false);
            D_GRoute.SetActive(false);
            D_KRoute.SetActive(false);

            G_CafRoute.SetActive(false);
            G_DRoute.SetActive(false);
            G_IRoute.SetActive(false);
            G_KRoute.SetActive(false);

            I_CafRoute.SetActive(false);
            I_DRoute.SetActive(false);
            I_GRoute.SetActive(false);
            I_KRoute.SetActive(false);

            K_CafRoute.SetActive(false);
            K_DRoute.SetActive(false);
            K_IRoute.SetActive(false);
            K_GRoute.SetActive(false);

            /*ARLocation.PlaceAtLocations script creates a List of clones of a Prefab 
             * GameObject to place in the given coordinates, thus in order to deactivate 
             * the GameObjects of the non selected Route we need to iterate through the 
             * instances of each "GPS Stage Object" GameObject and call on each one the 
             * "HideGameObject()" method, which deactivates the MeshRenderer of each 
             * instance. Respectivelly we call the "ShowGameObject()" method for the 
             * selected Route. */
            foreach (var go1 in Caf_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.ShowGameObject(go1);
            }

            foreach (var go2 in Caf_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go2);
            }

            foreach (var go3 in Caf_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go3);
            }

            foreach (var go4 in Caf_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go4);
            }

            foreach (var go5 in D_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go5);
            }

            foreach (var go6 in D_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go6);
            }

            foreach (var go7 in D_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go7);
            }

            foreach (var go8 in D_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go8);
            }

            foreach (var go9 in G_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go9);
            }

            foreach (var go10 in G_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go10);
            }

            foreach (var go11 in G_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go11);
            }

            foreach (var go12 in G_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go12);
            }

            foreach (var go13 in I_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go13);
            }

            foreach (var go14 in I_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go14);
            }

            foreach (var go15 in I_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go15);
            }

            foreach (var go16 in I_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go16);
            }

            foreach (var go17 in K_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go17);
            }

            foreach (var go18 in K_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go18);
            }

            foreach (var go19 in K_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go19);
            }

            foreach (var go20 in K_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go20);
            }
        }

        if (value == 2)
        {
            /*Based on the value, which represents the enumeration of the Dropdown list 
             * options, we set the corresponding Route to Active or not Active.*/
            Caf_DRoute.SetActive(false);
            Caf_GRoute.SetActive(true);
            Caf_IRoute.SetActive(false);
            Caf_KRoute.SetActive(false);

            D_CafRoute.SetActive(false);
            D_IRoute.SetActive(false);
            D_GRoute.SetActive(false);
            D_KRoute.SetActive(false);

            G_CafRoute.SetActive(false);
            G_DRoute.SetActive(false);
            G_IRoute.SetActive(false);
            G_KRoute.SetActive(false);

            I_CafRoute.SetActive(false);
            I_DRoute.SetActive(false);
            I_GRoute.SetActive(false);
            I_KRoute.SetActive(false);

            K_CafRoute.SetActive(false);
            K_DRoute.SetActive(false);
            K_IRoute.SetActive(false);
            K_GRoute.SetActive(false);

            /*ARLocation.PlaceAtLocations script creates a List of clones of a Prefab 
             * GameObject to place in the given coordinates, thus in order to deactivate 
             * the GameObjects of the non selected Route we need to iterate through the 
             * instances of each "GPS Stage Object" GameObject and call on each one the 
             * "HideGameObject()" method, which deactivates the MeshRenderer of each 
             * instance. Respectivelly we call the "ShowGameObject()" method for the 
             * selected Route. */
            foreach (var go1 in Caf_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go1);
            }

            foreach (var go2 in Caf_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.ShowGameObject(go2);
            }

            foreach (var go3 in Caf_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go3);
            }

            foreach (var go4 in Caf_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go4);
            }

            foreach (var go5 in D_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go5);
            }

            foreach (var go6 in D_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go6);
            }

            foreach (var go7 in D_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go7);
            }

            foreach (var go8 in D_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go8);
            }

            foreach (var go9 in G_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go9);
            }

            foreach (var go10 in G_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go10);
            }

            foreach (var go11 in G_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go11);
            }

            foreach (var go12 in G_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go12);
            }

            foreach (var go13 in I_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go13);
            }

            foreach (var go14 in I_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go14);
            }

            foreach (var go15 in I_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go15);
            }

            foreach (var go16 in I_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go16);
            }

            foreach (var go17 in K_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go17);
            }

            foreach (var go18 in K_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go18);
            }

            foreach (var go19 in K_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go19);
            }

            foreach (var go20 in K_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go20);
            }
        }

        if (value == 3)
        {
            /*Based on the value, which represents the enumeration of the Dropdown list 
             * options, we set the corresponding Route to Active or not Active.*/
            Caf_DRoute.SetActive(false);
            Caf_GRoute.SetActive(false);
            Caf_IRoute.SetActive(true);
            Caf_KRoute.SetActive(false);

            D_CafRoute.SetActive(false);
            D_IRoute.SetActive(false);
            D_GRoute.SetActive(false);
            D_KRoute.SetActive(false);

            G_CafRoute.SetActive(false);
            G_DRoute.SetActive(false);
            G_IRoute.SetActive(false);
            G_KRoute.SetActive(false);

            I_CafRoute.SetActive(false);
            I_DRoute.SetActive(false);
            I_GRoute.SetActive(false);
            I_KRoute.SetActive(false);

            K_CafRoute.SetActive(false);
            K_DRoute.SetActive(false);
            K_IRoute.SetActive(false);
            K_GRoute.SetActive(false);

            /*ARLocation.PlaceAtLocations script creates a List of clones of a Prefab 
             * GameObject to place in the given coordinates, thus in order to deactivate 
             * the GameObjects of the non selected Route we need to iterate through the 
             * instances of each "GPS Stage Object" GameObject and call on each one the 
             * "HideGameObject()" method, which deactivates the MeshRenderer of each 
             * instance. Respectivelly we call the "ShowGameObject()" method for the 
             * selected Route. */
            foreach (var go1 in Caf_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go1);
            }

            foreach (var go2 in Caf_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go2);
            }

            foreach (var go3 in Caf_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.ShowGameObject(go3);
            }

            foreach (var go4 in Caf_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go4);
            }

            foreach (var go5 in D_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go5);
            }

            foreach (var go6 in D_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go6);
            }

            foreach (var go7 in D_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go7);
            }

            foreach (var go8 in D_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go8);
            }

            foreach (var go9 in G_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go9);
            }

            foreach (var go10 in G_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go10);
            }

            foreach (var go11 in G_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go11);
            }

            foreach (var go12 in G_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go12);
            }

            foreach (var go13 in I_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go13);
            }

            foreach (var go14 in I_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go14);
            }

            foreach (var go15 in I_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go15);
            }

            foreach (var go16 in I_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go16);
            }

            foreach (var go17 in K_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go17);
            }

            foreach (var go18 in K_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go18);
            }

            foreach (var go19 in K_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go19);
            }

            foreach (var go20 in K_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go20);
            }
        }

        if (value == 4)
        {
            /*Based on the value, which represents the enumeration of the Dropdown list 
             * options, we set the corresponding Route to Active or not Active.*/
            Caf_DRoute.SetActive(false);
            Caf_GRoute.SetActive(false);
            Caf_IRoute.SetActive(false);
            Caf_KRoute.SetActive(true);

            D_CafRoute.SetActive(false);
            D_IRoute.SetActive(false);
            D_GRoute.SetActive(false);
            D_KRoute.SetActive(false);

            G_CafRoute.SetActive(false);
            G_DRoute.SetActive(false);
            G_IRoute.SetActive(false);
            G_KRoute.SetActive(false);

            I_CafRoute.SetActive(false);
            I_DRoute.SetActive(false);
            I_GRoute.SetActive(false);
            I_KRoute.SetActive(false);

            K_CafRoute.SetActive(false);
            K_DRoute.SetActive(false);
            K_IRoute.SetActive(false);
            K_GRoute.SetActive(false);

            /*ARLocation.PlaceAtLocations script creates a List of clones of a Prefab 
             * GameObject to place in the given coordinates, thus in order to deactivate 
             * the GameObjects of the non selected Route we need to iterate through the 
             * instances of each "GPS Stage Object" GameObject and call on each one the 
             * "HideGameObject()" method, which deactivates the MeshRenderer of each 
             * instance. Respectivelly we call the "ShowGameObject()" method for the 
             * selected Route. */
            foreach (var go1 in Caf_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go1);
            }

            foreach (var go2 in Caf_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go2);
            }

            foreach (var go3 in Caf_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go3);
            }

            foreach (var go4 in Caf_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.ShowGameObject(go4);
            }

            foreach (var go5 in D_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go5);
            }

            foreach (var go6 in D_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go6);
            }

            foreach (var go7 in D_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go7);
            }

            foreach (var go8 in D_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go8);
            }

            foreach (var go9 in G_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go9);
            }

            foreach (var go10 in G_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go10);
            }

            foreach (var go11 in G_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go11);
            }

            foreach (var go12 in G_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go12);
            }

            foreach (var go13 in I_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go13);
            }

            foreach (var go14 in I_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go14);
            }

            foreach (var go15 in I_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go15);
            }

            foreach (var go16 in I_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go16);
            }

            foreach (var go17 in K_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go17);
            }

            foreach (var go18 in K_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go18);
            }

            foreach (var go19 in K_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go19);
            }

            foreach (var go20 in K_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go20);
            }
        }

        if(value == 5)
        {
            /*Based on the value, which represents the enumeration of the Dropdown list 
             * options, we set the corresponding Route to Active or not Active.*/
            Caf_DRoute.SetActive(false);
            Caf_GRoute.SetActive(false);
            Caf_IRoute.SetActive(false);
            Caf_KRoute.SetActive(false);

            D_CafRoute.SetActive(true);
            D_IRoute.SetActive(false);
            D_GRoute.SetActive(false);
            D_KRoute.SetActive(false);

            G_CafRoute.SetActive(false);
            G_DRoute.SetActive(false);
            G_IRoute.SetActive(false);
            G_KRoute.SetActive(false);

            I_CafRoute.SetActive(false);
            I_DRoute.SetActive(false);
            I_GRoute.SetActive(false);
            I_KRoute.SetActive(false);

            K_CafRoute.SetActive(false);
            K_DRoute.SetActive(false);
            K_IRoute.SetActive(false);
            K_GRoute.SetActive(false);

            /*ARLocation.PlaceAtLocations script creates a List of clones of a Prefab 
             * GameObject to place in the given coordinates, thus in order to deactivate 
             * the GameObjects of the non selected Route we need to iterate through the 
             * instances of each "GPS Stage Object" GameObject and call on each one the 
             * "HideGameObject()" method, which deactivates the MeshRenderer of each 
             * instance. Respectivelly we call the "ShowGameObject()" method for the 
             * selected Route. */
            foreach (var go1 in Caf_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go1);
            }

            foreach (var go2 in Caf_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go2);
            }

            foreach (var go3 in Caf_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go3);
            }

            foreach (var go4 in Caf_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go4);
            }

            foreach (var go5 in D_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.ShowGameObject(go5);
            }

            foreach (var go6 in D_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go6);
            }

            foreach (var go7 in D_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go7);
            }

            foreach (var go8 in D_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go8);
            }

            foreach (var go9 in G_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go9);
            }

            foreach (var go10 in G_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go10);
            }

            foreach (var go11 in G_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go11);
            }

            foreach (var go12 in G_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go12);
            }

            foreach (var go13 in I_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go13);
            }

            foreach (var go14 in I_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go14);
            }

            foreach (var go15 in I_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go15);
            }

            foreach (var go16 in I_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go16);
            }

            foreach (var go17 in K_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go17);
            }

            foreach (var go18 in K_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go18);
            }

            foreach (var go19 in K_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go19);
            }

            foreach (var go20 in K_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go20);
            }
        }

        if(value == 6)
        {
            /*Based on the value, which represents the enumeration of the Dropdown list 
             * options, we set the corresponding Route to Active or not Active.*/
            Caf_DRoute.SetActive(false);
            Caf_GRoute.SetActive(false);
            Caf_IRoute.SetActive(false);
            Caf_KRoute.SetActive(false);

            D_CafRoute.SetActive(false);
            D_IRoute.SetActive(true);
            D_GRoute.SetActive(false);
            D_KRoute.SetActive(false);

            G_CafRoute.SetActive(false);
            G_DRoute.SetActive(false);
            G_IRoute.SetActive(false);
            G_KRoute.SetActive(false);

            I_CafRoute.SetActive(false);
            I_DRoute.SetActive(false);
            I_GRoute.SetActive(false);
            I_KRoute.SetActive(false);

            K_CafRoute.SetActive(false);
            K_DRoute.SetActive(false);
            K_IRoute.SetActive(false);
            K_GRoute.SetActive(false);

            /*ARLocation.PlaceAtLocations script creates a List of clones of a Prefab 
             * GameObject to place in the given coordinates, thus in order to deactivate 
             * the GameObjects of the non selected Route we need to iterate through the 
             * instances of each "GPS Stage Object" GameObject and call on each one the 
             * "HideGameObject()" method, which deactivates the MeshRenderer of each 
             * instance. Respectivelly we call the "ShowGameObject()" method for the 
             * selected Route. */
            foreach (var go1 in Caf_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go1);
            }

            foreach (var go2 in Caf_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go2);
            }

            foreach (var go3 in Caf_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go3);
            }

            foreach (var go4 in Caf_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go4);
            }

            foreach (var go5 in D_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go5);
            }

            foreach (var go6 in D_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.ShowGameObject(go6);
            }

            foreach (var go7 in D_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go7);
            }

            foreach (var go8 in D_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go8);
            }

            foreach (var go9 in G_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go9);
            }

            foreach (var go10 in G_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go10);
            }

            foreach (var go11 in G_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go11);
            }

            foreach (var go12 in G_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go12);
            }

            foreach (var go13 in I_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go13);
            }

            foreach (var go14 in I_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go14);
            }

            foreach (var go15 in I_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go15);
            }

            foreach (var go16 in I_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go16);
            }

            foreach (var go17 in K_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go17);
            }

            foreach (var go18 in K_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go18);
            }

            foreach (var go19 in K_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go19);
            }

            foreach (var go20 in K_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go20);
            }
        }

        if (value == 7)
        {
            /*Based on the value, which represents the enumeration of the Dropdown list 
             * options, we set the corresponding Route to Active or not Active.*/
            Caf_DRoute.SetActive(false);
            Caf_GRoute.SetActive(false);
            Caf_IRoute.SetActive(false);
            Caf_KRoute.SetActive(false);

            D_CafRoute.SetActive(false);
            D_IRoute.SetActive(false);
            D_GRoute.SetActive(true);
            D_KRoute.SetActive(false);

            G_CafRoute.SetActive(false);
            G_DRoute.SetActive(false);
            G_IRoute.SetActive(false);
            G_KRoute.SetActive(false);

            I_CafRoute.SetActive(false);
            I_DRoute.SetActive(false);
            I_GRoute.SetActive(false);
            I_KRoute.SetActive(false);

            K_CafRoute.SetActive(false);
            K_DRoute.SetActive(false);
            K_IRoute.SetActive(false);
            K_GRoute.SetActive(false);

            /*ARLocation.PlaceAtLocations script creates a List of clones of a Prefab 
             * GameObject to place in the given coordinates, thus in order to deactivate 
             * the GameObjects of the non selected Route we need to iterate through the 
             * instances of each "GPS Stage Object" GameObject and call on each one the 
             * "HideGameObject()" method, which deactivates the MeshRenderer of each 
             * instance. Respectivelly we call the "ShowGameObject()" method for the 
             * selected Route. */
            foreach (var go1 in Caf_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go1);
            }

            foreach (var go2 in Caf_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go2);
            }

            foreach (var go3 in Caf_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go3);
            }

            foreach (var go4 in Caf_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go4);
            }

            foreach (var go5 in D_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go5);
            }

            foreach (var go6 in D_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go6);
            }

            foreach (var go7 in D_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.ShowGameObject(go7);
            }

            foreach (var go8 in D_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go8);
            }

            foreach (var go9 in G_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go9);
            }

            foreach (var go10 in G_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go10);
            }

            foreach (var go11 in G_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go11);
            }

            foreach (var go12 in G_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go12);
            }

            foreach (var go13 in I_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go13);
            }

            foreach (var go14 in I_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go14);
            }

            foreach (var go15 in I_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go15);
            }

            foreach (var go16 in I_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go16);
            }

            foreach (var go17 in K_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go17);
            }

            foreach (var go18 in K_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go18);
            }

            foreach (var go19 in K_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go19);
            }

            foreach (var go20 in K_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go20);
            }
        }

        if (value == 8)
        {
            /*Based on the value, which represents the enumeration of the Dropdown list 
             * options, we set the corresponding Route to Active or not Active.*/
            Caf_DRoute.SetActive(false);
            Caf_GRoute.SetActive(false);
            Caf_IRoute.SetActive(false);
            Caf_KRoute.SetActive(false);

            D_CafRoute.SetActive(false);
            D_IRoute.SetActive(false);
            D_GRoute.SetActive(false);
            D_KRoute.SetActive(true);

            G_CafRoute.SetActive(false);
            G_DRoute.SetActive(false);
            G_IRoute.SetActive(false);
            G_KRoute.SetActive(false);

            I_CafRoute.SetActive(false);
            I_DRoute.SetActive(false);
            I_GRoute.SetActive(false);
            I_KRoute.SetActive(false);

            K_CafRoute.SetActive(false);
            K_DRoute.SetActive(false);
            K_IRoute.SetActive(false);
            K_GRoute.SetActive(false);

            /*ARLocation.PlaceAtLocations script creates a List of clones of a Prefab 
             * GameObject to place in the given coordinates, thus in order to deactivate 
             * the GameObjects of the non selected Route we need to iterate through the 
             * instances of each "GPS Stage Object" GameObject and call on each one the 
             * "HideGameObject()" method, which deactivates the MeshRenderer of each 
             * instance. Respectivelly we call the "ShowGameObject()" method for the 
             * selected Route. */
            foreach (var go1 in Caf_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go1);
            }

            foreach (var go2 in Caf_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go2);
            }

            foreach (var go3 in Caf_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go3);
            }

            foreach (var go4 in Caf_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go4);
            }

            foreach (var go5 in D_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go5);
            }

            foreach (var go6 in D_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go6);
            }

            foreach (var go7 in D_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go7);
            }

            foreach (var go8 in D_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.ShowGameObject(go8);
            }

            foreach (var go9 in G_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go9);
            }

            foreach (var go10 in G_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go10);
            }

            foreach (var go11 in G_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go11);
            }

            foreach (var go12 in G_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go12);
            }

            foreach (var go13 in I_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go13);
            }

            foreach (var go14 in I_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go14);
            }

            foreach (var go15 in I_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go15);
            }

            foreach (var go16 in I_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go16);
            }

            foreach (var go17 in K_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go17);
            }

            foreach (var go18 in K_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go18);
            }

            foreach (var go19 in K_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go19);
            }

            foreach (var go20 in K_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go20);
            }
        }

        if (value == 9)
        {
            /*Based on the value, which represents the enumeration of the Dropdown list 
             * options, we set the corresponding Route to Active or not Active.*/
            Caf_DRoute.SetActive(false);
            Caf_GRoute.SetActive(false);
            Caf_IRoute.SetActive(false);
            Caf_KRoute.SetActive(false);

            D_CafRoute.SetActive(false);
            D_IRoute.SetActive(false);
            D_GRoute.SetActive(false);
            D_KRoute.SetActive(false);

            G_CafRoute.SetActive(true);
            G_DRoute.SetActive(false);
            G_IRoute.SetActive(false);
            G_KRoute.SetActive(false);

            I_CafRoute.SetActive(false);
            I_DRoute.SetActive(false);
            I_GRoute.SetActive(false);
            I_KRoute.SetActive(false);

            K_CafRoute.SetActive(false);
            K_DRoute.SetActive(false);
            K_IRoute.SetActive(false);
            K_GRoute.SetActive(false);

            /*ARLocation.PlaceAtLocations script creates a List of clones of a Prefab 
             * GameObject to place in the given coordinates, thus in order to deactivate 
             * the GameObjects of the non selected Route we need to iterate through the 
             * instances of each "GPS Stage Object" GameObject and call on each one the 
             * "HideGameObject()" method, which deactivates the MeshRenderer of each 
             * instance. Respectivelly we call the "ShowGameObject()" method for the 
             * selected Route. */
            foreach (var go1 in Caf_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go1);
            }

            foreach (var go2 in Caf_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go2);
            }

            foreach (var go3 in Caf_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go3);
            }

            foreach (var go4 in Caf_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go4);
            }

            foreach (var go5 in D_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go5);
            }

            foreach (var go6 in D_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go6);
            }

            foreach (var go7 in D_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go7);
            }

            foreach (var go8 in D_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go8);
            }

            foreach (var go9 in G_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.ShowGameObject(go9);
            }

            foreach (var go10 in G_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go10);
            }

            foreach (var go11 in G_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go11);
            }

            foreach (var go12 in G_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go12);
            }

            foreach (var go13 in I_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go13);
            }

            foreach (var go14 in I_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go14);
            }

            foreach (var go15 in I_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go15);
            }

            foreach (var go16 in I_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go16);
            }

            foreach (var go17 in K_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go17);
            }

            foreach (var go18 in K_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go18);
            }

            foreach (var go19 in K_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go19);
            }

            foreach (var go20 in K_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go20);
            }
        }

        if (value == 10)
        {
            /*Based on the value, which represents the enumeration of the Dropdown list 
             * options, we set the corresponding Route to Active or not Active.*/
            Caf_DRoute.SetActive(false);
            Caf_GRoute.SetActive(false);
            Caf_IRoute.SetActive(false);
            Caf_KRoute.SetActive(false);

            D_CafRoute.SetActive(false);
            D_IRoute.SetActive(false);
            D_GRoute.SetActive(false);
            D_KRoute.SetActive(false);

            G_CafRoute.SetActive(false);
            G_DRoute.SetActive(true);
            G_IRoute.SetActive(false);
            G_KRoute.SetActive(false);

            I_CafRoute.SetActive(false);
            I_DRoute.SetActive(false);
            I_GRoute.SetActive(false);
            I_KRoute.SetActive(false);

            K_CafRoute.SetActive(false);
            K_DRoute.SetActive(false);
            K_IRoute.SetActive(false);
            K_GRoute.SetActive(false);

            /*ARLocation.PlaceAtLocations script creates a List of clones of a Prefab 
             * GameObject to place in the given coordinates, thus in order to deactivate 
             * the GameObjects of the non selected Route we need to iterate through the 
             * instances of each "GPS Stage Object" GameObject and call on each one the 
             * "HideGameObject()" method, which deactivates the MeshRenderer of each 
             * instance. Respectivelly we call the "ShowGameObject()" method for the 
             * selected Route. */
            foreach (var go1 in Caf_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go1);
            }

            foreach (var go2 in Caf_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go2);
            }

            foreach (var go3 in Caf_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go3);
            }

            foreach (var go4 in Caf_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go4);
            }

            foreach (var go5 in D_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go5);
            }

            foreach (var go6 in D_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go6);
            }

            foreach (var go7 in D_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go7);
            }

            foreach (var go8 in D_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go8);
            }

            foreach (var go9 in G_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go9);
            }

            foreach (var go10 in G_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.ShowGameObject(go10);
            }

            foreach (var go11 in G_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go11);
            }

            foreach (var go12 in G_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go12);
            }

            foreach (var go13 in I_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go13);
            }

            foreach (var go14 in I_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go14);
            }

            foreach (var go15 in I_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go15);
            }

            foreach (var go16 in I_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go16);
            }

            foreach (var go17 in K_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go17);
            }

            foreach (var go18 in K_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go18);
            }

            foreach (var go19 in K_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go19);
            }

            foreach (var go20 in K_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go20);
            }
        }

        if (value == 11)
        {
            /*Based on the value, which represents the enumeration of the Dropdown list 
             * options, we set the corresponding Route to Active or not Active.*/
            Caf_DRoute.SetActive(false);
            Caf_GRoute.SetActive(false);
            Caf_IRoute.SetActive(false);
            Caf_KRoute.SetActive(false);

            D_CafRoute.SetActive(false);
            D_IRoute.SetActive(false);
            D_GRoute.SetActive(false);
            D_KRoute.SetActive(false);

            G_CafRoute.SetActive(false);
            G_DRoute.SetActive(false);
            G_IRoute.SetActive(true);
            G_KRoute.SetActive(false);

            I_CafRoute.SetActive(false);
            I_DRoute.SetActive(false);
            I_GRoute.SetActive(false);
            I_KRoute.SetActive(false);

            K_CafRoute.SetActive(false);
            K_DRoute.SetActive(false);
            K_IRoute.SetActive(false);
            K_GRoute.SetActive(false);

            /*ARLocation.PlaceAtLocations script creates a List of clones of a Prefab 
             * GameObject to place in the given coordinates, thus in order to deactivate 
             * the GameObjects of the non selected Route we need to iterate through the 
             * instances of each "GPS Stage Object" GameObject and call on each one the 
             * "HideGameObject()" method, which deactivates the MeshRenderer of each 
             * instance. Respectivelly we call the "ShowGameObject()" method for the 
             * selected Route. */
            foreach (var go1 in Caf_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go1);
            }

            foreach (var go2 in Caf_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go2);
            }

            foreach (var go3 in Caf_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go3);
            }

            foreach (var go4 in Caf_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go4);
            }

            foreach (var go5 in D_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go5);
            }

            foreach (var go6 in D_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go6);
            }

            foreach (var go7 in D_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go7);
            }

            foreach (var go8 in D_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go8);
            }

            foreach (var go9 in G_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go9);
            }

            foreach (var go10 in G_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go10);
            }

            foreach (var go11 in G_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.ShowGameObject(go11);
            }

            foreach (var go12 in G_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go12);
            }

            foreach (var go13 in I_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go13);
            }

            foreach (var go14 in I_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go14);
            }

            foreach (var go15 in I_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go15);
            }

            foreach (var go16 in I_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go16);
            }

            foreach (var go17 in K_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go17);
            }

            foreach (var go18 in K_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go18);
            }

            foreach (var go19 in K_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go19);
            }

            foreach (var go20 in K_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go20);
            }
        }

        if (value == 12)
        {
            /*Based on the value, which represents the enumeration of the Dropdown list 
             * options, we set the corresponding Route to Active or not Active.*/
            Caf_DRoute.SetActive(false);
            Caf_GRoute.SetActive(false);
            Caf_IRoute.SetActive(false);
            Caf_KRoute.SetActive(false);

            D_CafRoute.SetActive(false);
            D_IRoute.SetActive(false);
            D_GRoute.SetActive(false);
            D_KRoute.SetActive(false);

            G_CafRoute.SetActive(false);
            G_DRoute.SetActive(false);
            G_IRoute.SetActive(false);
            G_KRoute.SetActive(true);

            I_CafRoute.SetActive(false);
            I_DRoute.SetActive(false);
            I_GRoute.SetActive(false);
            I_KRoute.SetActive(false);

            K_CafRoute.SetActive(false);
            K_DRoute.SetActive(false);
            K_IRoute.SetActive(false);
            K_GRoute.SetActive(false);

            /*ARLocation.PlaceAtLocations script creates a List of clones of a Prefab 
             * GameObject to place in the given coordinates, thus in order to deactivate 
             * the GameObjects of the non selected Route we need to iterate through the 
             * instances of each "GPS Stage Object" GameObject and call on each one the 
             * "HideGameObject()" method, which deactivates the MeshRenderer of each 
             * instance. Respectivelly we call the "ShowGameObject()" method for the 
             * selected Route. */
            foreach (var go1 in Caf_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go1);
            }

            foreach (var go2 in Caf_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go2);
            }

            foreach (var go3 in Caf_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go3);
            }

            foreach (var go4 in Caf_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go4);
            }

            foreach (var go5 in D_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go5);
            }

            foreach (var go6 in D_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go6);
            }

            foreach (var go7 in D_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go7);
            }

            foreach (var go8 in D_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go8);
            }

            foreach (var go9 in G_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go9);
            }

            foreach (var go10 in G_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go10);
            }

            foreach (var go11 in G_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go11);
            }

            foreach (var go12 in G_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.ShowGameObject(go12);
            }

            foreach (var go13 in I_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go13);
            }

            foreach (var go14 in I_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go14);
            }

            foreach (var go15 in I_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go15);
            }

            foreach (var go16 in I_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go16);
            }

            foreach (var go17 in K_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go17);
            }

            foreach (var go18 in K_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go18);
            }

            foreach (var go19 in K_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go19);
            }

            foreach (var go20 in K_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go20);
            }
        }

        if (value == 13)
        {
            /*Based on the value, which represents the enumeration of the Dropdown list 
             * options, we set the corresponding Route to Active or not Active.*/
            Caf_DRoute.SetActive(false);
            Caf_GRoute.SetActive(false);
            Caf_IRoute.SetActive(false);
            Caf_KRoute.SetActive(false);

            D_CafRoute.SetActive(false);
            D_IRoute.SetActive(false);
            D_GRoute.SetActive(false);
            D_KRoute.SetActive(false);

            G_CafRoute.SetActive(false);
            G_DRoute.SetActive(false);
            G_IRoute.SetActive(false);
            G_KRoute.SetActive(false);

            I_CafRoute.SetActive(true);
            I_DRoute.SetActive(false);
            I_GRoute.SetActive(false);
            I_KRoute.SetActive(false);

            K_CafRoute.SetActive(false);
            K_DRoute.SetActive(false);
            K_IRoute.SetActive(false);
            K_GRoute.SetActive(false);

            /*ARLocation.PlaceAtLocations script creates a List of clones of a Prefab 
             * GameObject to place in the given coordinates, thus in order to deactivate 
             * the GameObjects of the non selected Route we need to iterate through the 
             * instances of each "GPS Stage Object" GameObject and call on each one the 
             * "HideGameObject()" method, which deactivates the MeshRenderer of each 
             * instance. Respectivelly we call the "ShowGameObject()" method for the 
             * selected Route. */
            foreach (var go1 in Caf_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go1);
            }

            foreach (var go2 in Caf_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go2);
            }

            foreach (var go3 in Caf_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go3);
            }

            foreach (var go4 in Caf_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go4);
            }

            foreach (var go5 in D_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go5);
            }

            foreach (var go6 in D_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go6);
            }

            foreach (var go7 in D_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go7);
            }

            foreach (var go8 in D_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go8);
            }

            foreach (var go9 in G_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go9);
            }

            foreach (var go10 in G_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go10);
            }

            foreach (var go11 in G_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go11);
            }

            foreach (var go12 in G_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go12);
            }

            foreach (var go13 in I_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.ShowGameObject(go13);
            }

            foreach (var go14 in I_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go14);
            }

            foreach (var go15 in I_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go15);
            }

            foreach (var go16 in I_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go16);
            }

            foreach (var go17 in K_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go17);
            }

            foreach (var go18 in K_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go18);
            }

            foreach (var go19 in K_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go19);
            }

            foreach (var go20 in K_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go20);
            }
        }

        if (value == 14)
        {
            /*Based on the value, which represents the enumeration of the Dropdown list 
             * options, we set the corresponding Route to Active or not Active.*/
            Caf_DRoute.SetActive(false);
            Caf_GRoute.SetActive(false);
            Caf_IRoute.SetActive(false);
            Caf_KRoute.SetActive(false);

            D_CafRoute.SetActive(false);
            D_IRoute.SetActive(false);
            D_GRoute.SetActive(false);
            D_KRoute.SetActive(false);

            G_CafRoute.SetActive(false);
            G_DRoute.SetActive(false);
            G_IRoute.SetActive(false);
            G_KRoute.SetActive(false);

            I_CafRoute.SetActive(false);
            I_DRoute.SetActive(true);
            I_GRoute.SetActive(false);
            I_KRoute.SetActive(false);

            K_CafRoute.SetActive(false);
            K_DRoute.SetActive(false);
            K_IRoute.SetActive(false);
            K_GRoute.SetActive(false);

            /*ARLocation.PlaceAtLocations script creates a List of clones of a Prefab 
             * GameObject to place in the given coordinates, thus in order to deactivate 
             * the GameObjects of the non selected Route we need to iterate through the 
             * instances of each "GPS Stage Object" GameObject and call on each one the 
             * "HideGameObject()" method, which deactivates the MeshRenderer of each 
             * instance. Respectivelly we call the "ShowGameObject()" method for the 
             * selected Route. */
            foreach (var go1 in Caf_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go1);
            }

            foreach (var go2 in Caf_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go2);
            }

            foreach (var go3 in Caf_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go3);
            }

            foreach (var go4 in Caf_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go4);
            }

            foreach (var go5 in D_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go5);
            }

            foreach (var go6 in D_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go6);
            }

            foreach (var go7 in D_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go7);
            }

            foreach (var go8 in D_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go8);
            }

            foreach (var go9 in G_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go9);
            }

            foreach (var go10 in G_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go10);
            }

            foreach (var go11 in G_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go11);
            }

            foreach (var go12 in G_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go12);
            }

            foreach (var go13 in I_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go13);
            }

            foreach (var go14 in I_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.ShowGameObject(go14);
            }

            foreach (var go15 in I_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go15);
            }

            foreach (var go16 in I_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go16);
            }

            foreach (var go17 in K_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go17);
            }

            foreach (var go18 in K_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go18);
            }

            foreach (var go19 in K_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go19);
            }

            foreach (var go20 in K_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go20);
            }
        }

        if (value == 15)
        {            /*Based on the value, which represents the enumeration of the Dropdown list 
             * options, we set the corresponding Route to Active or not Active.*/
            Caf_DRoute.SetActive(false);
            Caf_GRoute.SetActive(false);
            Caf_IRoute.SetActive(false);
            Caf_KRoute.SetActive(false);

            D_CafRoute.SetActive(false);
            D_IRoute.SetActive(false);
            D_GRoute.SetActive(false);
            D_KRoute.SetActive(false);

            G_CafRoute.SetActive(false);
            G_DRoute.SetActive(false);
            G_IRoute.SetActive(false);
            G_KRoute.SetActive(false);

            I_CafRoute.SetActive(false);
            I_DRoute.SetActive(false);
            I_GRoute.SetActive(true);
            I_KRoute.SetActive(false);

            K_CafRoute.SetActive(false);
            K_DRoute.SetActive(false);
            K_IRoute.SetActive(false);
            K_GRoute.SetActive(false);

            /*ARLocation.PlaceAtLocations script creates a List of clones of a Prefab 
             * GameObject to place in the given coordinates, thus in order to deactivate 
             * the GameObjects of the non selected Route we need to iterate through the 
             * instances of each "GPS Stage Object" GameObject and call on each one the 
             * "HideGameObject()" method, which deactivates the MeshRenderer of each 
             * instance. Respectivelly we call the "ShowGameObject()" method for the 
             * selected Route. */
            foreach (var go1 in Caf_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go1);
            }

            foreach(var go2 in Caf_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go2);
            }

            foreach(var go3 in Caf_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go3);
            }

            foreach(var go4 in Caf_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go4);
            }

            foreach (var go5 in D_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go5);
            }

            foreach (var go6 in D_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go6);
            }

            foreach (var go7 in D_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go7);
            }

            foreach (var go8 in D_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go8);
            }

            foreach (var go9 in G_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go9);
            }

            foreach (var go10 in G_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go10);
            }

            foreach (var go11 in G_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go11);
            }

            foreach (var go12 in G_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go12);
            }

            foreach (var go13 in I_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go13);
            }

            foreach (var go14 in I_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go14);
            }

            foreach (var go15 in I_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.ShowGameObject(go15);
            }

            foreach (var go16 in I_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go16);
            }

            foreach (var go17 in K_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go17);
            }

            foreach (var go18 in K_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go18);
            }

            foreach (var go19 in K_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go19);
            }

            foreach (var go20 in K_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go20);
            }

        }

        if (value == 16)
        {
            /*Based on the value, which represents the enumeration of the Dropdown list 
             * options, we set the corresponding Route to Active or not Active.*/
            Caf_DRoute.SetActive(false);
            Caf_GRoute.SetActive(false);
            Caf_IRoute.SetActive(false);
            Caf_KRoute.SetActive(false);

            D_CafRoute.SetActive(false);
            D_IRoute.SetActive(false);
            D_GRoute.SetActive(false);
            D_KRoute.SetActive(false);

            G_CafRoute.SetActive(false);
            G_DRoute.SetActive(false);
            G_IRoute.SetActive(false);
            G_KRoute.SetActive(false);

            I_CafRoute.SetActive(false);
            I_DRoute.SetActive(false);
            I_GRoute.SetActive(false);
            I_KRoute.SetActive(true);

            K_CafRoute.SetActive(false);
            K_DRoute.SetActive(false);
            K_IRoute.SetActive(false);
            K_GRoute.SetActive(false);

            /*ARLocation.PlaceAtLocations script creates a List of clones of a Prefab 
             * GameObject to place in the given coordinates, thus in order to deactivate 
             * the GameObjects of the non selected Route we need to iterate through the 
             * instances of each "GPS Stage Object" GameObject and call on each one the 
             * "HideGameObject()" method, which deactivates the MeshRenderer of each 
             * instance. Respectivelly we call the "ShowGameObject()" method for the 
             * selected Route. */
            foreach (var go1 in Caf_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go1);
            }

            foreach (var go2 in Caf_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go2);
            }

            foreach (var go3 in Caf_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go3);
            }

            foreach (var go4 in Caf_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go4);
            }

            foreach (var go5 in D_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go5);
            }

            foreach (var go6 in D_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go6);
            }

            foreach (var go7 in D_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go7);
            }

            foreach (var go8 in D_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go8);
            }

            foreach (var go9 in G_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go9);
            }

            foreach (var go10 in G_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go10);
            }

            foreach (var go11 in G_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go11);
            }

            foreach (var go12 in G_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go12);
            }

            foreach (var go13 in I_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go13);
            }

            foreach (var go14 in I_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go14);
            }

            foreach (var go15 in I_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go15);
            }

            foreach (var go16 in I_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.ShowGameObject(go16);
            }

            foreach (var go17 in K_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go17);
            }

            foreach (var go18 in K_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go18);
            }

            foreach (var go19 in K_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go19);
            }

            foreach (var go20 in K_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go20);
            }
        }

        if (value == 17)
        {
            /*Based on the value, which represents the enumeration of the Dropdown list 
             * options, we set the corresponding Route to Active or not Active.*/
            Caf_DRoute.SetActive(false);
            Caf_GRoute.SetActive(false);
            Caf_IRoute.SetActive(false);
            Caf_KRoute.SetActive(false);

            D_CafRoute.SetActive(false);
            D_IRoute.SetActive(false);
            D_GRoute.SetActive(false);
            D_KRoute.SetActive(false);

            G_CafRoute.SetActive(false);
            G_DRoute.SetActive(false);
            G_IRoute.SetActive(false);
            G_KRoute.SetActive(false);

            I_CafRoute.SetActive(false);
            I_DRoute.SetActive(false);
            I_GRoute.SetActive(false);
            I_KRoute.SetActive(false);

            K_CafRoute.SetActive(true);
            K_DRoute.SetActive(false);
            K_IRoute.SetActive(false);
            K_GRoute.SetActive(false);

            /*ARLocation.PlaceAtLocations script creates a List of clones of a Prefab 
             * GameObject to place in the given coordinates, thus in order to deactivate 
             * the GameObjects of the non selected Route we need to iterate through the 
             * instances of each "GPS Stage Object" GameObject and call on each one the 
             * "HideGameObject()" method, which deactivates the MeshRenderer of each 
             * instance. Respectivelly we call the "ShowGameObject()" method for the 
             * selected Route. */
            foreach (var go1 in Caf_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go1);
            }

            foreach (var go2 in Caf_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go2);
            }

            foreach (var go3 in Caf_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go3);
            }

            foreach (var go4 in Caf_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go4);
            }

            foreach (var go5 in D_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go5);
            }

            foreach (var go6 in D_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go6);
            }

            foreach (var go7 in D_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go7);
            }

            foreach (var go8 in D_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go8);
            }

            foreach (var go9 in G_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go9);
            }

            foreach (var go10 in G_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go10);
            }

            foreach (var go11 in G_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go11);
            }

            foreach (var go12 in G_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go12);
            }

            foreach (var go13 in I_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go13);
            }

            foreach (var go14 in I_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go14);
            }

            foreach (var go15 in I_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go15);
            }

            foreach (var go16 in I_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go16);
            }

            foreach (var go17 in K_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.ShowGameObject(go17);
            }

            foreach (var go18 in K_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go18);
            }

            foreach (var go19 in K_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go19);
            }

            foreach (var go20 in K_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go20);
            }
        }

        if (value == 18)
        {
            /*Based on the value, which represents the enumeration of the Dropdown list 
             * options, we set the corresponding Route to Active or not Active.*/
            Caf_DRoute.SetActive(false);
            Caf_GRoute.SetActive(false);
            Caf_IRoute.SetActive(false);
            Caf_KRoute.SetActive(false);

            D_CafRoute.SetActive(false);
            D_IRoute.SetActive(false);
            D_GRoute.SetActive(false);
            D_KRoute.SetActive(false);

            G_CafRoute.SetActive(false);
            G_DRoute.SetActive(false);
            G_IRoute.SetActive(false);
            G_KRoute.SetActive(false);

            I_CafRoute.SetActive(false);
            I_DRoute.SetActive(false);
            I_GRoute.SetActive(false);
            I_KRoute.SetActive(false);

            K_CafRoute.SetActive(false);
            K_DRoute.SetActive(true);
            K_IRoute.SetActive(false);
            K_GRoute.SetActive(false);

            /*ARLocation.PlaceAtLocations script creates a List of clones of a Prefab 
             * GameObject to place in the given coordinates, thus in order to deactivate 
             * the GameObjects of the non selected Route we need to iterate through the 
             * instances of each "GPS Stage Object" GameObject and call on each one the 
             * "HideGameObject()" method, which deactivates the MeshRenderer of each 
             * instance. Respectivelly we call the "ShowGameObject()" method for the 
             * selected Route. */
            foreach (var go1 in Caf_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go1);
            }

            foreach (var go2 in Caf_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go2);
            }

            foreach (var go3 in Caf_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go3);
            }

            foreach (var go4 in Caf_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go4);
            }

            foreach (var go5 in D_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go5);
            }

            foreach (var go6 in D_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go6);
            }

            foreach (var go7 in D_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go7);
            }

            foreach (var go8 in D_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go8);
            }

            foreach (var go9 in G_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go9);
            }

            foreach (var go10 in G_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go10);
            }

            foreach (var go11 in G_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go11);
            }

            foreach (var go12 in G_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go12);
            }

            foreach (var go13 in I_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go13);
            }

            foreach (var go14 in I_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go14);
            }

            foreach (var go15 in I_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go15);
            }

            foreach (var go16 in I_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go16);
            }

            foreach (var go17 in K_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go17);
            }

            foreach (var go18 in K_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.ShowGameObject(go18);
            }

            foreach (var go19 in K_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go19);
            }

            foreach (var go20 in K_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go20);
            }
        }

        if (value == 19)
        {
            /*Based on the value, which represents the enumeration of the Dropdown list 
             * options, we set the corresponding Route to Active or not Active.*/
            Caf_DRoute.SetActive(false);
            Caf_GRoute.SetActive(false);
            Caf_IRoute.SetActive(false);
            Caf_KRoute.SetActive(false);

            D_CafRoute.SetActive(false);
            D_IRoute.SetActive(false);
            D_GRoute.SetActive(false);
            D_KRoute.SetActive(false);

            G_CafRoute.SetActive(false);
            G_DRoute.SetActive(false);
            G_IRoute.SetActive(false);
            G_KRoute.SetActive(false);

            I_CafRoute.SetActive(false);
            I_DRoute.SetActive(false);
            I_GRoute.SetActive(false);
            I_KRoute.SetActive(false);

            K_CafRoute.SetActive(false);
            K_DRoute.SetActive(false);
            K_IRoute.SetActive(true);
            K_GRoute.SetActive(false);

            /*ARLocation.PlaceAtLocations script creates a List of clones of a Prefab 
             * GameObject to place in the given coordinates, thus in order to deactivate 
             * the GameObjects of the non selected Route we need to iterate through the 
             * instances of each "GPS Stage Object" GameObject and call on each one the 
             * "HideGameObject()" method, which deactivates the MeshRenderer of each 
             * instance. Respectivelly we call the "ShowGameObject()" method for the 
             * selected Route. */
            foreach (var go1 in Caf_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go1);
            }

            foreach (var go2 in Caf_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go2);
            }

            foreach (var go3 in Caf_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go3);
            }

            foreach (var go4 in Caf_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go4);
            }

            foreach (var go5 in D_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go5);
            }

            foreach (var go6 in D_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go6);
            }

            foreach (var go7 in D_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go7);
            }

            foreach (var go8 in D_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go8);
            }

            foreach (var go9 in G_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go9);
            }

            foreach (var go10 in G_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go10);
            }

            foreach (var go11 in G_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go11);
            }

            foreach (var go12 in G_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go12);
            }

            foreach (var go13 in I_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go13);
            }

            foreach (var go14 in I_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go14);
            }

            foreach (var go15 in I_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go15);
            }

            foreach (var go16 in I_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go16);
            }

            foreach (var go17 in K_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go17);
            }

            foreach (var go18 in K_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go18);
            }

            foreach (var go19 in K_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.ShowGameObject(go19);
            }

            foreach (var go20 in K_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go20);
            }
        }

        if (value == 20)
        {
            /*Based on the value, which represents the enumeration of the Dropdown list 
             * options, we set the corresponding Route to Active or not Active.*/
            Caf_DRoute.SetActive(false);
            Caf_GRoute.SetActive(false);
            Caf_IRoute.SetActive(false);
            Caf_KRoute.SetActive(false);

            D_CafRoute.SetActive(false);
            D_IRoute.SetActive(false);
            D_GRoute.SetActive(false);
            D_KRoute.SetActive(false);

            G_CafRoute.SetActive(false);
            G_DRoute.SetActive(false);
            G_IRoute.SetActive(false);
            G_KRoute.SetActive(false);

            I_CafRoute.SetActive(false);
            I_DRoute.SetActive(false);
            I_GRoute.SetActive(false);
            I_KRoute.SetActive(false);

            K_CafRoute.SetActive(false);
            K_DRoute.SetActive(false);
            K_IRoute.SetActive(false);
            K_GRoute.SetActive(true);

            /*ARLocation.PlaceAtLocations script creates a List of clones of a Prefab 
             * GameObject to place in the given coordinates, thus in order to deactivate 
             * the GameObjects of the non selected Route we need to iterate through the 
             * instances of each "GPS Stage Object" GameObject and call on each one the 
             * "HideGameObject()" method, which deactivates the MeshRenderer of each 
             * instance. Respectivelly we call the "ShowGameObject()" method for the 
             * selected Route. */
            foreach (var go1 in Caf_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go1);
            }

            foreach (var go2 in Caf_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go2);
            }

            foreach (var go3 in Caf_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go3);
            }

            foreach (var go4 in Caf_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go4);
            }

            foreach (var go5 in D_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go5);
            }

            foreach (var go6 in D_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go6);
            }

            foreach (var go7 in D_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go7);
            }

            foreach (var go8 in D_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go8);
            }

            foreach (var go9 in G_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go9);
            }

            foreach (var go10 in G_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go10);
            }

            foreach (var go11 in G_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go11);
            }

            foreach (var go12 in G_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go12);
            }

            foreach (var go13 in I_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go13);
            }

            foreach (var go14 in I_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go14);
            }

            foreach (var go15 in I_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go15);
            }

            foreach (var go16 in I_KGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go16);
            }

            foreach (var go17 in K_CafGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go17);
            }

            foreach (var go18 in K_DGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go18);
            }

            foreach (var go19 in K_IGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.HideGameObject(go19);
            }

            foreach (var go20 in K_GGps.GetComponent<PlaceAtLocations>().Instances)
            {
                Misc.ShowGameObject(go20);
            }
        }
    }
}

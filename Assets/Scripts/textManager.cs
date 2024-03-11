using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textManager : MonoBehaviour
{
    public Text lat, lon;
    // Start is called before the first frame update
    // WE dont need start function as it is already there in GPS script 
    // Here we are just updating langitude and Longitude variable 


/*But what I'm going to do is I'm going to use the update function which is called once per Frane.
So basically it will do a check on the GP as an update in a text box.
Every time a new frame is loaded in the software.
So if the apps running at 30 frames per second then it will update the statement 30 times a second or
60 times a second which will make it very very accurate and quick.
Now I don't usually play with update functions too much because they're quite heavy on the app itself
on battery performance but in this particular case all what we're doing is overwriting a text field.
Such a simplistic action won't be very consuming at all.*/
  void FixedUpdate()
  {
        lat.text ="LAT: "+ GPS.latitude.ToString();
        lon.text = "LON: "+GPS.longitude.ToString();
  }
}
  
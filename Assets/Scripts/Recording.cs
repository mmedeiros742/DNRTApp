/*
 *  For more information on Pedometer api using unity, 
 *  check here: https://forum.unity.com/threads/pedometer-api-native-step-counter.483408/
 *
**/
namespace PedometerU.Tests {
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Android;
    using UnityEngine.UI;

    public class Recording : MonoBehaviour
    {
        public Text bText;
        public Text step;
        public Text dist;
        private Pedometer pedometer;

        public void Start () {

                // Ask for permission to use  android.permission.ACTIVITY_RECOGNITION
                if(AndroidRuntimePermissions.CheckPermission("com.google.android.gms.permission.ACTIVITY_RECOGNITION") == AndroidRuntimePermissions.Permission.Granted){
                    // Create a new pedometer
                    pedometer = new Pedometer(OnStep);
                    // Reset UI
                    OnStep(0, 0);
                }
                
                else{
                    AndroidRuntimePermissions.Permission result = AndroidRuntimePermissions.RequestPermission("com.google.android.gms.permission.ACTIVITY_RECOGNITION");
                    AndroidRuntimePermissions.OpenSettings();
                }
        }

        public void OnStep (int steps, double distance) {
            // Display the values
            step.text = steps.ToString();
            // Display distance in miles
            dist.text = (distance * 0.000621371).ToString("F2") + " mi.";
        }

        public void Stop()
        {
            pedometer.Dispose();
        }

    }
}

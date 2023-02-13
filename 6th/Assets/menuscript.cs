using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuscript : MonoBehaviour
{
    public GameObject car;
    public GameObject bus;

    void start()
    {
        bus.SetActive(false);
        car.SetActive(false);
    }

    public void openBus()
    {
        bus.SetActive(true);
        car.SetActive(false);
    }

    public void openCar()
    {
        car.SetActive(true);
        bus.SetActive(false);
    }
}

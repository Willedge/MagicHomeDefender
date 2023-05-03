using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tiaozhuan : MonoBehaviour
{
    // Start is called before the first frame update
   // go to register
    public void Register()
    {
        SceneManager.LoadScene("Register");
    }
    //go to log in
   public void Login()
    {
        SceneManager.LoadScene("Log");
    }
    public void Log()
    {
        SceneManager.LoadScene("Mainenvironment");
    }
    //menu
    public void Menu()
    {
        SceneManager.LoadScene("Mainmenu");
    }
    public void Personel()
    {
        SceneManager.LoadScene("Personel");
    }
    public void Market()
    {
        SceneManager.LoadScene("Market");
    }
    public void Setting()
    {
        SceneManager.LoadScene("Setting");
    }
    public void Bag()
    {
        SceneManager.LoadScene("Bag");
    }
    public void Friend()
    {
        SceneManager.LoadScene("Friend");
    }
    public void close()
    {
        SceneManager.LoadScene("Mainenvironment");
    }
    public void Change()
    {
        SceneManager.LoadScene("Personel");
    }
   public void Changename()
    {
        SceneManager.LoadScene("ChangeName");
    }
    public void Changepassword()
    {
        SceneManager.LoadScene("ChangePassword");
    }

}

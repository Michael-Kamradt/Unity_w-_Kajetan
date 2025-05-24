using System.Linq;
using MyBox;
using UnityEngine;

public class StringCecker : MonoBehaviour
{
   public string userName;
   public string eMail;
   
   
   [ButtonMethod]
   void CheckUsername()
   {
       if (userName.Length > 8 && userName.All(char.IsLetter))//checkt die länge das usernames
       {
           
           Debug.Log(userName + " hat mehr als 8 zeichen");
           
       }
       else if (userName.Length < 8 && userName.All(char.IsLetter))
       {
           Debug.Log(userName + " hat weniger als 8 zeichen");
       }
       else
       {
          Debug.Log(userName + " enthält zahlen"); 
           
       }
       
      
   }
    [ButtonMethod]
   void CheckEmail()
   {
       if (eMail.Length >= 10 && eMail.Contains("@"))
       {
           
           Debug.Log(eMail + " Email aktzeptiert");
           
       }
       else if (eMail.Length <= 10 && eMail.Contains("@"))
       {
           Debug.Log(eMail+ " hat zu wenige zeichen");
       }
       else if (eMail.Length <= 10)
       {
           Debug.Log(eMail + " hat zu wenige zeichen und das @ fehlt"); 
           
       }
       else
       {
           Debug.Log(eMail + " das @ fehlt");
       }
   }
}


using System.ComponentModel.DataAnnotations;

namespace InstagramMVC.Models;

public class Photo
{
    public int PhotoId {get; set;}
    public string Url {get; set;}
    public string Description {get; set;}
    public int UserId {get; set;}
     public User User {get; set;}

}